﻿using Microsoft.Extensions.Options;
using smartmoney.Settings;
using MimeKit;
using MailKit.Net.Smtp;

namespace smartmoney.Services
{
    public class BrevoService : IEmailService
    {
        private readonly BrevoSettings _emailSettings;

        public BrevoService(IOptions<BrevoSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public async Task SendEmailAsync(string emailDestinatario, string assunto, string mensagemTexto, string mensagemHtml)
        {
            var mensagem = new MimeMessage();
            mensagem.From.Add(new MailboxAddress(_emailSettings.NomeRemetente, _emailSettings.EmailRemetente));
            mensagem.To.Add(MailboxAddress.Parse(emailDestinatario));
            mensagem.Subject = assunto;
            var builder = new BodyBuilder { TextBody = mensagemTexto, HtmlBody = mensagemHtml };
            mensagem.Body = builder.ToMessageBody();
            try
            {
                var smtpClient = new SmtpClient();
                smtpClient.ServerCertificateValidationCallback = (s, c, h, e) => true;
                await smtpClient.ConnectAsync(_emailSettings.EnderecoServidor, _emailSettings.PortaServidor).ConfigureAwait(false);
                await smtpClient.AuthenticateAsync(_emailSettings.EmailRemetente, _emailSettings.Senha).ConfigureAwait(false);
                await smtpClient.SendAsync(mensagem).ConfigureAwait(false);
                await smtpClient.DisconnectAsync(true).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
    }
}

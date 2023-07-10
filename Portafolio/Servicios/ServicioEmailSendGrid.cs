using Portafolio.Models;
using System.Net;
using System.Net.Mail;

namespace Portafolio.Servicios
{
    public interface IServicioEmail
    {
        Task Enviar(ContactoViewModel contacto);
    }

    public class ServicioEmailSmtp : IServicioEmail
    {
        private readonly IConfiguration configuration;

        public ServicioEmailSmtp(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task Enviar(ContactoViewModel contacto)
        {
            var email = configuration.GetValue<string>("SMTP_FROM");
            var nombre = configuration.GetValue<string>("SMTP_NOMBRE");
            var password = configuration.GetValue<string>("SMTP_PASSWORD");
            var host = "smtp.gmail.com"; // Host SMTP de Gmail
            var port = 587; // Puerto para SMTP de Gmail
            var cc = configuration.GetValue<string>("SMTP_CC"); // Dirección de correo electrónico para el campo CC

            if (string.IsNullOrEmpty(email))
                throw new ArgumentNullException(nameof(email), "La dirección de correo electrónico 'from' no puede ser nula o vacía.");

            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException(nameof(password), "La contraseña de correo electrónico no puede ser nula o vacía.");

            var from = new MailAddress(email, nombre);
            var subject = $"El cliente {contacto.Email} quiere contactarte";
            var to = new MailAddress(email, nombre);
            var ccAddress = new MailAddress(cc); // Crear el objeto MailAddress para el campo CC
            var mensajeTextoPlano = contacto.Mensaje;
            var contenidoHtml = @$"De: {contacto.Nombre} - 
Email: {contacto.Email}
Mensaje: {contacto.Mensaje}";

            using (var client = new SmtpClient(host, port))
            {
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(email, password);

                using (var message = new MailMessage(from, to))
                {
                    message.Subject = subject;
                    message.Body = contenidoHtml;
                    message.IsBodyHtml = true;

                    message.CC.Add(ccAddress); // Agregar la dirección de correo electrónico al campo CC

                    await client.SendMailAsync(message);
                }
            }
        }
    }
}

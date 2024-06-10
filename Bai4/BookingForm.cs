using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Windows.Forms;

namespace Lab5
{
    public partial class BookingForm : Form
    {
        private string movieLink;
        private string movieTitle;
        private Image posterImage;
        private PictureBox pictureBox;

        public BookingForm(string link, string title, Image poster)
        {
            InitializeComponent();
            movieLink = link;
            movieTitle = title;
            posterImage = poster;
            lblMovieTitle.Text = title;
            pictureBox.Image = posterImage;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            string email = txtEmail.Text;
            string seatNumber = txtSeatNumber.Text;

            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(seatNumber))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            SendConfirmationEmail(customerName, email, movieTitle, seatNumber);
            MessageBox.Show("Booking confirmed. A confirmation email has been sent.");
            this.Close();
        }

        private void SendConfirmationEmail(string customerName, string email, string movieTitle, string seatNumber)
        {
            string subject = "Booking Confirmation";
            string body = $@"
                <html>
                <body>
                <h1>Thank you for your booking!</h1>
                <p>Dear {customerName},</p>
                <p>We are pleased to confirm your booking for the movie <strong>{movieTitle}</strong>.</p>
                <p>Your seat number is <strong>{seatNumber}</strong>.</p>
                <p>Enjoy your movie!</p>
                <p>Sincerely,</p>
                <p>Beta Cinemas</p>
                <img src='cid:PosterImage' />
                </body>
                </html>";

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("dohuynhan2408@gmail.com");
            mailMessage.To.Add(email);
            mailMessage.Subject = subject;
            mailMessage.Body = body;
            mailMessage.IsBodyHtml = true;

            if (posterImage != null)
            {
                string tempFilePath = System.IO.Path.GetTempFileName();
                posterImage.Save(tempFilePath);

                Attachment inline = new Attachment(tempFilePath);
                inline.ContentDisposition.Inline = true;
                inline.ContentDisposition.DispositionType = DispositionTypeNames.Inline;
                inline.ContentId = "PosterImage";
                inline.ContentType.MediaType = "image/jpeg";
                inline.ContentType.Name = "PosterImage";
                mailMessage.Attachments.Add(inline);
            }

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential("dohuynhan2408@gmail.com", "jxom hqgo irtq dzzi");
            smtpClient.EnableSsl = true;

            try
            {
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email: " + ex.Message);
            }
        }
    }
}

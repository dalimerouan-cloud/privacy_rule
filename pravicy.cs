using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PrivacyApp.Controllers
{
    // [AllowAnonymous] ensures this page is public even if you add
    // global auth middleware/filters to the rest of the app later.
    [AllowAnonymous]
    [Route("privacy")]
    public class PrivacyController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Content(PrivacyHtml, "text/html");
        }

        private const string PrivacyHtml = @"
<!DOCTYPE html>
<html lang=""en"">
<head>
<meta charset=""UTF-8"">
<meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
<title>Privacy Policy - SebsPro</title>
<style>
  body { font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Arial, sans-serif;
    max-width: 720px; margin: 0 auto; padding: 40px 20px; line-height: 1.6; color: #222; }
  h1 { font-size: 28px; margin-bottom: 4px; }
  h2 { font-size: 20px; margin-top: 32px; }
  p, li { font-size: 15px; color: #333; }
  .updated { color: #666; font-size: 14px; margin-bottom: 32px; }
  ul { padding-left: 20px; }
</style>
</head>
<body>

<h1>Privacy Policy</h1>
<p class=""updated"">Last updated: July 11, 2026</p>

<p>This Privacy Policy explains how <strong>SebsPro</strong> (""we"", ""us"", ""our"") collects, uses,
and protects your information when you use our mobile application (iOS/Android) and related backend
services (together, the ""Service"").</p>

<h2>1. Information We Collect</h2>
<ul>
  <li><strong>Account information:</strong> name, email address, phone number, age</li>
  <li><strong>Store owner information:</strong> store name, store details, business address</li>
  <li><strong>Technical information:</strong> IP address, collected for rate limiting and abuse prevention</li>
</ul>

<h2>2. How We Use Your Information</h2>
<ul>
  <li>To create and manage your account</li>
  <li>To verify store owners and display store information within the app</li>
  <li>To protect the Service from abuse through rate limiting</li>
  <li>To communicate with you about your account or the Service</li>
</ul>

<h2>3. How We Store Your Information</h2>
<p>Your data is stored securely using <strong>Azure</strong>. We take reasonable
technical and organizational measures to protect your information against unauthorized access, loss, or misuse.</p>

<h2>4. Data Retention</h2>
<p>We retain your information for as long as your account is active or as needed to provide the Service.
IP address logs used for rate limiting are retained for <strong>30 days</strong> before being deleted.</p>

<h2>5. Sharing of Information</h2>
<p>We do not sell your personal information. We may share data with trusted service providers (such as our
cloud hosting provider) solely to operate the Service, and only to the extent necessary.</p>

<h2>6. Your Rights</h2>
<ul>
  <li>Access the personal data we hold about you</li>
  <li>Request correction or deletion of your data</li>
  <li>Withdraw consent where processing is based on consent</li>
</ul>
<p>To exercise these rights, contact us at <strong>admin@sebspro.com</strong>.</p>

<h2>7. Account and Data Deletion</h2>
<p>You may request deletion of your account and all associated personal data at any time.
To request deletion, contact us at <strong>admin@sebspro.com</strong> with the email address
associated with your account. We will process your request and delete your data within
<strong>[e.g. 30 days]</strong>, except where retention is required by law.</p>

<h2>8. Children's Privacy</h2>
<p>The Service is not intended for children under 13 (or the minimum age required in your country).
We do not knowingly collect data from children below this age.</p>

<h2>9. Changes to This Policy</h2>
<p>We may update this Privacy Policy from time to time. Changes will be posted on this page with an
updated ""Last updated"" date.</p>

<h2>10. Contact Us</h2>
<p>If you have questions about this Privacy Policy, contact us at:<br>
<strong>admin@sebspro.com</strong></p>

</body>
</html>
";
    }
}
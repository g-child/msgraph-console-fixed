namespace console_csharp_snippets_sample
{
    internal class Constants
    {
        public const string Tenant = "679551a0-723a-4f16-a110-2e1bcace83f1";

        // User consent flow
        // TODO: tekitou
        public const string ClientIdForUserAuthn = "872da76b-dc05-4374-b37c-e1388b1914e8";

        // Admin consent flow
        public const string AuthorityUri = "https://login.microsoftonline.com/" + Tenant;
        public const string RedirectUriForAppAuthn = "https://login.microsoftonline.com";
        public const string ClientIdForAppAuthn = "872da76b-dc05-4374-b37c-e1388b1914e8";
        public const string ClientSecret = "vy.KXt-/y*COerRCB6RcBclYqEc4Rg08";
        // Consent URI: 
        // https://login.microsoftonline.com/{tenant name}/adminconsent?client_id={application id}&state=12345&redirect_uri=https://login.microsoftonline.com
    }
}

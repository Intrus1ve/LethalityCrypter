namespace LethalityCrypter.Entities
{
    public class Crypter
    {
        public string token { get; set; }
        public string fileUrl { get; set; }
        public string injectionPath { get; set; }
        public bool Private { get; set; }
        public bool self { get; set; }
        public bool startup { get; set; }
        public bool obfuscator { get; set; }
        public bool killWindowsDefender { get; set; }
        public bool antiVM { get; set; }
        public int delay { get; set; }
        public bool messageBox { get; set; }
        public string messageBoxTitle { get; set; }
        public string messageBoxBody { get; set; }
        public bool assemblyChanger { get; set; }
        public string assemblyTitle { get; set; }
        public string assemblyDescription { get; set; }
        public string assemblyCompany { get; set; }
        public string assemblyProduct { get; set; }
        public string assemblyCopyright { get; set; }
    }
}

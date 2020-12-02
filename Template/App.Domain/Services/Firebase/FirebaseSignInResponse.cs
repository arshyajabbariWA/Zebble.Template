﻿namespace Domain
{
    class FirebaseSignInResponse : FirebaseResponseBase
    {
        public string IdToken { get; set; }
        public string Email { get; set; }
        public string RefreshToken { get; set; }
        public string ExpiresIn { get; set; }
        public string LocalId { get; set; }
        public bool Registered { get; set; }
    }
}

﻿using System;

namespace KursavayaServer
{
    [Serializable]
    public class User
    {
        public string Login { get; set; }
        public string Mail{ get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Message { get; set; }
        public int Count { get; set; }
        public string CreatedAt { get; set; }
        public string ModifiedAt { get; set; }
    }
}

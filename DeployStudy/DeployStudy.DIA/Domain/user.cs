﻿using System;

namespace DeployStudy.DIA.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public bool Active { get; set; }
    }
}

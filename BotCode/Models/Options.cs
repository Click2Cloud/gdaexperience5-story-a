﻿using System;

namespace SimpleEchoBot.Model
{
    [Serializable]
    public class Options
    {
        public int Id;
        public string Title;

        public Options(int Id, string Title)
        {
            this.Id = Id;
            this.Title = Title;
        }               
    }
}
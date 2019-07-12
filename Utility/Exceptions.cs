﻿using System;

namespace KingdomEngine.Utility
{
    public class NotEnoughGoldException : Exception
    {
        public NotEnoughGoldException()
        {
        }

        public NotEnoughGoldException(string message) : base(message)
        {
        }

        public NotEnoughGoldException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}

﻿namespace Luski.net.Interfaces
{
    public interface IMessage
    {
        ulong Id { get; }
        string Context { get; }
        IChannel GetChannel();
        IUser GetAuthor();
        string ToString();
    }
}

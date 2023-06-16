﻿namespace VotingApp.Domain.Abstractions;

public class ForbiddenException : Exception
{
    public ForbiddenException(string message) : base(message)
    {

    }

    public ForbiddenException() : base() { }
}
﻿using System.Threading.Tasks;

namespace SlackNet.Interaction
{
    public interface IMessageActionHandler
    {
        Task<MessageActionResponse> Handle(MessageAction request);
    }
}
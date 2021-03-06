﻿namespace P01.Logger.Appenders.Contracts
{
    public interface IAppender
    {

        void Append(string dateTime, ReportLevel reportLevel, string message);
       
        ReportLevel ReportLevel { get; set; }

        int MessagesCount { get;  }
    }
}

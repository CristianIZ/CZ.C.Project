using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Dto.Enums
{
    public enum StatusCodeEnum
    {
        InConfirmationProcess = 1,
        Accepted = 2,
        Rejected = 3,
        InCookingProcess = 4,
        WaitingForDeliver = 5,
        Waiting = 6,
        SucessfullyFinished = 7,
        Canceled = 8,
        SucessfullyDelivered = 9,
        FailedDelivered = 10
    }
}

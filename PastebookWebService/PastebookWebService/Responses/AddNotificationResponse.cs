﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PastebookWebService.Responses
{
    [DataContract]
    public class AddNotificationResponse
    {
        [DataMember]
        public int Result { get; set; }
    }
}
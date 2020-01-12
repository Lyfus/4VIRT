using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interface_VCENTER.Models
{
    public class vmStatus
    {
        public string name { get; set; }
        public string ip { get; set; }
        public bool status { get; set; }
        public DateTime lastUpdate { get; set; }
        public bool possibleAction { get; set; }

        public vmStatus (string _name, string _ip, bool _status, DateTime _lastUpdate, bool possibleAction)
        {
            possibleAction = true;
            this.name = _name;
            this.ip = _ip;
            this.status = _status;
            this.lastUpdate = _lastUpdate;

        }
    }
}
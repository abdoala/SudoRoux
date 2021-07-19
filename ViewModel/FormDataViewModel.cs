using System;

namespace ViewModel
{
    public class FormDataViewModel
    {
        public string firstName { get; set; }
        public string last_name { get; set; }
        public string emailAddress { get; set; }

        public bool subscribed { get; set; }
        public DateTime dob { get; set; }

    }
}

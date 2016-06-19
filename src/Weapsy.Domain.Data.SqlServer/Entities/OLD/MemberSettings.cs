#region Copyright

//  Weapsy - http://www.weapsy.org
//  Copyright (c) 2011-2013 Luca Briguglia
//  Licensed under the Weapsy Public License Version 1.0 (WPL-1.0)
//  A copy of this license may be found at http://www.weapsy.org/license

#endregion

namespace Weapsy.Entities
{
    public class MemberSettings : ISettings
    {
        public RegistrationType RegistrationType { get; set; }
        public LoginNameType LoginName { get; set; }
        public bool ChangeLoginName { get; set; }
    }
}
using FieldValidatorAPI2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANDBOX_ClubMembershipApplication.FieldValidators
{
    public class UserRegistrationValidator
    {
        const int FirstName_Min_Llength = 2;
        const int FirstName_Max_Llength = 100;
        const int LastName_Min_Llength = 2;
        const int LastName_Max_Llength = 100;

        delegate bool EmailExistsDel(string emailAddress);

        FieldValidatorDel _fieldValidatorDel = null;

        RequiredValidDel _requiredValidDel = null;
        StringLengthValidDel _stringLenthValidDel = null;
        DateValidDel _dateValidDel = null;
        PatternMatchValidDel _patternMatchValidDel = null;
        CompareFieldsValidDel _compareFieldsValidDel = null;

        EmailExistsDel ExistsDel = null;

        string[] _fieldArray = null;

        public string[] FieldArray
        {
            get 
            {
                if (_fieldArray == null)
                    _fieldArray = new string[Enum.GetValues(typeof(FieldConstants.UserRegistrationField)).Length];
                return _fieldArray; 
            }
        }
        public FieldValidatorDel ValidatorDel => _fieldValidatorDel;
    }
}

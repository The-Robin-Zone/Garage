using System;
namespace B22Ex03Shaked203943253Fanny337957633
{
    enum e_StatusVehicule
    {
        InRepair,
        Repaired,
        PayedFor
    }

    public class CarStatus
    {
        private string m_OwnerName;
        private string m_OwnerPhoneNumber;
        private e_StatusVehicule m_StatusVehicule;

        public CarStatus(string i_OwnerName, string i_OwnerPhoneNumber)
        {
            try
            {
                if (isOnlyLetterOrSpace(i_OwnerName) || isOnlyNumber(i_OwnerPhoneNumber))
                {
                    this.m_OwnerName = i_OwnerName;
                    this.m_OwnerPhoneNumber = i_OwnerPhoneNumber;
                }
                else
                {
                    throw new ArgumentException(string.Format("The name or the number entered is not a legal one"));
                }

                this.m_StatusVehicule = e_StatusVehicule.InRepair;
            }
            catch (Exception exception)
            { 
                Console.WriteLine(exception);
            }
        }

        public string OwnerName
        {
            get
            {
                return this.m_OwnerName;
            }
        }

        public string OwnerPhoneNumber
        {
            get
            {
                return this.m_OwnerPhoneNumber;
            }
        }

        // Change the status of the vehicule
        private e_StatusVehicule updateStatusVehicule(string i_Status)
        {
            e_StatusVehicule statusVehicule = e_StatusVehicule.InRepair;
            try
            {
                if (i_Status.CompareTo("In Repair") == 0)
                {
                    statusVehicule = e_StatusVehicule.InRepair;
                }
                else if (i_Status.CompareTo("Repaired") == 0)
                {
                    statusVehicule = e_StatusVehicule.Repaired;
                }
                else if (i_Status.CompareTo("Payed for") == 0)
                {
                    statusVehicule = e_StatusVehicule.PayedFor;
                }
                else
                {
                    throw new ArgumentException(string.Format("The status entered is not a legal one"));
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            return statusVehicule;
        }
        
        // Return the string contain into the enum
        public string StatusVehiculeToString()
        {
            string o_StatusVehiculeToString = string.Empty;
            if (this.m_StatusVehicule == e_StatusVehicule.InRepair)
            {
                o_StatusVehiculeToString = "In Repair";
            }
            else if (this.m_StatusVehicule == e_StatusVehicule.Repaired)
            {
                o_StatusVehiculeToString = "Repaired";
            }
            else if (this.m_StatusVehicule == e_StatusVehicule.PayedFor)
            {
                o_StatusVehiculeToString = "Payed for";
            }
            return o_StatusVehiculeToString;
        }

        // Check string contains only letters and space
        private bool isOnlyLetterOrSpace(string i_NameTocheck)
        {
            bool o_isOnlyLetterOrSpace = true;
            for (int i = 0; i < i_NameTocheck.Length; i++)
            {
                if (!((i_NameTocheck[i] >= 'a' && i_NameTocheck[i] <= 'z') || (i_NameTocheck[i] >= 'A' && i_NameTocheck[i] <= 'Z') || i_NameTocheck[i] == ' '))
                {
                    o_isOnlyLetterOrSpace = false;
                    break;
                }
            }
            return o_isOnlyLetterOrSpace;
        }

        // Check string contains only number
        private bool isOnlyNumber(string i_NumberTocheck)
        {
            bool o_isOnlyNumber = true;
            for (int i = 0; i < i_NumberTocheck.Length; i++)
            {
                if (!(i_NumberTocheck[i] >= '0' && i_NumberTocheck[i] <= '9'))
                {
                    o_isOnlyNumber = false;
                    break;
                }
            }
            return o_isOnlyNumber;
        }
    }
}

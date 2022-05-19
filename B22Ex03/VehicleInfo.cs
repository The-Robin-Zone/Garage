using System;
namespace B22Ex03Shaked203943253Fanny337957633
{
    public enum e_StatusVehicle
    {
        InRepair,
        Repaired,
        PayedFor
    }

    public class VehicleInfo
    {
        private string m_OwnerName;
        private string m_OwnerPhoneNumber;
        private e_StatusVehicle m_StatusVehicule;

        public VehicleInfo(string i_OwnerName, string i_OwnerPhoneNumber)
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

                this.m_StatusVehicule = e_StatusVehicle.InRepair;
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

        public e_StatusVehicle StatusVehicule
        {
            get
            {
                return this.m_StatusVehicule;
            }
            set
            {
                this.m_StatusVehicule = value;
            }
        }

        // Change the status of the vehicule
        public e_StatusVehicle UpdateStatusVehicule(int i_Status)
        {
            e_StatusVehicle statusVehicule = e_StatusVehicle.InRepair;
            try
            {
                if (i_Status == 0)
                {
                    statusVehicule = e_StatusVehicle.InRepair;
                }
                else if (i_Status == 1)
                {
                    statusVehicule = e_StatusVehicle.Repaired;
                }
                else if (i_Status == 2)
                {
                    statusVehicule = e_StatusVehicle.PayedFor;
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
            if (this.m_StatusVehicule == e_StatusVehicle.InRepair)
            {
                o_StatusVehiculeToString = "In Repair";
            }
            else if (this.m_StatusVehicule == e_StatusVehicle.Repaired)
            {
                o_StatusVehiculeToString = "Repaired";
            }
            else if (this.m_StatusVehicule == e_StatusVehicle.PayedFor)
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

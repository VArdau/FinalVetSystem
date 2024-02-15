namespace FinalVetSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            string oChoice;
            string pChoice;
            List<Pet> pets = new List<Pet>();
            List<Owner> owners = new List<Owner>();


            Console.WriteLine("Select your account(1) or create account(2)");
            choice = Console.ReadLine().ToLower();
            if (choice.Contains("1") || choice.Contains("select account") || choice.Contains("select your account"))
            {
                Console.WriteLine("\n" + "Select your details(1), or pet account(2)");
                oChoice = Console.ReadLine().ToLower();
                if (oChoice.Contains("1") || oChoice.Contains("your details"))
                {
                    List<Owner> ReadOwner(string fileName)
                    {
                        StreamReader sr = null;
                        string id = ""; 
                        string firstName = "";
                        string lastName = "";
                        string phone = "";
                        string email = "";
                        try
                        {
                            sr = new StreamReader(fileName);
                            string line = sr.ReadLine();
                            while (line != null)
                            {
                                Owner owner = new Owner(id, firstName, lastName, phone, email);
                                owner.OwnerID = line;
                                line = sr.ReadLine();
                                owner.OwnerFirstName = line;
                                line = sr.ReadLine();
                                owner.OwnerLastName = line;
                                line = sr.ReadLine();
                                owner.OwnerPhone = line;
                                line = sr.ReadLine();
                                owner.OwnerEmail = line;
                                line = sr.ReadLine();

                                owners.Add(owner);
                                line = sr.ReadLine();

                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Execption: " + e.Message);
                            return null;
                        }
                        finally
                        {
                            sr.Close();
                        }
                        return owners;
                    }

                    List<Owner> ownerString = ReadOwner("ownerAccount.txt");
                    foreach (Owner owner in ownerString)
                    {
                        Console.WriteLine(owner.OwnerID + " | " + owner.OwnerFirstName + " " + owner.OwnerLastName +
                            " | " + owner.OwnerPhone + " | " + owner.OwnerEmail + "\n");
                    }
                }
            

                else if (oChoice.Contains("2") || oChoice.Contains("pet account"))
                {
                    Console.WriteLine("\n" + "Select to view pet details(1), or create pet account(2)");
                    pChoice = Console.ReadLine().ToLower();
                    if (pChoice.Contains("1") || pChoice.Contains("pet details"))
                    {
                        List<Pet> ReadPet(string fileName)
                        {
                            StreamReader sr = null;
                            string oid = "";
                            string id = "";
                            string name = "";
                            string type = "";
                            string breed = "";
                            string dob = "";
                            string kg = "";
                            string address = "";

                            try
                            {
                                sr = new StreamReader(fileName);
                                string line = sr.ReadLine();
                                while (line != null)
                                {
                                    Pet pet = new Pet(oid, id, name, type, breed, dob, kg, address);
                                    pet.OwnerID = line;
                                    line = sr.ReadLine();
                                    pet.PetID = line;
                                    line = sr.ReadLine();
                                    pet.PetName = line;
                                    line = sr.ReadLine();
                                    pet.PetType = line;
                                    line = sr.ReadLine();
                                    pet.PetBreed = line;
                                    line = sr.ReadLine();
                                    pet.PetDOB = line;
                                    line = sr.ReadLine();
                                    pet.Petkg = line;
                                    line = sr.ReadLine();
                                    pet.PetAddress = line;
                                    line = sr.ReadLine();

                                    pets.Add(pet);
                                    line = sr.ReadLine();

                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Execption: " + e.Message);
                                return null;
                            }
                            finally
                            {
                                sr.Close();
                            }
                            return pets;
                        }
                        List<Pet> petString = ReadPet("petAccount.txt");
                        foreach (Pet pet in petString)
                        {
                            Console.WriteLine("\n" + pet.PetID + " | " + pet.PetName + " | " + pet.PetType + "" +
                                " | " + pet.PetBreed + " | " + pet.PetDOB + " | " + pet.Petkg + " | " + pet.PetAddress); 
                        }
                    }

                    else if (pChoice.Contains("2") || pChoice.Contains("create pet"))
                    {
                        void WritePet(string fileName, List<Pet> pets)
                        {
                            int petIDgive = 1;
                            Console.WriteLine("Enter the following: Your account ID, pets name, type, breed, date of birth, kilograms, address." + "\n" + "Example: 0,Fluffy,dog,chihuahua,09/10/2020,2kg,S100 Chihuahua Strees 15" + "\n" + "NOTE: If unsure about any details write unsure in the information (e.g dog,unsure)," + "\n " + "if you want to find your ID view your account details.");
                            string input = Console.ReadLine();
                            string[] details = input.Split(',');

                            petIDgive++; 
                            pets.Add(new Pet(details[0], petIDgive.ToString(), details[1], 
                                details[2], details[3], details[4], details[5], "\n")); 


                            StreamWriter sw = null;
                            try
                            {
                                sw = new StreamWriter(fileName, true); //if i had it as false it wouldnt make multiple?? 
                                foreach (Pet detail in pets)
                                {
                                    sw.WriteLine(detail.OwnerID + "\n" + detail.PetID + "\n" + detail.PetName + "\n" + detail.PetType + "\n" + detail.PetBreed + "\n" + detail.PetDOB + "\n" + detail.Petkg + "\n" + detail.PetAddress);
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Execption: " + e.Message);
                                return;
                            }
                            finally
                            {
                                sw.Close();
                            }
                        }
                        WritePet("petAccount.txt", pets);
                    }

                    else
                    {
                        Console.WriteLine("Please select one of the avaliable options.");
                    }
                }

                else
                {
                    Console.WriteLine("Please select one of the avaliable options.");
                }
            }

            else if (choice.Contains("2") || choice.Contains("create account"))
            {
                int ownerIDgives = 1;
                string ownerIDgive = ownerIDgives.ToString();
                Console.WriteLine("Enter the following: First name, Last name, phone number and email." + "\n" + "Example: Adam,Smith,00000000000,adamsmith@email.com");
                string input = Console.ReadLine();
                string[] details = input.Split(','); // https://stackoverflow.com/a/3676286

                owners.Add(new Owner(/*owners.Count > 0 ? owners.Max(x => x.OwnerID) + 1 : 1 , */ownerIDgive, details[0], details[1], details[2], details[3])); // https://stackoverflow.com/a/23591323

                void WriteOwner(string fileName, List<Owner> owners)
                {
                    StreamWriter sw = null;
                    try
                    {
                        sw = new StreamWriter(fileName, true);
                        foreach (Owner detail in owners)
                        {
                            sw.WriteLine(detail.OwnerID.ToString() + "\n" + detail.OwnerFirstName + "\n" + detail.OwnerLastName + "\n" + detail.OwnerPhone.ToString() + "\n" + detail.OwnerEmail + "\n");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Execption: " + e.Message);
                        return;
                    }
                    finally
                    {
                        sw.Close();
                    }
                }
                WriteOwner("ownerAccount.txt", owners);
            }

            else
            {
                Console.WriteLine("Please select one of the avaliable options.");
            }


        }
    }
}
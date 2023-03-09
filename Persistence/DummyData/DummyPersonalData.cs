using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.DummyData
{
    public class DummyPersonalData
    {
        public static List<PersonalData> Get()
        {
            return new List<PersonalData>
            {
                new PersonalData { Id = 1, FirstName = "Adam", LastName = "Nowak", DateOfBirth = new DateTime(1980, 1, 1), PhoneNumber = "111-111-111", PESEL = "80010100000", Country = "Poland", City = "Warsaw", Street = "Floriańska", HouseNumber = 71, PostalCode = "00-001" },
                new PersonalData { Id = 2, FirstName = "Anna", LastName = "Kowalska", DateOfBirth = new DateTime(1985, 2, 2), PhoneNumber = "222-222-222", PESEL = "85020200000", Country = "Poland", City = "Krakow", Street = "Długa", HouseNumber = 24, PostalCode = "00-002" },
                new PersonalData { Id = 3, FirstName = "Piotr", LastName = "Nowicki", DateOfBirth = new DateTime(1990, 3, 3), PhoneNumber = "333-333-333", PESEL = "90030300000", Country = "Poland", City = "Gdansk", Street = "Grodzka", HouseNumber = 35, PostalCode = "00-003" },
                new PersonalData { Id = 4, FirstName = "Katarzyna", LastName = "Wojciechowska", DateOfBirth = new DateTime(1985, 4, 4), PhoneNumber = "444-444-444", PESEL = "85040400000", Country = "Poland", City = "Wroclaw", Street = "Piotrkowska", HouseNumber = 54, PostalCode = "00-004" },
                new PersonalData { Id = 5, FirstName = "Marek", LastName = "Kaminski", DateOfBirth = new DateTime(1980, 5, 5), PhoneNumber = "555-555-555", PESEL = "80050500000", Country = "Poland", City = "Poznan", Street = "Wita Stwosza", HouseNumber = 53, PostalCode = "00-005" },
                new PersonalData { Id = 6, FirstName = "Karolina", LastName = "Jankowska", DateOfBirth = new DateTime(1990, 6, 6), PhoneNumber = "666-666-666", PESEL = "90060600000", Country = "Poland", City = "Katowice", Street = "Kościuszki", HouseNumber = 66, PostalCode = "00-006" },
                new PersonalData { Id = 7, FirstName = "Tomasz", LastName = "Kowalczyk", DateOfBirth = new DateTime(1985, 7, 7), PhoneNumber = "777-777-777", PESEL = "85070700000", Country = "Poland", City = "Lodz", Street = "Świętojańska", HouseNumber = 77, PostalCode = "00-007" },
                new PersonalData { Id = 8, FirstName = "Ewa", LastName = "Michalska", DateOfBirth = new DateTime(1980, 8, 8), PhoneNumber = "654-567-657", PESEL = "80080800001", Country = "Poland", City = "Szczecin", Street = "Mariacka", HouseNumber = 49, PostalCode = "00-008" },
                new PersonalData { Id = 9, FirstName = "Józef", LastName = "Krupa", DateOfBirth = new DateTime(1988, 2, 12), PhoneNumber = "768-354-987", PESEL = "80080800002", Country = "Poland", City = "Krosno", Street = "Karmelicka", HouseNumber = 94, PostalCode = "00-009" },
                new PersonalData { Id = 10, FirstName = "Jan", LastName = "Kwiatkowski", DateOfBirth = new DateTime(1981, 3, 11), PhoneNumber = "534-768-234", PESEL = "80080800030", Country = "Poland", City = "Sanok", Street = "Nowy Świat", HouseNumber = 48, PostalCode = "00-018" },
                new PersonalData { Id = 11, FirstName = "Mateusz", LastName = "Adamski", DateOfBirth = new DateTime(1998, 4, 10), PhoneNumber = "986-234-425", PESEL = "80080840000", Country = "Poland", City = "Rzeszów", Street = "Świdnicka", HouseNumber = 84, PostalCode = "00-028" },
                new PersonalData { Id = 12, FirstName = "Albert", LastName = "Pietrzak", DateOfBirth = new DateTime(2003, 5, 8), PhoneNumber = "765-987-234", PESEL = "80080800500", Country = "Poland", City = "Gdynia", Street = "Aleje Jerozolimskie", HouseNumber = 64, PostalCode = "00-038" },
                new PersonalData { Id = 13, FirstName = "Aleksander", LastName = "Kowalczyk", DateOfBirth = new DateTime(1985, 6, 8), PhoneNumber = "543-567-234", PESEL = "80060800000", Country = "Poland", City = "Wrocław", Street = "Krupnicza", HouseNumber = 34, PostalCode = "00-048" },
                new PersonalData { Id = 14, FirstName = "Patryk", LastName = "Krajewski", DateOfBirth = new DateTime(1989, 7, 7), PhoneNumber = "345-234-123", PESEL = "80080807000", Country = "Poland", City = "Janów", Street = "Piłsudskiego", HouseNumber = 43, PostalCode = "00-058" },
                new PersonalData { Id = 15, FirstName = "Remigiusz", LastName = "Zawadzki", DateOfBirth = new DateTime(1995, 8, 6), PhoneNumber = "543-643-132", PESEL = "80080800000", Country = "Poland", City = "Zakopane", Street = "Jagiellońska", HouseNumber = 46, PostalCode = "00-068" },
                new PersonalData { Id = 16, FirstName = "Leonardo", LastName = "Borkowski", DateOfBirth = new DateTime(1981, 9, 5), PhoneNumber = "785-423-423", PESEL = "80080900000", Country = "Poland", City = "Jarosław", Street = "Złota", HouseNumber = 54, PostalCode = "00-078" },
                new PersonalData { Id = 17, FirstName = "Aleksander", LastName = "Przybylski", DateOfBirth = new DateTime(2001, 10, 4), PhoneNumber = "654-421-534", PESEL = "10080800000", Country = "Poland", City = "Radom", Street = "Sienkiewicza", HouseNumber = 44, PostalCode = "00-088" },
                new PersonalData { Id = 18, FirstName = "Oktawian", LastName = "Gajewski", DateOfBirth = new DateTime(1998, 11, 3), PhoneNumber = "554-764-534", PESEL = "80081100000", Country = "Poland", City = "Jasło", Street = "Rynek", HouseNumber = 24, PostalCode = "00-098" },
                new PersonalData { Id = 19, FirstName = "Kamila", LastName = "Jasińska", DateOfBirth = new DateTime(1983, 12, 2), PhoneNumber = "634-235-536", PESEL = "80080812000", Country = "Poland", City = "Przemyśl", Street = "Mariacki", HouseNumber = 41, PostalCode = "00-108" },
                new PersonalData { Id = 20, FirstName = "Stanisława", LastName = "Ostrowska", DateOfBirth = new DateTime(1999, 4, 1), PhoneNumber = "745-755-574", PESEL = "80130800000", Country = "Poland", City = "Opole", Street = "Mickiewicza", HouseNumber = 14, PostalCode = "00-208" }
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RamboErp.Entidades
{
         public class Pessoa
        {
            private int id;
            private String name;
            private char typePerson;
            private string address;
            private string city;
            private string cep;
            private string state;
            private string cnpj_cpf;
            private String dateOfBirth;

            public Pessoa(int id, String name, char typePerson, String address, String city, String cep, String state, String cnpj_cpf, String dateOfBirth)
            {
                this.id = id;
                this.name = name;
                this.typePerson = typePerson;
                this.address = address;
                this.city = city;
                this.cep = cep;
                this.state = state;
                this.cnpj_cpf = cnpj_cpf;
                this.dateOfBirth = dateOfBirth;
            }
            public Pessoa(String name, char typePerson, String address, String city, String cep, String state, String cnpj_cpf, String dateOfBirth)
            {
                this.name = name;
                this.typePerson = typePerson;
                this.address = address;
                this.city = city;
                this.cep = cep;
                this.state = state;
                this.cnpj_cpf = cnpj_cpf;
                this.dateOfBirth = dateOfBirth;
            }

            public Pessoa()
            {
            }

            public int getId()
            {
                return id;
            }

            public void setId(int id)
            {
                this.id = id;
            }

            public String getName()
            {
                return name;
            }

            public void setName(String name)
            {
                this.name = name;
            }

            public char getTypePerson()
            {
                return typePerson;
            }

            public void setTypePerson(char typePerson)
            {
                this.typePerson = typePerson;
            }

            public String getAddress()
            {
                return address;
            }

            public void setAddress(String address)
            {
                this.address = address;
            }

            public String getCity()
            {
                return city;
            }

            public void setCity(String city)
            {
                this.city = city;
            }

            public String getCep()
            {
                return cep;
            }

            public void setCep(String cep)
            {
                this.cep = cep;
            }

            public String getState()
            {
                return state;
            }

            public void setState(String state)
            {
                this.state = state;
            }

            public String getCnpj_cpf()
            {
                return cnpj_cpf;
            }

            public void setCnpj_cpf(String cnpj_cpf)
            {
                this.cnpj_cpf = cnpj_cpf;
            }

            public String getDateOfBirth()
            {
                return dateOfBirth;
            }

            public void setDateOfBirth(String dateOfBirth)
            {
                this.dateOfBirth = dateOfBirth;
            }

        }



    }


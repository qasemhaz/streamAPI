﻿using Stream.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Core.Repository
{
    public interface IStreamLogin
    {
        Streamlogin Auth(Streamlogin loginof);

        List<Streamlogin> GetAll();
        Streamlogin GetById(int id);
        void Create(Streamlogin stream);
        void Update(Streamlogin stream);
        void Delete(int id);
        void googl(string name, string email, string pass);

    }
}

﻿using System;
using story_game_exercise.Controllers.Commands;
using story_game_exercise.Service.Interface;

namespace story_game_exercise.Service
{
    public class BookService : IBookService
    {
        public BookService()
        {

        }

        public VmBook Create(VmBookCreateCommand command)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public VmBook Get(Guid guid)
        {
            throw new NotImplementedException();
        }

        public VmBook[] GetAll()
        {
            throw new NotImplementedException();
        }

        public VmBook Update(VmBookUpdateCommand comand)
        {
            throw new NotImplementedException();
        }
    }
}

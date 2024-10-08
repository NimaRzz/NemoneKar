﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Interfaces.Contexts;
using MainProject.Application.Interfaces.Cues;
using MainProject.Application.Interfaces.FacadPatterns;
using MainProject.Application.Services.Cues.Commands.AddCue;
using MainProject.Application.Services.Cues.Commands.DeleteCue;
using MainProject.Application.Services.Cues.Commands.EditCue;



namespace MainProject.Application.Services.Cues.FacadPattern
{
    public class CueFacad:ICueFacad
    {

        private readonly IDataBaseContext _context;

        public CueFacad(IDataBaseContext context)
        {
            _context = context;
        }

        //private IGetCuesForAdminService _getCuesForAdminService;

        //public IGetCuesForAdminService GetCuesForAdminService
        //{
        //    get
        //    {
        //        return _getCuesForAdminService = _getCuesForAdminService ?? new GetCuesForAdminService(_context);
        //    }
        //}

        private IAddCueService _addCueService;

        public IAddCueService AddCueService
        {
            get
            {
                return _addCueService = _addCueService ?? new AddCueService(_context);
            }
        }


        private IEditCueService _editCueService;

        public IEditCueService EditCueService
        {
            get
            {
                return _editCueService = _editCueService ?? new EditCueService(_context);
            }
        }

        private IDeleteCueService _deleteCueService;

        public IDeleteCueService DeleteCueService
        {
            get
            {
                return _deleteCueService = _deleteCueService ?? new DeleteCueService(_context);
            }
        }

        //private IGetFilterCuesForAdminService _getFilterCuesForAdminService;

        //public IGetFilterCuesForAdminService GetFilterCuesForAdminService
        //{
        //    get
        //    {
        //        return _getFilterCuesForAdminService = _getFilterCuesForAdminService ?? new GetFilterCuesForAdminService(_context);
        //    }
        //}
    }
}

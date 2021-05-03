﻿using eProdaja.Model;
using eProdaja.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    public class VrstaProizvodaController : BaseController<Model.VrsteProizvodum, object>
    {
        public VrstaProizvodaController(IVrstaProizvodaService service) : base(service)
        {
        }
    }
}
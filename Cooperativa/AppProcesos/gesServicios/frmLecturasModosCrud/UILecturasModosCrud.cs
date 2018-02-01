using Business;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.gesServicios.frmLecturasModosCrud
{
    public class UILecturasModosCrud
    {
        private IVistaLecturasModosCrud _vista;
        Utility oUtil;

        public UILecturasModosCrud(IVistaLecturasModosCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }


        public void Inicializar()
        {
            ServiciosBus oServiciosBus = new ServiciosBus();

            _vista.srvCodigo.DataSource = oServiciosBus.ServiciosGetAll();
            _vista.srvCodigo.DisplayMember = "SrvDescripcion";
            _vista.srvCodigo.ValueMember = "SrvCodigo";
            if (_vista.lemCodigo != 0)
            {
                LecturasModos oSLecturas = new LecturasModos();
                LecturasModosBus oSMeBus = new LecturasModosBus();

                oSLecturas = oSMeBus.LecturasModosGetById(_vista.lemCodigo);
                _vista.lemCodigo = oSLecturas.lemCodigo;
                _vista.srvCodigo.SelectedValue = oSLecturas.srvCodigo;
                _vista.lemDescripcion = oSLecturas.lemDescripcion;
                _vista.estCodigo = oSLecturas.estCodigo;
                _vista.lemFechaCarga = oSLecturas.lemFechaCarga;
                _vista.usrCodigo = oSLecturas.usrCodigo;


                LecturasConceptosBus oSlcBus = new LecturasConceptosBus();

                if (oSLecturas.conceptos.Count > 0)
                {
                    foreach(LecturasConceptos oLcAux in oSLecturas.conceptos)
                    {
                       _vista.conceptos.DataSource =  oSlcBus.LecturasConceptosGetAllDT().Rows;
                    }
                }
                else
                {

                }
            }
        }

        public void Guardar()
        {
            long rtdo;
            LecturasModos oSLecturas = new LecturasModos();
            LecturasModosBus oSMeBus = new LecturasModosBus();

            oSLecturas.usrCodigo = _vista.usrCodigo;
            oSLecturas.lemDescripcion = _vista.lemDescripcion;
            oSLecturas.lemFechaCarga = _vista.lemFechaCarga;
            oSLecturas.srvCodigo = _vista.srvCodigo.SelectedValue.ToString();
            oSLecturas.lemCodigo = _vista.lemCodigo;
            oSLecturas.estCodigo = _vista.estCodigo;

            if (_vista.lemCodigo == 0)
                rtdo = oSMeBus.LecturasModosAdd(oSLecturas);
            else
                oSMeBus.LecturasModosUpdate(oSLecturas);
        }

        public bool EliminarModoLectura(long idLectura)
        {
            LecturasModosBus oSMeBus = new LecturasModosBus();
            LecturasModos oSMe = oSMeBus.LecturasModosGetById(idLectura);
            oSMe.estCodigo = "B";
            return oSMeBus.LecturasModosUpdate(oSMe);
        }
    }
}

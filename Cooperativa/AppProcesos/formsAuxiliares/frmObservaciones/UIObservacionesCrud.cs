﻿using Business;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.formsAuxiliares.frmObservaciones
{
    public class UIObservacionesCrud
    {
        private IVistaObservacionesCrud _vista;
        Utility oUtil;

        public UIObservacionesCrud(IVistaObservacionesCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }


        public void Inicializar() {

            if (_vista.codigo == 0) {
                _vista.fecha = DateTime.Now.Date;

            }
            else
            {
                Observaciones oObs = new Observaciones();
                ObservacionesBus oObsBus = new ObservacionesBus();
                oObs = oObsBus.ObservacionesGetById(_vista.codigo);
                _vista.codigoRegistro = oObs.ObsCodigoRegistro;
                _vista.detalle = oObs.ObsDetalle;
                _vista.tipoObservaciones = oObs.TobCodigo;
                _vista.fecha = oObs.ObsFechaAlta;
                Adjuntos oAdj = new Adjuntos();
                AdjuntosBus oAdjBus = new AdjuntosBus();
                oAdj = oAdjBus.AdjuntosGetByCodigoRegistro(long.Parse(_vista.codigo.ToString()));
                _vista.adjunto = oAdj;
            }
        }

     

        public void Guardar()
        {
            long rtdo;
            Observaciones oObs = new Observaciones();
            ObservacionesBus oObsBus = new ObservacionesBus();
       
            oObs.ObsCodigo = _vista.codigo;
            oObs.ObsCodigoRegistro = _vista.codigoRegistro;
            oObs.ObsDetalle = _vista.detalle;
            oObs.ObsFechaAlta = _vista.fecha;
            oObs.TobCodigo = _vista.tipoObservaciones;
            if (_vista.codigo == 0)
               
                rtdo = oObsBus.ObservacionesAdd(oObs);
            else
                rtdo = (oObsBus.ObservacionesUpdate(oObs)) ? oObs.ObsCodigo: 0;

            if (_vista.adjunto.AdjNombre != "")
            {
                
                _vista.adjunto.AdjCodigoRegistro = rtdo.ToString();
                AdjuntosBus oAdjuntoBus = new AdjuntosBus();
                if (oAdjuntoBus.AdjuntoExisteByCodigoRegistro(rtdo))
                    oAdjuntoBus.AdjuntoUpdate(_vista.adjunto);
                else
                    oAdjuntoBus.AdjuntosAdd(_vista.adjunto);
            }

        }


        public void AgregarImagen()
        {

            _vista.adjunto = oUtil.Adjunto_Agregar(_vista.adjunto);
            _vista.adjuntoFileName = _vista.adjunto.AdjNombre;

        }


        public void Mostrar()
        {

            oUtil.Adjunto_Mostrar(_vista.codigo);
            
            //ObservacionesBus oObsBus = new ObservacionesBus();
            
            //DataTable dtb = oObsBus.ObservacionesGetAdjuntoById(_vista.codigo);
            //DataRow f = dtb.Rows[0];
            //byte[] bits = ((byte[])(f.ItemArray[0]));

            //string sFile = "tmp.doc";
            //FileStream fs = new FileStream(sFile, FileMode.Create);

            //fs.Write(bits, 0, Convert.ToInt32(bits.Length));
            //fs.Close();
            //System.Diagnostics.Process obj = new System.Diagnostics.Process();
            //obj.StartInfo.FileName = sFile;
            //obj.Start();

        }
    }
}

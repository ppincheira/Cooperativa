using System;

namespace AppProcesos.gesServicios.frmMedidoresCrud
{
    public interface IVistaTiposMedidoresCrud
    {
                                                                // Permite valores nullos? y / n 
        string tmeCodigo { get; set; }                          //N

        string descripcion { get; set; }                        //N
        string descripcionCorta { get; set; }                   //N
        DateTime fechaCarga { get; set; }                       //N
        Controles.datos.cmbLista srvCodigo { get; set; }        //N
        int usrNumero { get; set; }                             //N

        string estCodigo { get; set; }                          //Y

    }
}

using Microsoft.Extensions.Primitives;
using System;

namespace Meu_Controle_Usuarios.Models
{
  public class User
  {
    private int iUserID { get; set; }

    private string sName { get; set; }

    private string sCPF { get; set; }
    
    private DateTime dDate { get; set; }

    private string sTel { get; set;}

    private string sEmail { get; set; }

    private string sApto { get; set; }

    private string sGender { get; set; }

    private int iUserRoleID { get; set; }

  }
}

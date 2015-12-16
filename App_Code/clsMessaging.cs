using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
/// <summary>
/// Summary description for clsMessaging
/// </summary>
public class clsMessaging
{
	public clsMessaging()
	{
   
	}

    private string GetOverride()
    {
        return Environment.NewLine + "window.alert = function (txt, title) {swal('Validation Errors', txt, 'error');};" + Environment.NewLine; 
    }

    public Boolean SuccessMessage(string strMsg)
    {
        string[] successMsg = { "Astounding", "Stellar", "Sensational", "Awesome", "Superb", "Righteous", "Stupendous", "Marvelous" };
        Random rnd = new Random();
        var pge = HttpContext.Current.CurrentHandler as Page;
        string funcCall = "<script language='javascript'>swal('" + successMsg[rnd.Next(0,7)] + "!', '" + strMsg + "', 'success')" + GetOverride() +   "</script>";
        pge.ClientScript.RegisterClientScriptBlock(this.GetType(), "JSScript", funcCall);
        return true;
    }

    public Boolean SuccessMessageRedirect(string strMsg, string strURL)
    {
        string[] successMsg = { "Astounding", "Stellar", "Sensational", "Awesome", "Superb", "Righteous", "Stupendous", "Marvelous" };
        Random rnd = new Random();
        var pge = HttpContext.Current.CurrentHandler as Page;
        string funcCall = "<script language='javascript'>swal({   title: '" + successMsg[rnd.Next(0, 7)] + "!',   text: '" + strMsg + "',   type: 'success',   showCancelButton: false,   closeOnConfirm: false,   showLoaderOnConfirm: true, }, function(){ window.location='"+ strURL + "';    });" + GetOverride() +  "</script>";
        pge.ClientScript.RegisterClientScriptBlock(this.GetType(), "JSScript", funcCall);
        return true;
    }

    public Boolean ErrorMessage(string strMsg)
    {
        string[] successMsg = { "Oh Snap", "Danggit", "Oh No", "Ooops", "Phew", "Darn", "Shucks", "Boo" };
        Random rnd = new Random();
        var pge = HttpContext.Current.CurrentHandler as Page;
        string funcCall = "<script language='javascript'>swal('" + successMsg[rnd.Next(0, 7)] + "!', '" + strMsg + "', 'error')" + GetOverride() +  "</script>";
        pge.ClientScript.RegisterClientScriptBlock(this.GetType(), "JSScript", funcCall);
        return true;
    }

    public Boolean ErrorMessageRedirect(string strMsg, string strURL)
    {
        string[] successMsg = { "Oh Snap", "Danggit", "Oh No", "Ooops", "Phew", "Darn", "Shucks", "Boo" };
        Random rnd = new Random();
        var pge = HttpContext.Current.CurrentHandler as Page;
        string funcCall = "<script language='javascript'>swal({   title: '" + successMsg[rnd.Next(0, 7)] + "!',   text: '" + strMsg + "',   type: 'error',   showCancelButton: false,   closeOnConfirm: false,   showLoaderOnConfirm: true, }, function(){ window.location='" + strURL + "';    });" + GetOverride() +  "</script>";
        pge.ClientScript.RegisterClientScriptBlock(this.GetType(), "JSScript", funcCall);
        return true;
    }

    public Boolean ConfirmMessage(string strTitle, string strMsg, string onSuccessURL)
    {
        var pge = HttpContext.Current.CurrentHandler as Page;
        string funcCall = "<script>swal({ title: '" + strTitle + "',";
          funcCall += "text: '" + strMsg + "',";
          funcCall += "type: 'warning',";
          funcCall += "showCancelButton: true,";
          funcCall += "confirmButtonColor: '#DD6B55',";
          funcCall += "confirmButtonText: 'Yes, delete it!',";
          funcCall += "cancelButtonText: 'No, cancel please!',";
          funcCall += "closeOnConfirm: false,";
          funcCall += "closeOnCancel: false},";

          funcCall +="function(isConfirm){";
          funcCall +="if (isConfirm) {";
          funcCall += " $.post('" + onSuccessURL + "');";
          funcCall += "swal('Deleted!', '" + strMsg + "', 'success');";
       
          funcCall += "} else {";
          funcCall +=	    "swal('Cancelled', 'Your Information is Safe! :)', 'error');";
          funcCall += "}";
          funcCall += "});" + GetOverride() +  "</script>";
  
          pge.ClientScript.RegisterClientScriptBlock(this.GetType(), "JSScript", funcCall);
          return true;
    }


    public Boolean ToastMessage(string strMsg)
    {
        string[] successMsg = { "Astounding", "Stellar", "Sensational", "Awesome", "Superb", "Righteous", "Stupendous", "Marvelous" };
        Random rnd = new Random();
        var pge = HttpContext.Current.CurrentHandler as Page;
        string funcCall = "<script language='javascript'>toastr.info('Are you the six fingered man?');" + GetOverride() +  "</script>";
        pge.ClientScript.RegisterClientScriptBlock(this.GetType(), "JSScript", funcCall);
        return true;
    }


      public Boolean HTML5notification(string strMsg)
    {
        string[] successMsg = { "Astounding", "Stellar", "Sensational", "Awesome", "Superb", "Righteous", "Stupendous", "Marvelous" };
        Random rnd = new Random();
        var pge = HttpContext.Current.CurrentHandler as Page;
        string funcCall = "<script language='javascript'>" + GetOverride() +  "</script>";
        pge.ClientScript.RegisterClientScriptBlock(this.GetType(), "JSScript", funcCall);
        return true;
    }
    
}
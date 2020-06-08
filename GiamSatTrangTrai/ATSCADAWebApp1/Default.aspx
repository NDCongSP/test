<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ATSCADAWebApp.Default" %>
<%@ Register assembly="iTools.Web" namespace="ATSCADA.iWebTools" tagprefix="cc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ATSCADA WebApp Template</title>
    <style type="text/css">
        
        html, body{
            margin:0;
            padding:0;
            height: 100%;
            width: 100%;
        }
        .main-colunm {
            width: 100%;
        }
        .colunm1 {
            width: 90%;
        }
        .colunm2 {
            width: 5%;
        }
        .textarea {            
            width: 100%;
            text-align:center; 
            font-family:Arial;
            font-size:xx-large;    
            
        }          
         .rightjustified {
            text-align: right;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>            
            <table class="main-colunm">
                <tr>
                    <td>
                        <!-- THESE LINES ARE FROM ATPROCORP, SHOULD NOT BE DELETED -->                        
                        <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                        </ajaxToolkit:ToolkitScriptManager>
                        <!--------------------END----------------------->
                    </td>
                </tr>
                <tr>
                    <td>
                        <table class="main-colunm">
                            <tr>                                
                                <td class ="colunm2"></td>
                                <td class ="colunm1"></td>
                                <td class ="colunm2"></td>
                            </tr>                        
                            <tr>                                
                                <td class ="colunm2"></td>
                                <td class ="colunm1"></td>
                                <td class ="colunm2"></td>
                            </tr>                  
                            <tr>                                
                                <td class ="colunm2"></td>
                                <td class ="colunm1"></td>
                                <td class ="colunm2"></td>
                            </tr>                  
                        </table>
                    </td>
                </tr>
        </table>        
    </div> 
    </form>
</body>
</html>

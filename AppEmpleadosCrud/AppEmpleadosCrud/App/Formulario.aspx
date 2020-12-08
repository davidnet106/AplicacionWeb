<%@ Page Title="" Language="C#" MasterPageFile="~/App/Layuot.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="AppEmpleadosCrud.App.Formulario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <h1 class="textoH1"> Formulario Datos  </h1>
    <main class="estiloMain">
    
            <div class="contendeorApp"> 
    
                <div class="menuApp"> 
                    <div class="contenedorBtnApp">              
                        <asp:Label ID="LabelRta" runat="server" Font-Bold="True"></asp:Label>              
            </div>
            </div>
           
            <div class="contenedorDatos">
                <div class="contenedorTodoForm">
                    
                    <div class="contenedorDatoForm">  
                        <div class="contenedorLabel"><asp:Label ID="Label1" runat="server" Text="Codigo"></asp:Label></div>
                        <div class="contenedorText"><asp:TextBox ID="InCodigo" runat="server" OnTextChanged="InCodigo_TextChanged"></asp:TextBox> </div>
                        <div class="contenedorError"><asp:Label ID="ErrorCodigo" runat="server" Font-Size="Smaller" ForeColor="Red" Text=""></asp:Label></div>                                              
                        </div>

                     <div class="contenedorDatoForm">  
                        <div class="contenedorLabel"><asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label></div>
                        <div class="contenedorText"><asp:TextBox ID="InNombre" runat="server"></asp:TextBox> </div>
                        <div class="contenedorError"><asp:Label ID="ErrorNombre" runat="server" Font-Size="Smaller" ForeColor="Red" Text=""></asp:Label></div>                                              
                        </div>

                    <div class="contenedorDatoForm">  
                        <div class="contenedorLabel"><asp:Label ID="Label3" runat="server" Text="Apellido"></asp:Label></div>
                        <div class="contenedorText"><asp:TextBox ID="InApellido" runat="server"></asp:TextBox> </div>
                        <div class="contenedorError"><asp:Label ID="ErrorApellido" runat="server" Font-Size="Smaller" ForeColor="Red" Text=""></asp:Label></div>                                              
                        </div>

                    <div class="contenedorDatoForm">  
                        <div class="contenedorLabel"><asp:Label ID="Label4" runat="server" Text="Cargo"></asp:Label></div>
                        <div class="contenedorText"><asp:TextBox ID="InCargo" runat="server"></asp:TextBox> </div>
                        <div class="contenedorError"><asp:Label ID="ErrorCargo" runat="server" Font-Size="Smaller" ForeColor="Red" Text=""></asp:Label></div>                                              
                        </div>

                     <div class="contenedorDatoForm">  
                        <div class="contenedorLabel"><asp:Label ID="Label5" runat="server" Text="Salario"></asp:Label></div>
                        <div class="contenedorText"><asp:TextBox ID="InSalario" runat="server"></asp:TextBox> </div>
                        <div class="contenedorError"><asp:Label ID="ErrorSalario" runat="server" Font-Size="Smaller" ForeColor="Red" Text=""></asp:Label></div>                                              
                        </div>

                    <div class="contenedorDatoForm">  
                        <div class="contenedorLabel"><asp:Label ID="Label6" runat="server" Text="Area"></asp:Label></div>
                        <div class="contenedorText"><asp:TextBox ID="InArea" runat="server"></asp:TextBox> </div>
                        <div class="contenedorError"><asp:Label ID="ErrorArea" runat="server" Font-Size="Smaller" ForeColor="Red" Text=""></asp:Label></div>                                              
                        </div>

                   <div class="contenedorDatoForm">  
                        <div class="contenedorLabel"><asp:Label ID="Label7" runat="server" Text="Ciudad"></asp:Label></div>
                        <div class="contenedorText"><asp:TextBox ID="InCiudad" runat="server"></asp:TextBox> </div>
                        <div class="contenedorError"><asp:Label ID="ErrorCiudad" runat="server" Font-Size="Smaller" ForeColor="Red" Text="" CssClass="contenedorDatoForm"></asp:Label></div>                                              
                        </div>     

                    <div class="contenedorBtnApp">
                        <asp:Button ID="BtnAgregarEmpleado" runat="server" Text="Enviar Datos" class="btnApp" OnClick="BtnAgregarEmpleado_Click" /> 
                        
                        <asp:Button ID="BtnEditarEmpleado" runat="server" Text="Guardar Cambios" class="btnApp" OnClick="BtnEditarEmpleado_Click"  />

                        <asp:Button ID="BtnBorrarEmpleado" runat="server" Text="Borrar Datos" class="btnApp" OnClick="BtnBorrarEmpleado_Click"  />
                       
                     </div>
                    

                    </div>



                </div>
                
               
               
                
                
                
               
            </div>
    
        
    
    
        </main>
</asp:Content>

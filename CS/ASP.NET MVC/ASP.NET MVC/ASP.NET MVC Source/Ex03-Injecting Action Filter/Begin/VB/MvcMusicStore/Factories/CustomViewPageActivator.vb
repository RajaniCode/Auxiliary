﻿' ----------------------------------------------------------------------------------
' Microsoft Developer & Platform Evangelism
' 
' Copyright (c) Microsoft Corporation. All rights reserved.
' 
' THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
' EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
' OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
' ----------------------------------------------------------------------------------
' The example companies, organizations, products, domain names,
' e-mail addresses, logos, people, places, and events depicted
' herein are fictitious.  No association with any real company,
' organization, product, domain name, email address, logo, person,
' places, or events is intended or should be inferred.
' ----------------------------------------------------------------------------------

Public Class CustomViewPageActivator
    Implements IViewPageActivator

    Private container As IUnityContainer

    Public Sub New(ByVal container As IUnityContainer)
        Me.container = container
    End Sub

    Public Function Create(ByVal controllerContext As ControllerContext, ByVal type As Type) _
        As Object Implements IViewPageActivator.Create

        Return Me.container.Resolve(type)
    End Function
End Class

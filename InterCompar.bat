@echo off

REM .bat con permisos de administrador
:-------------------------------------
REM  --> Analizando los permisos
    IF "%PROCESSOR_ARCHITECTURE%" EQU "amd64" (
>nul 2>&1 "%SYSTEMROOT%\SysWOW64\cacls.exe" "%SYSTEMROOT%\SysWOW64\config\system"
) ELSE (
>nul 2>&1 "%SYSTEMROOT%\system32\cacls.exe" "%SYSTEMROOT%\system32\config\system"
)

REM --> Si hay error es que no hay permisos de administrador.
if '%errorlevel%' NEQ '0' (
    echo Solicitando permisos de administrador...
    goto UACPrompt
) else ( goto gotAdmin )

:UACPrompt
    echo Set UAC = CreateObject^("Shell.Application"^) > "%temp%\getadmin.vbs"
    set params = %*:"=""
    echo UAC.ShellExecute "cmd.exe", "/c ""%~s0"" %params%", "", "runas", 1 >> "%temp%\getadmin.vbs"

    "%temp%\getadmin.vbs"
    del "%temp%\getadmin.vbs"
    exit /B

:gotAdmin
    pushd "%CD%"
    CD /D "%~dp0"

title Inicioando...
color a
:home
mode 60, 5
set /a trt=%trt%+1
cls
echo.
echo.
echo      Cargando... ������������������������������^> %trt%
echo.        
if %trt%==100 goto inicio
goto home

:inicio


cls


color 0a
cls
MODE 100, 26 
title inicio
echo                                            �
echo   MOMENTO DE EJECUCION:                    �
echo     FECHA - %DATE%.               �                    DIRECCION ID: %random%%random%
echo     HORA  - %TIME%.                   �                                         
echo                              ���������������������������Ŀ
echo                              ��������������������������ͻ�
echo                              ��      ������������Ŀ     �� 
echo ������������������������������������ĳ7.salir     ������������������������������������Ŀ
echo �  ����������������������ͻ  ��      ��������������     ��  ����������������������ͻ   �
echo �  �  1.Verficar          �  ��������������������������ͼ�  �  4.informacion       �   �
echo �  ����������������������ͼ  �����������������������������  ����������������������ͼ   �
echo �  ����������������������ͻ �     �  ������ �     �  �    � ����������������������ͻ   �
echo �  �  2.Crear red         � ��   ��  �      ��    �  �    � �  5.seguridad         �   �
echo �  ����������������������ͼ � � � �  ����   � �   �  �    � ����������������������ͼ   �
echo �  ����������������������ͻ �  �  �  ����   �  �  �  �    � ����������������������ͻ   �
echo �  �  3.iniciar red       � �  �  �  �      �   � �  �    � �  6.detener           �   �
echo �  ����������������������ͼ �  �  �  ������ �    ��  ������ ����������������������ͼ   �
echo ��������������������������������������������������������������������������������������Ŀ 
echo �                                         Nota                                         � 
echo ��������������������������������������������������������������������������������������Ŀ 
echo �         Para que funcione tienes que ejecutarme como administrador...                �
echo ��������������������������������������������������������������������������������������Ŀ 
echo �              Autor (Fabian Villase�or Sanchez de Ing.Informatica)                    �
echo ���������������������������������������������������������������������������������������� 
set /p villase�or=ROOT /: $ #
if %villase�or%==1 goto 1
if %villase�or%==2 goto 2
if %villase�or%==3 goto 3
if %villase�or%==4 goto 4
if %villase�or%==5 goto 5
if %villase�or%==6 goto 6
if %villase�or%==7 goto 7
color c
echo su numero es incorrecto!!!
echo vuelva a intentarlo
timeout /NOBREAK /T 3 >nul
cls
goto inicio

:1
   cls
   MODE 100, 100
   title:informacion de el control de red
    echo.
        netsh wlan show drivers
    echo.
    pause >nul
    goto inicio
 

:2
    cls
    echo.
    MODE 100, 30
    echo.
        netsh wlan set hostednetwork MODE=allow ssid=Fabian key=06021997
    echo.
    pause > nul
    goto inicio

:3   
    cls
    echo.
    echo.
    echo.
        netsh wlan start hostednetwork
    echo.
    pause
    goto inicio
   
:4
cls
    echo.
    echo.
    echo.
        netsh wlan show hostednetwork
    echo.
    pause
    goto inicio

:5
    echo.
    echo.
    echo.
        netsh wlan show hostednetwork setting=security
    echo.
    pause
    goto inicio

:6
cls
echo.
echo.
echo. 
     netsh wlan stop hostednetwork
     echo.
     pause
     echo.
     goto inicio
:7
title Saliendo...
color a
:saliendo
mode 60, 5
set /a trt=%trt%-1
cls
echo.
echo.
echo      Cerrando... ������������������������������^> %trt%
echo.        
if %trt%==1 goto salir
goto saliendo

:salir
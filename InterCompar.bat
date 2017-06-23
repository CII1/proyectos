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
echo      Cargando... ÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ^> %trt%
echo.        
if %trt%==100 goto inicio
goto home

:inicio


cls


color 0a
cls
MODE 100, 26 
title inicio
echo                                            ³
echo   MOMENTO DE EJECUCION:                    ³
echo     FECHA - %DATE%.               ³                    DIRECCION ID: %random%%random%
echo     HORA  - %TIME%.                   ³                                         
echo                              ÚÄÄÄÄÄÄÄÄÄÄÄÄÄÁÄÄÄÄÄÄÄÄÄÄÄÄÄ¿
echo                              ³ÉÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ»³
echo                              ³º      ÚÄÄÄÄÄÄÄÄÄÄÄÄ¿     º³ 
echo ÚÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ³7.salir     ³ÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¿
echo ³  ÉÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ»  ³º      ÀÄÄÄÄÄÄÄÄÄÄÄÄÙ     º³  ÉÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ»   ³
echo ³  º  1.Verficar          º  ³ÈÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ¼³  º  4.informacion       º   ³
echo ³  ÈÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ¼  ÀÄÄÄÄÄÄÄÄÄÄÄÄÄÂÄÄÄÄÄÄÄÄÄÄÄÄÄÙ  ÈÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ¼   ³
echo ³  ÉÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ» Û     Û  ÛÛÛÛÛÛ Û     Û  Û    Û ÉÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ»   ³
echo ³  º  2.Crear red         º ÛÛ   ÛÛ  Û      ÛÛ    Û  Û    Û º  5.seguridad         º   ³
echo ³  ÈÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ¼ Û Û Û Û  ÛÛÛÛ   Û Û   Û  Û    Û ÈÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ¼   ³
echo ³  ÉÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ» Û  Û  Û  ÛÛÛÛ   Û  Û  Û  Û    Û ÉÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ»   ³
echo ³  º  3.iniciar red       º Û  Û  Û  Û      Û   Û Û  Û    Û º  6.detener           º   ³
echo ³  ÈÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ¼ Û  Û  Û  ÛÛÛÛÛÛ Û    ÛÛ  ÛÛÛÛÛÛ ÈÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ¼   ³
echo ÀÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¿ 
echo ³                                         Nota                                         ³ 
echo ÀÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¿ 
echo ³         Para que funcione tienes que ejecutarme como administrador...                ³
echo ÀÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¿ 
echo ³              Autor (Fabian Villaseñor Sanchez de Ing.Informatica)                    ³
echo ÀÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÙ 
set /p villaseñor=ROOT /: $ #
if %villaseñor%==1 goto 1
if %villaseñor%==2 goto 2
if %villaseñor%==3 goto 3
if %villaseñor%==4 goto 4
if %villaseñor%==5 goto 5
if %villaseñor%==6 goto 6
if %villaseñor%==7 goto 7
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
echo      Cerrando... ÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ^> %trt%
echo.        
if %trt%==1 goto salir
goto saliendo

:salir
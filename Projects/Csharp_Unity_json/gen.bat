set WORKSPACE=..\..

set GEN_CLIENT=%WORKSPACE%\Tools\Luban\Luban.dll
set CONF_ROOT=%WORKSPACE%\DataTables

dotnet %GEN_CLIENT% ^
    -t client ^
    -c cs-simple-json ^
    -d json  ^
    --conf %CONF_ROOT%\luban.conf ^
    -x outputCodeDir=Assets/Gen ^
    -x outputDataDir=..\GenerateDatas\json ^
    -x pathValidator.rootDir=D:\workspace2\luban_examples\Projects\Csharp_Unity_bin ^
    -x l10n.provider=default ^
    -x l10n.textFile.path=*@%WORKSPACE%\DataTables\Datas\l10n\texts.json ^
    -x l10n.textFile.keyFieldName=key

pause
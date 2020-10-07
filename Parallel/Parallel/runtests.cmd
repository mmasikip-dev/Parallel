@pushd %~dp0

@where /q msbuild

@if ERRORLEVEL 1 goto end

@cd ..\packages\SpecRun.Runner.*\tools\net461

@set profile=%1
@if "%profile%" == "" set profile=Default

@if exist "%~dp0\bin\Debug\%profile%.srprofile" (
	@echo == EXISTS
    SpecRun.exe run "%profile%.srprofile" --baseFolder "%~dp0\bin\Debug" --log "specrun.log" %2 %3 %4 %5
) else (
	@echo == NOT EXISTS
    SpecRun.exe run --baseFolder "%~dp0\bin\Debug" --log "specrun.log" %2 %3 %4 %5
)

:end

@popd

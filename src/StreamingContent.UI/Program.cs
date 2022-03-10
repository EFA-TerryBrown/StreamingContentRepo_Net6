
// ProgramUI ui = new ProgramUI();
// ui.Run();

FunConsole funUI = new FunConsole();
ProgramUI_DI progDI = new ProgramUI_DI(funUI);
progDI.Run();
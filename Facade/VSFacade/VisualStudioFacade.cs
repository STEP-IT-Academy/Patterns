namespace Facade.VSFacade
{
    /// <summary>
    /// "Фасад"
    /// </summary>
    class VisualStudioFacade
    {
        TextEditor textEditor;
        Compiler compiler;
        CLR clr;

        public VisualStudioFacade(TextEditor textEditor, Compiler compiler, CLR clr)
        {
            this.textEditor = textEditor;
            this.compiler = compiler;
            this.clr = clr;
        }

        public void Start()
        {
            textEditor.CreateCode();
            textEditor.SaveCode();
            compiler.Compile();
            clr.Execute();
        }

        public void Stop()
        {
            clr.Finish();
        }
    }
}

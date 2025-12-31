using Controller;
using Serilog;
using Models;
using System.Threading.Tasks;

public class API {

    public static ControllerManager? controller {get; private set;} = null;

    public static async Task<bool> init() {

        try {

            ProgramHandler.start_logger();
            PacketTemplates.TemplateLoader.load_templates();
            await ModelsManager.init();
            API.controller = new();
            await API.controller.load_settings();

            return true;

        }
        catch (ControllerManagerException ex) {
            Log.Error("Could not load API");
            Log.Error(ex.StackTrace!);
            return false;
        }
        catch (Exception ex) {
            Log.Error(ex.StackTrace!);
            return false;
        }

    }

}
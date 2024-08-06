using ClosedXML.Report;

namespace SpeechForms.Bl;

public class PrintDatas
{
    Dictionary<string, object> dic = new();
    private readonly string pathPattern;
    private readonly string pathSaveFile;
    

    public PrintDatas(string pathPattern, string pathSaveFile)
    {
        this.pathPattern = pathPattern;
        this.pathSaveFile = pathSaveFile;
     
    }

    public void Run(ICollection<IPrintModel> datas)
    {
        if(datas is null) return;

        int countUser = datas.Count;

        dic.Add("datas", datas);
        dic.Add("countUser", countUser);       


        Print(dic, pathPattern, pathSaveFile);
    }


    private void Print(Dictionary<string, object> datas, string pathPattern, string pathSaveFile)
    {

        if (datas is null || datas.Count == 0) return;

        using XLTemplate template = new XLTemplate(pathPattern);
        try
        {

            foreach (KeyValuePair<string, object> data in datas)
            {
                string key = data.Key;
                object value = data.Value;
                template.AddVariable(key, value);

            }

            template.Generate();
            template.SaveAs(pathSaveFile);
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
            //notification?.Error(ex.Message, "Ошибка при печати файла");
        }
        finally
        {

            template?.Dispose();
        }



    }
}

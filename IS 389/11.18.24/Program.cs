//week 12 - 11.18.24

using System.ComponentModel.DataAnnotations;
using HtmlAgilityPack;
Console.WriteLine("\n\n\n\n");

HtmlWeb HW = new HtmlWeb();//create an HTMLWeb object to lead a webpage
try{
    string path1 = "https://www.wikipedia.org/";
    string path2 = "https://example.com/";
    string path4 = "https://www.scrapethissite.com/pages/simple/";
    string path3 = "https://en.wikipedia.org/wiki/Knights_of_the_Round_Table";

    HtmlDocument doc = HW.Load(path3);//load the webpage
    //store it as an HtmlDocument object
    HtmlNodeCollection Paragraphs = doc.DocumentNode.SelectNodes("//*[@id='mw-content-text']/div[1]/table/tbody/tr/td[@scope = 'row']");
    //body   
    //html/body/div[1]/h1   //you can copy the path
    //span[@class = 'country-capital'] - span with the attribute class names country-capital
    //access all nodes with a tag of </p>, store them as a list of nodes accessibile through Paragraphts

    // Console.WriteLine(Paragraphs);//data structure - entire node collection
    // Console.WriteLine(Paragraphs.Count);//COUNT - counts how many p are present
    // Console.WriteLine(Paragraphs[1]);//just one individual node
    // Console.WriteLine(Paragraphs[1].InnerText);//outputs the info inbetween the p tags, ignoring all attributes
    // Console.WriteLine(Paragraphs[1].InnerHtml);//the whole html bewteen the p tags, attributes included

    Console.WriteLine("\n\n");//spacing

    //looping though
    // for(int i=0; i <Paragraphs.Count; i++)
    // {
    //     Console.WriteLine(Paragraphs[i].InnerText);
    // }//for loop
    Console.WriteLine("\n\n");//spacing
    foreach(HtmlNode item in Paragraphs)
    {
        Console.WriteLine(item.InnerText);
    }//foreach

}//try
catch(HtmlWebException){
    Console.WriteLine("Load Failed");
}//catch
catch{
    Console.WriteLine("Something went wrong! :(");
}
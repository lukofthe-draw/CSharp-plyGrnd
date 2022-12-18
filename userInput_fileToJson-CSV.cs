@{
    // Get the form data from the request
    var name = Request.Form["name"];
    var occupation = Request.Form["occupation"];
    var specialty = Request.Form["specialty"];
    var dreams = Request.Form["dreams"];

    // Store the data in a dictionary
    var data = new Dictionary<string, string>
    {
        {"Name", name},
        {"Occupation", occupation},
        {"Specialty", specialty},
        {"Dreams", dreams}
    };

    // Convert the data to a JSON string
    var json = Json.Encode(data);

    // Save the JSON string to a file
    System.IO.File.WriteAllText("data.json", json);

    // Convert the data to a CSV string
    var csv = "Name,Occupation,Specialty,Dreams\n" +
              $"{name},{occupation},{specialty},{dreams}";

    // Save the CSV string to a file
    System.IO.File.WriteAllText("data.csv", csv);
}

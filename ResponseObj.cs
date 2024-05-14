using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class cityinfo
{
    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("altName")]
    public string altName { get; set; }

    [JsonProperty("country")]
    public string country { get; set; }

}

public class data
{
    [JsonProperty("icao")]
    public string icao { get; set; }

    [JsonProperty("iata")]
    public string iata { get; set; }

    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("city")]
    public string city { get; set; }

    [JsonProperty("state")]
    public string state { get; set; }

    [JsonProperty("country")]
    public string country { get; set; }

    [JsonProperty("elevation")]
    public int elevation { get; set; }

    [JsonProperty("lat")]
    public double lat { get; set; }

    [JsonProperty("lon")]
    public double lon { get; set; }

    [JsonProperty("tz")]
    public string tz { get; set; }

    [JsonProperty("city_info")]
    public cityinfo cityinfo { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}

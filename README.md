# BasicGeoIPAPI #
I really just wanted to do some fun stuff so i made this

## Usage ##

To use this api install newtonsoftJson into your project

Secondly add these class files to your project and input your namespace into the classes.
Then youre all set for using it. lets say you want to get the ip holders country. do

var geo = IpgeoAPI.getIPdata("ip here");

Console.WriteLine(geo.country_name);
//example output: Norway

theres more data within the class like:

var geo = IpgeoAPI.getIPdata("ip here");

geo.ip
geo.ip_number
geo.ip_version
geo.country_name
geo.country_code2
geo.isp
geo.response_code
geo.response_message

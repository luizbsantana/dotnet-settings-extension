# Configuration Custom Extension
Get custom value from IConfiguration or from EnvironmentVariable just by passing the key. It will resolve automatically if it is need to use ':' or '_' as the key separator.

<br>

## :page_facing_up: Getting value from IConfiguration

:bulb: Get value from IConfiguration which is normally from your appsettings.json file:

```
using Configuration.CustomExtension

...

public YourConstructor(IConfiguration configuration)
{
    var value = configuration.GetCustomValue("your_custom_key");
}

...
```

<br>

## :floppy_disk: Getting value from the Environment

:bulb: Get value from your Environment Variables:

```
using Configuration.CustomExtension

...

public YourConstructor()
{
    var value = CustomConfiguration.GetCustomEnvironmentVariable("your_custom_key");
}

...
```

<br>

## :v: Contributors

[luizb_santana](https://twitter.com/luizb_santana)

## :mailbox_with_mail: License

This software was created for study purposes only. Feel free to try it out.

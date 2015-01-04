Ping3r
======

A *(really)* simple C# program for Windows, for checking the devices in a local network.

### Usage

Since this is a very uncomplicated Windows Forms application, its use is quite straightforward. Just press the "Run" button, and relax. The results will appear in some minutes in the box below.

>Don't worry if it takes too long, though I added a multithreading function for speeding up the proceess, it still needs **about 5 minutes** for analyzing the whole network (think it's 65025 IP's to check). **It may vary**, depending on your machine and your network conditions.

### How does it work?

It basically pings all IP adresses in the 192.168.xxx.xxx range, and in the requests which receives an answer, it flags them as "up".

>Some devices and operative systems (such as Windows Server 2008 or 2012) don't answer to pings by default, so even if they're connected to the network, they won't appear.

### Licensing

This program is under MIT License. You can take a further look in the license file.

***

Made by Yago G. (C) 2015
[github.com/YagoGG](https://github.com/YagoGG)

using DIP;

MobilePhone damonMiUI = new MiUI("小米12", "damon");
MobilePhone stefanHuawei = new Huawei("华为P50", "stefan");
MobilePhoneUser stefan = new Kid("stefan");
MobilePhoneUser damon = new Adult("damon");

stefan.UsePhone(stefanHuawei, damonMiUI);
damon.UsePhone(damonMiUI, stefanHuawei);

class P
{
    static void Main()
    {
        var a = (int)default;
        void C(CS a) => System.Console.Write(a.Exec());

        S:
        CS b = new H();
        if (a == default) goto W;
        b = new e();
        if (a == 1) goto W;
        b = new l();
        if ((a > 1 && a < 4) || a == 9) goto W;
        b = new o();
        if (a == 4 || a == 7) goto W;
        b = new sp();
        if (a == 5) goto W;
        b = new W();
        if (a == 6) goto W;
        b = new r();
        if (a == 8) goto W;
        b = new d();
        if (a == 10) goto W;
        b = new ex();

        W: C(b);
        a++;
        if (a == 12) goto E;
        goto S;

        E: return;
    }
}

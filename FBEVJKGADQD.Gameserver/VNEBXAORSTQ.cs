using FBEVJKGADQD.Common.HSFCATOPDTI.GLYMTKISXFZ;
using FBEVJKGADQD.Common.HSFCATOPDTI.GNECZXLXXHH;
using FBEVJKGADQD.Gameserver.BZMFWWUFBSV;
using Microsoft.Extensions.Hosting;

namespace FBEVJKGADQD.Gameserver;
internal class VNEBXAORSTQ : IHostedService
{
    private readonly MHJMMWVKPKE JCRQWCVNWZJ;

    public VNEBXAORSTQ(MHJMMWVKPKE gateway, SDDKEYJXNVG QQNFYHOZYAM, QOAXVAVOKZE IYUCXBDYJRJ)
    {
        _ = QQNFYHOZYAM;
        _ = IYUCXBDYJRJ;

        JCRQWCVNWZJ = gateway;
    }

    public async Task StartAsync(CancellationToken SDKCGJXNFBJ)
    {
        await JCRQWCVNWZJ.KSTDGKIDJYV();
    }

    public async Task StopAsync(CancellationToken SDKCGJXNFBJ)
    {
        await JCRQWCVNWZJ.QVDMGAUKDWD();
    }
}

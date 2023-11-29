using System.Collections.Immutable;
using System.Linq.Expressions;
using System.Reflection;
using FBEVJKGADQD.Gameserver.BZMFWWUFBSV;
using FBEVJKGADQD.Gameserver.NMIJCSMNYNB.HWKZPLJYJSU;
using FBEVJKGADQD.Gameserver.NMIJCSMNYNB.XVIQQDCPLZW;
using FBEVJKGADQD.Protocol;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace FBEVJKGADQD.Gameserver.NMIJCSMNYNB.VNUTIAPYCZC;
internal class ONVXSSCFBAG
{
    private static readonly ImmutableDictionary<TVSUXQOGQCR, Func<IServiceProvider, LFZRLZCJSQD, ValueTask<PBWRXELQMPB>>> BYQZRMXQSNC;
    private readonly IServiceProvider BVAHVQCOZYY;
    private readonly ILogger FOZNIWJRKDF;

    static ONVXSSCFBAG()
    {
        BYQZRMXQSNC = InitializeHandlers();
    }

    public ONVXSSCFBAG(IServiceProvider YHLOSLYJNGG, ILogger<ONVXSSCFBAG> GULXPFJHUAL)
    {
        BVAHVQCOZYY = YHLOSLYJNGG;
        FOZNIWJRKDF = GULXPFJHUAL;
    }

    public async ValueTask<PBWRXELQMPB?> AEFFEZQEPJC(LFZRLZCJSQD AVGBWXBJZYC)
    {
        ArgumentNullException.ThrowIfNull(AVGBWXBJZYC, nameof(AVGBWXBJZYC));

        if (BYQZRMXQSNC.TryGetValue(AVGBWXBJZYC.TVSUXQOGQCR, out Func<IServiceProvider, LFZRLZCJSQD, ValueTask<PBWRXELQMPB>>? handler))
        {
            return await handler(BVAHVQCOZYY, AVGBWXBJZYC);
        }

        FOZNIWJRKDF.LogWarning("No handler defined for command of type {cmdType}", AVGBWXBJZYC.TVSUXQOGQCR);
        return null;
    }

    private static ImmutableDictionary<TVSUXQOGQCR, Func<IServiceProvider, LFZRLZCJSQD, ValueTask<PBWRXELQMPB>>> InitializeHandlers()
    {
        ImmutableDictionary<TVSUXQOGQCR, Func<IServiceProvider, LFZRLZCJSQD, ValueTask<PBWRXELQMPB>>>.Builder IAKNFCQYXOO
            = ImmutableDictionary.CreateBuilder<TVSUXQOGQCR, Func<IServiceProvider, LFZRLZCJSQD, ValueTask<PBWRXELQMPB>>>();

        IEnumerable<Type> types = Assembly.GetExecutingAssembly().GetTypes()
                                  .Where(type => type.GetCustomAttribute<NetControllerAttribute>() != null);

        foreach (Type type in types)
        {
            IEnumerable<MethodInfo> methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public)
                                              .Where(method => method.GetCustomAttribute<NetCommandAttribute>() != null);

            foreach (MethodInfo method in methods)
            {
                NetCommandAttribute attribute = method.GetCustomAttribute<NetCommandAttribute>()!;
                if (IAKNFCQYXOO.TryGetKey(attribute.CmdType, out _))
                    throw new Exception($"Handler for command {attribute.CmdType} defined twice!");

                IAKNFCQYXOO[attribute.CmdType] = BRPXUMIHVQY(type, method);
            }
        }

        return IAKNFCQYXOO.ToImmutable();
    }

    private static Func<IServiceProvider, LFZRLZCJSQD, ValueTask<PBWRXELQMPB>> BRPXUMIHVQY(Type controllerType, MethodInfo method)
    {
        ParameterExpression serviceProviderParameter = Expression.Parameter(typeof(IServiceProvider), "serviceProvider");
        ParameterExpression netPacketParameter = Expression.Parameter(typeof(LFZRLZCJSQD), "AVGBWXBJZYC");

        ConstantExpression controllerTypeConstant = Expression.Constant(controllerType);
        ParameterExpression controllerVariable = Expression.Variable(controllerType, "controller");
        PropertyInfo packetProperty = typeof(FURINATHIGH).GetProperty("Packet")!;

        MethodInfo createInstanceMethod = typeof(ActivatorUtilities).GetMethod("CreateInstance", new Type[] { typeof(IServiceProvider), typeof(Type), typeof(object[]) })!;

        List<Expression> expressionBlock = new()
        {
            Expression.Assign(controllerVariable, Expression.Convert(
                Expression.Call(null, createInstanceMethod, serviceProviderParameter, controllerTypeConstant, Expression.Constant(Array.Empty<object>())),
                controllerType)),
            Expression.Assign(Expression.Property(controllerVariable, packetProperty), netPacketParameter)
        };

        List<Expression> parameterExpressions = new();
        foreach (ParameterInfo parameter in method.GetParameters())
        {
            MethodInfo getServiceMethod = typeof(ServiceProviderServiceExtensions)
                .GetMethod("GetRequiredService", new Type[] { typeof(IServiceProvider) })!
                .MakeGenericMethod(parameter.ParameterType);

            parameterExpressions.Add(Expression.Call(getServiceMethod, serviceProviderParameter));
        }

        expressionBlock.Add(Expression.Call(controllerVariable, method, parameterExpressions));

        return Expression.Lambda<Func<IServiceProvider, LFZRLZCJSQD, ValueTask<PBWRXELQMPB>>>(
            Expression.Block(new[] { controllerVariable }, expressionBlock),
            serviceProviderParameter,
            netPacketParameter)
            .Compile();
    }
}

namespace xc{ public class ErrorCode{

//%%%%%%%%%%%%%%%%%%%%%%%%%%%%
//%% 源文件: 0C错误.xlsx []
//%%%%%%%%%%%%%%%%%%%%%%%%%%%%

public const ushort ERR_LOGIN_VERIFY_FAIL = 100; //登陆验证失败
public const ushort ERR_ACCOUNT_ROLE_FULL = 101; //账户角色已满
public const ushort ERR_UUID_INVALID = 104; //角色ID非法
public const ushort ERR_ACCOUNT_NAME_SENS = 105; //角色名有敏感词
public const ushort ERR_ACCOUNT_INVALID_RID = 106; //职业ID错误
public const ushort ERR_ACCOUNT_NAME_TOO_LONG = 107; //角色名太长
public const ushort ERR_ACCOUNT_NAME_DUPLICATE = 108; //角色名重复
public const ushort ERR_ACCOUNT_IS_BAN = 109; //账号被封
public const ushort ERR_ROLE_IS_BAN = 110; //角色被封
public const ushort ERR_ACCOUNT_NAME_TOO_SHORT = 111; //角色名太短
public const ushort ERR_ACCOUNT_LOGIN_AGAIN = 112; //您的账号在其它设备上登录
public const ushort ERR_SESSION_LOGIN_FAIL = 113; //自动重连失败
public const ushort ERR_HEART_TOO_FAST = 114; //数据发生异常-114
public const ushort ERR_SERVER_CLOSED = 120; //服务器未开放
public const ushort ERR_QUEUE_MAX = 121; //服务器排队人数达到上限
public const ushort ERR_SVR_BUSY = 122; //服务器繁忙，请稍候
public const ushort ERR_SERVER_MANTAIN = 123; //服务器系统维护中
public const ushort ERR_ERROR = 200; //发生错误
public const ushort ERR_BAD_REQUEST = 201; //非法请求
public const ushort ERR_SYS_NOT_OPEN = 202; //系统未开放
public const ushort ERR_BAD_DATA = 203; //数据发生错误
public const ushort ERR_REQUEST_CDING = 204; //请求过于频繁
public const ushort ERR_SYS_CLOSED = 205; //功能已关闭
public const ushort ERR_LV_NOT_ENOUGH = 1000; //等级不够
public const ushort ERR_TRANSFER_LV_NOT_ENOUGH = 1001; //转职等级不够
public const ushort ERR_EXP_NOT_ENOUGH = 1002; //经验不足
public const ushort ERR_HONOR_NOT_ENOUGH = 1003; //荣誉点不足
public const ushort ERR_GOODS_NOT_ENOUGH = 1004; //道具不足
public const ushort ERR_COIN_NOT_ENOUGH = 1005; //铜钱不足
public const ushort ERR_COIN_BIND_NOT_ENOUGH = 1006; //绑铜不足
public const ushort ERR_COIN_AND_BIND_NOT_ENOUGH = 1007; //铜钱以及绑铜不足
public const ushort ERR_DIAMOND_NOT_ENOUGH = 1008; //金锭不足
public const ushort ERR_DIAMOND_BIND_NOT_ENOUGH = 1009; //银锭不足
public const ushort ERR_DIAMOND_AND_BIND_NOT_ENOUGH = 1010; //金锭以及绑金不足
public const ushort ERR_LV_SKILL_SCORE_NOT_ENOUGH = 1011; //升级技能总分不足
public const ushort ERR_RACE_SCORE_NOT_ENOUGH = 1012; //职业积分不足
public const ushort ERR_ACTIVITY_NOT_ENOUGH = 1013; //活跃度不足
public const ushort ERR_ACHIEVE_MPOINT_NOT_ENOUGH = 1014; //成就勋章点数不足
public const ushort ERR_MONEY_NOT_ENOUGH = 1015; //货币不足
public const ushort ERR_TRIGRAM_SP_NOT_ENOUGH = 1016; //八卦牌升级点数不足
public const ushort ERR_LV_POINT_LIMIT = 1017; //点数不足
public const ushort ERR_PLAYER_DISPLAY_OFFLINE = 1018; //无法查看离线玩家信息
public const ushort ERR_MATERIALS_NOT_ENOUGH = 1019; //材料不足
public const ushort ERR_MONEY_ARTIFACT_NOT_ENOUGH = 1020; //四灵圣气不足
public const ushort ERR_MONEY_HUNQI_NOT_ENOUGH = 1021; //魂气不足
public const ushort ERR_BAG_SPACE_NOT_ENOUGH = 1022; //背包空间不足
public const ushort ERR_MONEY_FAIRY_SOUL_NOT_ENOUGH = 1023; //仙魂不足
public const ushort ERR_MONEY_DEMON_SOUL_NOT_ENOUGH = 1024; //魔魂不足
public const ushort ERR_PLAYER_RACE_INVAIL = 1025; //云天姬即将来袭，请先创建其他角色进入游戏
public const ushort ERR_WARE_FULL = 1101; //仓库已满，请及时清理
public const ushort ERR_BAG_PAGE_LIMIT = 1102; //扩充背包空间已达上限
public const ushort ERR_NOT_TO_WARE = 1103; //该物品不能放入仓库
public const ushort ERR_USE_LV_LIMIT = 1104; //请提升等级再来使用物品
public const ushort ERR_GOODS_NOT_EXIST = 1105; //该道具已被出售或销毁，无法查看具体信息
public const ushort ERR_USE_JOB_LIMIT = 1106; //职业不符
public const ushort ERR_USE_PAY_LIMIT = 1107; //累计充值未达到
public const ushort ERR_USE_COST_LIMIT = 1108; //累计消费未达到
public const ushort ERR_USE_CD_LIMIT = 1109; //冷却时间未到
public const ushort ERR_USE_NUM_LIMIT = 1110; //该物品一次只能使用一个
public const ushort ERR_USE_ALIVE_LIMIT = 1111; //死亡状态不能使用该物品
public const ushort ERR_USE_HP_FULL = 1112; //生命值已满
public const ushort ERR_USE_EN_FULL = 1113; //内力已满
public const ushort ERR_BUY_NUM_NOT_ENOUGH = 1114; //购买次数不够
public const ushort ERR_BUY_NUM_OVER = 1115; //购买次数超过单次最大次数
public const ushort ERR_USE_PK_VAL_0 = 1116; //PK值为0
public const ushort ERR_SHOP_NOT_EXIST = 1117; //<color=#fa1e1e>商品不存在</color>
public const ushort ERR_SHOP_INVALID = 1118; //该商品已下架，请重新打开商城刷新商品列表
public const ushort ERR_USE_BUFF_LIMIT = 1119; //已有同类型更高阶BUFF
public const ushort ERR_USE_HANG_TIME_LIMIT = 1120; //<color=#fa1e1e>使用失败，离线挂机时间不能超过上限</color>
public const ushort ERR_USE_DAILY_LIMIT = 1121; //道具使用次数超过每日上限
public const ushort ERR_USE_CONSUME_LIMIT = 1122; //消费额度不足
public const ushort ERR_USE_NO_LVPOINT = 1123; //当前没有可洗的属性点
public const ushort ERR_LVPOINT_EQUIP_DOWN = 1124; //您身上部分装备不满足穿戴属性，已卸下放入背包
public const ushort ERR_SHOP_VIP_LIMIT_NOT_ENOUGH = 1125; //VIP等级不足，建议先提示VIP等级
public const ushort ERR_USE_SUCCESS = 1126; //使用成功
public const ushort ERR_USE_NO_BOOS_DEAD = 1127; //没有BOSS死亡，无法使用
public const ushort ERR_USE_BAG_FULL = 1128; //背包空间不足，无法批量使用更多
public const ushort ERR_BAG_FULL = 1130; //背包已满，请及时清理
public const ushort ERR_SOUL_BAG_FULL = 1131; //武魂背包已满，请及时清理
public const ushort ERR_DECORATE_BAG_FULL = 1132; //饰品背包已满，请及时清理
public const ushort ERR_GOD_EQUIP_BAG_FULL = 1133; //神兵背包已满，请及时清理
public const ushort ERR_RIDE_EQUIP_BAG_FULL = 1134; //坐骑背包已满，请及时清理
public const ushort ERR_ELEMENT_EP_BAG_FULL = 1135; //元素装备背包已满，请及时清理
public const ushort ERR_LIGHT_SOUL_BAG_FULL = 1136; //神魂背包已满，请及时清理
public const ushort ERR_MAGIC_EQUIP_BAG_FULL = 1137; //法宝背包已满，请及时清理
public const ushort ERR_ARTIFACT_EP_BAG_FULL = 1138; //器魂背包已满，请及时清理
public const ushort ERR_BAG_FULL_MAIL = 1140; //背包已满，奖励通过邮件发放
public const ushort ERR_SOUL_BAG_FULL_MAIL = 1141; //武魂背包已满，奖励通过邮件发放
public const ushort ERR_DECORATE_BAG_FULL_MAIL = 1142; //饰品背包已满，奖励通过邮件发放
public const ushort ERR_GOD_EQUIP_BAG_FULL_MAIL = 1143; //神兵背包已满，奖励通过邮件发放
public const ushort ERR_RIDE_EQUIP_BAG_FULL_MAIL = 1144; //坐骑背包已满，奖励通过邮件发放
public const ushort ERR_ELEMENT_EP_BAG_FULL_MAIL = 1145; //元素装备背包已满，奖励通过邮件发放
public const ushort ERR_LIGHT_SOUL_BAG_FULL_MAIL = 1146; //神魂背包已满，奖励已通过邮件发放
public const ushort ERR_MAGIC_EQUIP_BAG_FULL_MAIL = 1147; //法宝背包已满，奖励已通过邮件发放
public const ushort ERR_ARTIFACT_EP_BAG_FULL_MAIL = 1148; //器魂背包已满，奖励已通过邮件发放
public const ushort ERR_SOUL_COMP_TO_BAG = 1150; //武魂合成成功，{0}武魂已放入武魂背包
public const ushort ERR_SOUL_COMP_TO_INLAY = 1151; //武魂合成成功，{0}武魂已自动镶嵌
public const ushort ERR_ARCHIVE_BAG_FULL = 1160; //图鉴背包已满, 请及时清理
public const ushort ERR_ARCHIVE_BAG_FULL_MAIL = 1161; //图鉴背包已满, 奖励通过邮件发放
public const ushort ERR_CHAT_LEN_ERR = 1201; //<color=#fa1e1e>内容过长</color>
public const ushort ERR_CHAT_SHUT_UP = 1202; //<color=#fa1e1e>您已被禁言，请联系管理员</color>
public const ushort ERR_CHAT_TOO_MANY = 1203; //<color=#fa1e1e>当前发言人数过多，请稍等片刻再发言</color>
public const ushort ERR_CHAT_OUT_LINE = 1204; //对方已离线，再次登录会收到您的消息哦
public const ushort ERR_CHAT_CONTENT_NO_PASS = 1205; //内容有敏感词汇
public const ushort ERR_CHAT_LEAVE_MSG_LIMIT = 1206; //已达留言上限
public const ushort ERR_CHAT_MAOER_CONTENT_NO_PASS = 1207; //有违禁词
public const ushort ERR_CHAT_MAOER_SHUT_UP = 1208; //已被禁言
public const ushort ERR_FRIEND_APPLY_SEND = 1300; //已发送好友申请
public const ushort ERR_FRIEND_ALREADY_BE = 1301; //对方已经是你的好友
public const ushort ERR_FRIEND_NUM_MAX = 1302; //你的好友数量已达上限
public const ushort ERR_FRIEND_LV_LIMIT = 1303; //未到85级，不能添加好友
public const ushort ERR_FRIEND_TARGET_LV_LIMIT = 1304; //对方未到85级，不能添加好友
public const ushort ERR_FRIEND_NOT_EXIT = 1305; //该玩家不存在
public const ushort ERR_FRIEND_OFFLINE = 1306; //对方不在线
public const ushort ERR_FRIEND_IN_BLACK = 1307; //添加失败，您在对方黑名单中
public const ushort ERR_TARGET_FRIEND_NUM_MAX = 1308; //对方的好友数量已达上限
public const ushort ERR_FRIENDSHIP_LIMIT_PERDAY = 1309; //你和<color=#0fc5f9>{0}</color>今日组队获取的亲密度已达上限
public const ushort ERR_BLACK_ALREADY_BE = 1310; //对方已经在你黑名单内
public const ushort ERR_BLACK_NUM_MAX = 1311; //你的黑名单数量已达上限
public const ushort ERR_ACT_CD = 1401; //活动CD中
public const ushort ERR_ACT_MAX_TIMES = 1402; //活动次数已达上限
public const ushort ERR_ACT_CLOSED = 1403; //不在活动时间内
public const ushort ERR_ACT_NOT_LV = 1404; //等级未达开放等级
public const ushort ERR_DUNGEON_HARD_LIMIT = 1501; //前置难度尚未完成
public const ushort ERR_LINE_FULL = 1502; //分线人数已满, 请选择其它分线
public const ushort ERR_REVIVE_CNT_LIMIT = 1503; //复活次数达到上限
public const ushort ERR_DUNGEON_ENTER_LIMIT = 1504; //<color=#fa1e1e>您还没有解锁该区域</color>
public const ushort ERR_FIRST_NOT_CHALLENGE = 1505; //还没挑战过副本
public const ushort ERR_DUNGEON_LV_UP_LIMIT = 1506; //<color=#fa1e1e>您的等级过高，无法进入该场景</color>
public const ushort ERR_DUNGEON_NO_FLY_SHOE = 1507; //该场景不允许使用飞鞋
public const ushort ERR_DUNGEON_ASSIST_NO_REWARD = 1508; //副本中无需要助战队友，无法获得助战奖励
public const ushort ERR_EVIL_TOWER_TEAM_MAX_DGID = 1509; //队伍中可挑战的最高副本小于当前选择的副本
public const ushort ERR_EVIL_TOWER_NOT_SPAN = 1510; //该玩法无法与其他服务器玩家组队，请先退离队伍
public const ushort ERR_SKILLID_NOT_EXIST = 1601; //技能ID不存在
public const ushort ERR_PRE_SKILL_NOT_EXIST = 1602; //前置技能未学习
public const ushort ERR_SKILL_NOT_REQUIRE_LEVEL = 1603; //未达到开放等级
public const ushort ERR_SKILL_LEVEL_MAX = 1604; //技能等级已达最高
public const ushort ERR_SKILL_HAS_LEARN = 1605; //该技能已学习
public const ushort ERR_SKILL_POINT_LACK = 1606; //升级经验不足
public const ushort ERR_SKILL_COIN_LACK = 1607; //铜钱不足
public const ushort ERR_SKILL_QUA_MAX = 1608; //技能品质已达最高
public const ushort ERR_SKILL_NOT_LEARN = 1609; //技能未学习
public const ushort ERR_SKILL_NOT_PRE = 1610; //前置技能不足
public const ushort ERR_SKILL_INBORN_POINT_LIMIT = 1611; //天赋技能点数上限
public const ushort ERR_SKILL_INBORN_POINT_LACK = 1612; //天赋技能点数不足
public const ushort ERR_SKILL_INBORN_POINT_UNLOCK = 1613; //天赋技能该档未解锁
public const ushort ERR_SKILL_KEY_NAME_SENS = 1614; //字符串中包含敏感字符
public const ushort ERR_SKILL_KEY_NAME_LEN_WRONG = 1615; //长度不正确
public const ushort ERR_SKILL_GOODS_LACK = 1616; //物品不足
public const ushort ERR_SKILL_KEY_NAME_DUPLICATE = 1617; //技能键位名重复了
public const ushort ERR_SWEAR_STRENGTH_NOTICE = 1701; //强化等级已自动传承
public const ushort ERR_CHANGE_BAPTIZE_NOTICE = 1702; //洗炼属性已自动传承
public const ushort ERR_DOWN_BAPTIZE_NOTICE = 1703; //已冻结洗炼属性，穿戴装备可重新激活
public const ushort ERR_DOWN_SUIT_NOTICE = 1704; //已自动拆解全部套装石并放入背包
public const ushort ERR_CHANGE_SUIT_NOTICE = 1705; //已自动继承锻造套装，多出的套装石已放入背包
public const ushort ERR_CHANGE_GEM_NOTICE_1 = 1706; //已自动转移全部宝石
public const ushort ERR_CHANGE_GEM_NOTICE_2 = 1707; //已自动转移部分宝石，多出的宝石已放入背包
public const ushort ERR_CHANGE_GEM_NOTICE_3 = 1708; //已自动拆解全部宝石并放入背包
public const ushort ERR_CAN_NOT_SUBMIT = 1709; //该装备无法提交
public const ushort ERR_DONW_SUIT_REFINE_NOTICE = 1710; //已自动拆解全部精炼石并放入背包
public const ushort ERR_DONW_EQUIP_ON_BAG_FULL = 1711; //背包已满，自动脱下的装备通过邮件发放
public const ushort ERR_MWAR_POS_ERROR = 2001; //玩家位置错误
public const ushort ERR_MWAR_NOT_EXIST = 2002; //玩家场景错误
public const ushort ERR_MWAR_FULL = 2003; //多人场景人数已满
public const ushort ERR_MWAR_CANNOT_JOIN = 2004; //多人场景无法加入
public const ushort ERR_MWAR_NO_VACANCY = 2005; //没有可加入的副本
public const ushort ERR_MWAR_BUSY = 2006; //该场景人数过多，请稍后重试
public const ushort ERR_MWAR_NO_PID = 2007; //多人场景队伍已解散
public const ushort ERR_MWAR_INVITE_LV_NOT_ENOUGH = 2008; //该好友等级不够-不能参加多人场景
public const ushort ERR_MWAR_CANNOT_REVIVE = 2009; //多人场景无法复活
public const ushort ERR_MWAR_ROOM_NOT_EXIST = 2010; //队伍不存在
public const ushort ERR_MWAR_NET_ERROR = 2011; //多人场景网络拥堵
public const ushort ERR_MWAR_INVALID_TOKEN = 2012; //多人场景无法连接
public const ushort ERR_MWAR_MAX_ROOM = 2013; //当前创建房间已达上限，请稍后再试！
public const ushort ERR_MWAR_PVP_CANNOT_JOIN = 2014; //配对战无法加入
public const ushort ERR_MWAR_SET_PEACE_CD = 2015; //和平模式设置间隔太短
public const ushort ERR_MWAR_WILD_CD = 2016; //战场冷却中
public const ushort ERR_MWAR_JOIN_ERROR = 2017; //服务器繁忙，请您稍候
public const ushort ERR_MWAR_STATE_END = 2018; //副本已结束
public const ushort ERR_MWAR_POS_NOT_SYNC = 2019; //玩家当前位置不同步
public const ushort ERR_MWAR_WORLD_BOSS_NO_HURT = 2021; //今日击杀世界BOSS次数已达上限！将无法对BOSS造成伤害！
public const ushort ERR_MWAR_SPAN_BOSS_NO_HURT = 2030; //今日击杀BOSS次数已达上限！将无法对BOSS造成伤害！
public const ushort ERR_MWAR_NO_ADD_HP = 2033; //当前状态无法增加气血
public const ushort ERR_WAR_NOT_START = 2101; //无法开启战斗
public const ushort ERR_WAR_NO_TIMES = 2102; //副本次数不够
public const ushort ERR_WAR_NO_LV = 2103; //等级不够
public const ushort ERR_WAR_STATE_ERROR = 2104; //当前状态无法开启战斗
public const ushort ERR_WAR_ARENA_IN_CD = 2105; //CD未结束
public const ushort ERR_WAR_LOCK = 2106; //副本未解锁
public const ushort ERR_WAR_BP_LIMIT = 2107; //战力不符，无法进入。
public const ushort ERR_TEAM_TARGET_IN_TEAM = 2201; //该玩家已经有队伍
public const ushort ERR_TEAM_TARGET_OFFLINE = 2202; //该玩家已离线
public const ushort ERR_EAM_TARGET_HANG = 2203; //该玩家在离线挂机中
public const ushort ERR_TEAM_MEMBER_FULL = 2204; //队伍已满员
public const ushort ERR_TEAM_DISSOLVE = 2205; //队伍已解散
public const ushort ERR_TEAM_BUILD = 2206; //队伍创建成功
public const ushort ERR_TEAM_CANCEL_APPLY = 2207; //该申请已取消
public const ushort ERR_TEAM_MEMBER_ERROR = 2208; //队伍成员错误
public const ushort ERR_TEAM_LV_LIMIT = 2209; //您不符合该队伍的等级限制
public const ushort ERR_TEAM_IN_DNG_BUILD = 2210; //<color=#fa1e1e>您在副本中，无法创建队伍</color>
public const ushort ERR_TEAM_IN_DNG_INVITE = 2211; //<color=#fa1e1e>对方在副本中，无法接受邀请</color>
public const ushort ERR_TEAM_IN_DNG_ACCEPT = 2212; //<color=#fa1e1e>您在副本中，无法接受邀请</color>
public const ushort ERR_TEAM_IN_DNG_APPROVE = 2213; //<color=#fa1e1e>对方在副本中，无法加入队伍</color>
public const ushort ERR_TEAM_IN_DNG_APPLY = 2214; //<color=#fa1e1e>您在副本中，无法申请加入队伍</color>
public const ushort ERR_TEAM_SELF_FORBID_SPAN = 2215; //<color=#fa1e1e>您所在的场景不允许跨服组队</color>
public const ushort ERR_TEAM_FORBID_SPAN = 2216; //<color=#fa1e1e>队伍中有非本服成员在不允许跨服组队的场景中</color>
public const ushort ERR_TEAM_APPLY_FORBID_SPAN = 2217; //<color=#fa1e1e>申请入队玩家所在的场景不允许跨服组队</color>
public const ushort ERR_TEAM_MEMBER_FORBID_SPAN = 2218; //<color=#fa1e1e>申请入队玩家与队伍中某位在不允许跨服组队的场景的玩家不是同一个服</color>
public const ushort ERR_TEAM_SERVER_LIMIT = 2220; //该玩法无法与其他服务器玩家组队挑战
public const ushort ERR_DUNGEON_NOT_TEAM_LEADER = 2301; //组队状态下只有队长可以开启副本
public const ushort ERR_DUNGEON_TEAM_MEMBER_CHANGE = 2302; //队伍成员有变动，停止进入副本
public const ushort ERR_DUNGEON_POLL_TIMEOUT = 2303; //副本准备超时
public const ushort ERR_DUNGEON_ENTERING = 2304; //所有队员已准备，即将进入副本
public const ushort ERR_DUNGEON_MERBER_NOT_OK = 2305; //有些队员状态无法进入副本
public const ushort ERR_DUNGEON_SINGLE_PLAY = 2306; //不能组队进入此副本
public const ushort ERR_DUNGEON_MULTIPLE_PLAY_LOW = 2307; //队伍人数不足以进入此副本
public const ushort ERR_DUNGEON_MULTIPLE_PLAY_HIGH = 2308; //队伍超出进入此副本人数限制
public const ushort ERR_DUNGEON_NOT_START_HERE = 2309; //当前场景不允许传送，请先退出场景
public const ushort ERR_DUNGEON_OFFLINE = 2310; //不在线
public const ushort ERR_DUNGEON_ALREADY_IN = 2311; //已在副本中
public const ushort ERR_DUNGEON_HANG = 2312; //在离线挂机中
public const ushort ERR_DUNGEON_NOT_IN_PATCH = 2313; //需要下载最新资源包才可以进入场景
public const ushort ERR_DUNGEON_MULTIPLE_LIMIT = 2314; //仅2人队伍可以进入副本
public const ushort ERR_DUNGEON_MERGE_MONEY_NOT_ENOUGH = 2315; //副本合并所需绑金及金锭不足
public const ushort ERR_DEAD_SPACE_NOT_START = 2321; //破碎死狱岛未开启
public const ushort ERR_DEAD_SPACE_LV_ERROR = 2322; //等级不够, 不能进入破碎死狱岛
public const ushort ERR_DEAD_SPACE_NO_TEAM = 2323; //组队状态下不能进入破碎死狱岛
public const ushort ERR_DEAD_SPACE_SCORE_FULL = 2324; //您已参加过破碎死狱岛
public const ushort ERR_CORSAIR_LV_ERROR = 2325; //等级不够，不能扫荡海盗船
public const ushort ERR_WORSHIP_MEETING_NOT_START = 2326; //剑域盛会未开启
public const ushort ERR_WORSHIP_MEETING_NO_TEAM = 2327; //组队状态下不能进入剑域盛会
public const ushort ERR_RANK_IS_RANKED = 2328; //您已膜拜该雕像
public const ushort ERR_ANSWER_NUM_NOT_ENOUGH = 2329; //本日答题次数已达上限，请下次再来
public const ushort ERR_NOT_IN_GUILD_MANOR = 2330; //不在帮派领地
public const ushort ERR_BOSS_GUIDE_DONE = 2331; //已完成引导
public const ushort ERR_SWEEP_NOT_ALLOWED = 2332; //未达到扫荡条件
public const ushort ERR_DUNGEON_SHURA_NOT_START = 2340; //修罗战场活动未开始
public const ushort ERR_DUNGEON_SHURA_REWARDED = 2341; //修罗战场已通关
public const ushort ERR_DUNGEON_SHURA_BOX_READED = 2342; //此宝箱正在被采集中
public const ushort ERR_DUNGEON_SHURA_HAD_JOIN = 2343; //不能重复加入同一场战斗
public const ushort ERR_TRIGRAM_RUNE_INVALID_SCHEME = 2401; //无效符文升级方案
public const ushort ERR_TRIGRAM_RUNE_MAX_LV = 2402; //符文已到达最高等级
public const ushort ERR_TRIGRAM_RUNE_NOT_GOT = 2403; //符文未解锁
public const ushort ERR_GUILD_BUILD_MONEY_LIMIT = 2500; //无法创建，您的金锭数额不足
public const ushort ERR_GUILD_SAME_NAME = 2501; //帮派名字已占用
public const ushort ERR_GUILD_APPLY_MEMBER_LIMIT = 2502; //该帮派已满员
public const ushort ERR_GUILD_APPLY_NUM_LIMIT = 2503; //该帮派申请人数已达上限，请换其他帮派申请
public const ushort ERR_GUILD_APPLY_POWER_LIMIT = 2504; //您不满足此帮派的申请要求：战力{0}以上
public const ushort ERR_GUILD_APPLY_LV_LIMIT = 2505; //您不满足此帮派的申请要求：等级{0}级以上
public const ushort ERR_GUILD_APPLY_PEAK_LV_LIMIT = 2506; //您不满足此帮派的申请要求：等级巅峰{0}级以上
public const ushort ERR_GUILD_APPLY_SUC = 2507; //申请已发送，等待批准
public const ushort ERR_GUILD_DUTY_NUM_LIMIT = 2508; //该职务人数已达上限
public const ushort ERR_GUILD_NO_GUILD = 2509; //您当前没有帮派，无法完成此操作
public const ushort ERR_GUILD_CTB_NOT_ENOUGH = 2510; //帮派贡献不足
public const ushort ERR_GUILD_ALTER_CONTENT = 2511; //发布失败，您输入的内容不合规
public const ushort ERR_GUILD_BOSS_FUND_LIMIT = 2512; //<color=#fa1e1e>帮派资金不足，不能开启帮派boss</color>
public const ushort ERR_GUILD_BOSS_GLV_LIMIT = 2513; //<color=#fa1e1e>帮派等级不足，不能开启帮派boss</color>
public const ushort ERR_GUILD_BOSS_DNUM_LIMIT = 2514; //<color=#fa1e1e>帮派BOSS本日开启次数已达上限</color>
public const ushort ERR_GUILD_BOSS_WNUM_LIMIT = 2515; //<color=#fa1e1e>帮派BOSS本周开启次数已达上限</color>
public const ushort ERR_GUILD_BOSS_NOT_START = 2516; //<color=#fa1e1e>帮派BOSS未开启</color>
public const ushort ERR_GUILD_BOSS_SNUM_LIMIT = 2517; //<color=#fa1e1e>每天只能参加两场帮派BOSS，请期待下次活动</color>
public const ushort ERR_GUILD_BOSS_OPEN_LIMIT = 2518; //<color=#fa1e1e>只有帮主或副帮主有权限开启副本</color>
public const ushort ERR_GUILD_LEAGUE_STONE_REFRESH = 2520; //小矿石已刷新
public const ushort ERR_GUILD_LEAGUE_NOT_START = 2521; //不在联赛时间内
public const ushort ERR_GUILD_LEAGUE_NOT_OPEN = 2522; //联赛战场将于21:00开启
public const ushort ERR_GUILD_LEAGUE_CLOSE = 2523; //本轮联赛对战已结束
public const ushort ERR_GUILD_LEAGUE_STOP = 2524; //联赛已结束
public const ushort ERR_GUILD_LEAGUE_NOT_IN = 2525; //您所在的帮派没有参赛资格
public const ushort ERR_GUILD_LEAGUE_JOIN_TIME_LIMIT = 2526; //您加入帮派时间不足2小时，无法参与联赛对战
public const ushort ERR_GUILD_LEAGUE_REWARD_JOIN_TIME_LIMIT = 2527; //您加入帮派时间不足2小时，无法领取俸禄
public const ushort ERR_GUILD_LEAGUE_PRIME_GIVE_NOTE = 2528; //分配成功，奖励已通过邮件发放
public const ushort ERR_GUILD_LEAGUE_PRIME_NOT_MEMBER = 2529; //该玩家已不是帮派成员
public const ushort ERR_GUILD_LEAGUE_LEAVE_TEAM = 2530; //队伍中有敌对阵营玩家，已自动退出队伍
public const ushort ERR_GUILD_CHANGE_NOT_IN_LEAGUE = 2531; //进行完帮派联赛再来改名吧
public const ushort ERR_GUILD_WARE_DONATE_SUCC = 2540; //捐献成功
public const ushort ERR_GUILD_WARE_DONATE_FAIL = 2541; //捐献失败，帮派仓库格子不足
public const ushort ERR_GUILD_WARE_EXCHANGE_NOTHING = 2542; //兑换物品不存在
public const ushort ERR_GUILD_WARE_EXCHANGE_WPOINT_LIMIT = 2543; //仓库点数不足
public const ushort ERR_GUILD_WARE_DESTROY_SUCC = 2544; //销毁成功
public const ushort ERR_GUILD_WARE_NO_GOODS = 2545; //该物品不在背包中，无法捐献
public const ushort ERR_GUILD_REDPACK_DISPATCHED = 2551; //红包已经派发过了
public const ushort ERR_GUILD_REDPACK_NOT_EXIST = 2552; //红包不存在或已经过期
public const ushort ERR_TRIAL_BOSS_INSPIRE_LIMIT = 2591; //已达鼓舞上限
public const ushort ERR_TRIAL_BOSS_NOT_ALL_PASS = 2582; //上一等级试炼未全部通关
public const ushort ERR_PEAK_TRIAL_BOSS_NOT_READY = 2585; //未达到巅峰BOSS开启条件
public const ushort ERR_PEAK_TRIAL_BOSS_IS_OPEN = 2586; //已经开巅峰BOSS, 无法再进入试炼BOSS
public const ushort ERR_WELFARE_NOT_MEET_CONDITION = 2601; //领取福利，条件未满足
public const ushort ERR_WELFARE_BAG_FULL = 2602; //<color=#fa1e1e>背包空间不足，请清理背包后再签到</color>
public const ushort ERR_NOT_VIP = 2701; //您还不是VIP玩家
public const ushort ERR_SYS_FRUIT_NOT_OPEN = 2801; //圣果系统未开启
public const ushort ERR_USER_NUM_OVER = 2802; //已达到次数上限，请先提升头衔等级
public const ushort ERR_USER_DAY_NUM_OVER = 2803; //今日次数用完了，明天接着使用吧
public const ushort ERR_USER_NUM_NOT_ENOUGH = 2804; //使用数量超出次数上限
public const ushort ERR_DAY_USER_NUM_NOT_ENOUGH = 2805; //使用数量超出今日上限
public const ushort ERR_MARKET_CANNOT_SELL = 2901; //该物品不可出售
public const ushort ERR_MARKET_CANNOT_RECALL = 2902; //商品下架失败，物品可能已被购买
public const ushort ERR_MARKET_RECALL_FAIL = 2903; //下架失败，物品可能已被购买或已下架
public const ushort ERR_MARKET_CANNOT_BUY = 2904; //<color=#fa1e1e>商品已下架或被购买</color>
public const ushort ERR_MARKET_BUY_FAIL = 2905; //<color=#fa1e1e>商品已下架或被购买</color>
public const ushort ERR_MARKET_GOODS_NOT_EXIST = 2906; //<color=#fa1e1e>商品已下架或被购买</color>
public const ushort ERR_MARKET_INVALID_FILTER = 2907; //无效的筛选条件
public const ushort ERR_MARKET_NOT_IN_BAG = 2910; //该物品不在背包中，不可以上架
public const ushort ERR_MARKET_BAG_FULL = 2915; //背包已满，您购买的物品已经邮件发送给您
public const ushort ERR_MARKET_DISABLE_BUY = 2916; //您的角色不可以在市场中购买物品
public const ushort ERR_MARKET_PASS_ERROR = 2918; //交易密码错误
public const ushort ERR_MARKET_PASS_BAN = 2919; //您连续输错3次密码，半小时内不能购买需要密码的物品
public const ushort ERR_MARKET_PASS_NOT_VIP = 2920; //需要VIP4以上才可以设置交易密码
public const ushort ERR_MARKET_DISABLE_SELL = 2921; //您的角色不可以在市场中出售物品
public const ushort ERR_MARKET_SELL_LIMIT = 2923; //超出该物品今日可上架数量上限
public const ushort ERR_MARKET_BUY_VIP_LIMIT = 2925; //超出市场消费额度，请提升VIP等级再来购买
public const ushort ERR_MARKET_BUY_DAILY_LIMIT = 2926; //超出市场每日消费额度
public const ushort ERR_EXP_JADE_NOT_FULL = 3000; //请先储存满经验玉
public const ushort ERR_SOUTH_LAND_TIME_NOT_ENOUGH = 3100; //本日已达最大进入次数
public const ushort ERR_SOUTH_LAND_NUM_NOT_ENOUGH = 3101; //当前副本已达人数上限！请稍后再来
public const ushort ERR_DAILY_PRAY_TIMES_LIMIT = 3200; //当前祈福次数已达上限
public const ushort ERR_DECORATE_NOT_ENOUGH = 3300; //使用次数达到上限
public const ushort ERR_DECORATE_POS_NOT_OPEN = 3301; //部位还未开启
public const ushort ERR_ARENA_CANNOT_MATCH = 3400; //当前场景不允许匹配
public const ushort ERR_REWARD_ALREADY_GET = 3410; //奖励已领取
public const ushort ERR_HAS_THE_TITLE = 3411; //使用失败，不能重复激活已获得的称号
public const ushort ERR_TREASURE_HUNT_BAG_FULL = 3420; //寻宝仓库空间不足
public const ushort ERR_TREASURE_HUNT_NOTHING = 3421; //没有物品可取回
public const ushort ERR_SUPER_HUNT_BAG_FULL = 3422; //至尊寻宝仓库空间不足
public const ushort ERR_TALENT_ACTIVATE = 3430; //无法激活该天赋
public const ushort ERR_TALENT_CANCEL = 3431; //中间天赋不能被洗点
public const ushort ERR_BUY_GID_NOT_EXIST = 3440; //限购商品已刷新，购买失败
public const ushort ERR_BUY_BARGAIN_IS_CLOSE = 3441; //超值限购活动已结束，购买失败
public const ushort ERR_ZERO_GIFT_BUY_CLOSE = 3450; //活动已结束，购买失败
public const ushort ERR_ZERO_GIFT_NOT_LEVEL = 3451; //等级不足，领取失败
public const ushort ERR_SPECIAL_GIFT_TIMEOUT = 3460; //特惠礼包活动已过期
public const ushort ERR_SPECIAL_GIFT_BUYED = 3461; //已购买特惠礼包
public const ushort ERR_BATTLE_FIELD_CANT_RERANGE = 3470; //排名过高，无法更换挑战目标
public const ushort ERR_BATTLE_FIELD_CANT_CHANLLENGE = 3471; //当前场景无法进入竞技场，请退出场景后重试
public const ushort ERR_LIMIT_SALE_SELLOUT = 3480; //购买失败，物品已售罄
public const ushort ERR_LIMIT_SALE_CLOSED = 3481; //购买失败，活动已关闭
public const ushort ERR_LIMIT_SALE_NO_SHOP = 3482; //没有此类型抢购商店
public const ushort ERR_LIMIT_SALE_NO_GOOD = 3483; //购买失败，商店已刷新
public const ushort ERR_GOD_EQUIP_POS_NOT_OPEN = 3490; //神兵部位未开启
public const ushort ERR_TASK_ESCORT_DOING = 3500; //当前处于护送状态，请先完成护送任务
public const ushort ERR_TASK_ESCORT_TEAM_DOING = 3501; //当前处于护送状态中
public const ushort ERR_GUILD_CREATION_GLOBAL_LIMIT = 3510; //领取失败，奖励已被领完
public const ushort ERR_GUILD_CREATION_NOT_FIN = 3511; //领取失败，任务未完成
public const ushort ERR_GUILD_CREATION_NOT_OPEN = 3512; //领取失败，活动已结束
public const ushort ERR_SHOWS_SALE_PRIV_SALEOUT = 3520; //购买失败，你已经没有购买次数
public const ushort ERR_SHOWS_SALE_SALEOUT = 3521; //购买失败，物品已售罄
public const ushort ERR_SHOWS_SALE_NOT_OPEN = 3522; //外观抢购活动已结束
public const ushort ERR_SHOWS_SALE_BAG_FULL = 3523; //背包已满，购买的物品已由邮件发放
public const ushort ERR_BING_GOLD_BOX_GOT = 3531; //您今天已经领取过了
public const ushort ERR_BING_GOLD_BOX_BUY_OK = 3532; //宝箱购买成功
public const ushort ERR_PAY_RED_MAX_TIMES = 3540; //今日可领取的红包次数已用光
public const ushort ERR_PAY_RED_TIME_UP = 3541; //手慢了，豪气红包已过期
public const ushort ERR_PAY_RED_EMPTY = 3542; //手慢了，豪气红包已派完
public const ushort ERR_PAY_RED_HAD_GOT = 3543; //此红包已领取过
public const ushort ERR_PAY_RED_NOT_EXIST = 3544; //红包id不存在
public const ushort ERR_PAY_RED_HAD_SEND = 3545; //该红包已发过
public const ushort ERR_PAY_RED_NOT_SEND = 3546; //该红包还没发放
public const ushort ERR_PAY_RED_TIPS_NO_DIY = 3547; //您的红包祝福已自动生成
public const ushort ERR_PAY_RED_TIPS_NO_INVALID = 3548; //红包祝福语超长
public const ushort ERR_PAY_RED_SEND_TIME_UP = 3549; //改红包已超时自动发放
public const ushort ERR_MARRY_CANNOT_RESERVED = 3601; //该时间段已被预约
public const ushort ERR_MARRY_NOT_RESERVED = 3602; //还没有预约宴席
public const ushort ERR_MARRY_BUY_GUEST_OVERFLOW = 3603; //邀请人数超过上限
public const ushort ERR_MARRY_BEG_REPEAT = 3604; //您已索要过请贴了
public const ushort ERR_MARRY_ALREADY_INVITED = 3605; //您已获得请贴
public const ushort ERR_MARRY_BEG_OK = 3606; //已向主人索取请贴
public const ushort ERR_MARRY_SESSION_NOT_FOUND = 3607; //宴席不存在
public const ushort ERR_MARRY_BEG_TOO_MUCH = 3608; //您已索要过请贴了，请勿频繁操作
public const ushort ERR_MARRY_INVITE_TOO_MANY = 3609; //邀请人数达到上限
public const ushort ERR_MARRY_TARGET_HAD_DO_PROPOSE = 3610; //对方已向别人发起结缘请求
public const ushort ERR_MARRY_PROPOSE_STRANGER = 3611; //好友亲密度不够
public const ushort ERR_MARRY_PROPOSE_OFFLINE = 3612; //对方不在线
public const ushort ERR_MARRY_TIMEOUT = 3613; //结缘请求已超时
public const ushort ERR_MARRY_HAD_DO_PROPOSE = 3614; //您已向别人发起结缘请求
public const ushort ERR_MARRY_HAD_BE_PROPOSE = 3615; //您已被发起结缘请求
public const ushort ERR_MARRY_YOU_MARRIED = 3616; //您已经结缘
public const ushort ERR_MARRY_TARGET_MARRIED = 3617; //请求对象已经结缘
public const ushort ERR_MARRY_PROPOSE_ERROR = 3618; //结缘请求有误
public const ushort ERR_MARRY_TARGET_HAD_BE_PROPOSE = 3619; //对方已被发起结缘请求
public const ushort ERR_MARRY_PROPOSE_DIVORCING = 3620; //您处于断缘状态，无法求缘
public const ushort ERR_MARRY_DIVORCE_REQ_CD = 3621; //断缘申请太频繁，请稍后再试
public const ushort ERR_MARRY_DIVORCE_RESERVING = 3622; //预约宴席未结束前，无法断缘
public const ushort ERR_MARRY_DIVORCE_DOING = 3623; //当前已有断缘申请，请勿重复申请
public const ushort ERR_MARRY_DIVORCE_MATE_OFFLINE = 3624; //您的情缘当前不在线
public const ushort ERR_MARRY_DIVORCE_HAD_AGREE = 3625; //您已同意当前断缘申请
public const ushort ERR_MARRY_DIVORCE_NOT_RE_ACK_TIME = 3626; //当前非二次确认断缘时段
public const ushort ERR_MARRY_DIVORCE_NOT_EXIST = 3627; //当前没有断缘申请
public const ushort ERR_MARRY_DIVORCE_HAD_RE_ACK = 3628; //您已向对方提出确认断缘
public const ushort ERR_MARRY_DIVORCE_TIMEOUT = 3629; //当前断缘申请已超时
public const ushort ERR_MARRY_HAD_DO_DIVORCE = 3630; //您已向对方提出断缘申请
public const ushort ERR_MARRY_HAD_BE_DIVORCE = 3631; //您的配偶已向您提出断缘申请
public const ushort ERR_MARRY_DIVORCE_TARGET_HAD_RE_ACK = 3632; //对方已向您提出确认断缘
public const ushort ERR_MARRY_WEDDING_FULL = 3637; //宴席参与人数过多，暂时无法进入
public const ushort ERR_MARRY_BEG_REJECTED = 3638; //宴席主人拒绝向您发送请贴
public const ushort ERR_MARRY_MATE_OFFLINE = 3641; //您的情缘已下线
public const ushort ERR_MARRY_DUNGEON_LOVE_APPLY_BUY = 3642; //已向情缘请求购买情缘副本次数
public const ushort ERR_MARRY_DUNGEON_LOVE_ALREADY_BUY = 3643; //您的情缘已为您购买1次情缘副本次数
public const ushort ERR_MARRY_MATE_BOSS_HOME = 3651; //您的情缘当前在boss之家，您的vip等级不够，不能进入
public const ushort ERR_MARRY_MATE_CANT_REACH = 3652; //您的情缘所在地图不可传送
public const ushort ERR_DUNGEON_WEDDING_FOODS_NOT_ENOUGH = 3655; //食物采集已达上限
public const ushort ERR_DUNGEON_WEDDING_BOX_NOT_ENOUGH = 3656; //本轮宝箱采集已达上限，下一轮再来采集
public const ushort ERR_MARRY_PERFIT_CLOSED = 3661; //活动已结束
public const ushort ERR_FLOWER_SENDER_LV_LIMIT = 3701; //送花需要达到85级
public const ushort ERR_FLOWER_RECEIVER_LV_LIMIT = 3702; //对方未达85级，不可给ta送花
public const ushort ERR_FLOWER_SENDER_IN_BLACK = 3703; //您在对方黑名单中，不可送花
public const ushort ERR_FLOWER_RECEIVER_IN_BLACK = 3704; //不可给黑名单中的玩家送花
public const ushort ERR_FLOWER_RECEIVER_OFFLINE = 3705; //对方不在线
public const ushort ERR_LIGHT_EQUIP_NOT_OPEN = 3801; //当前光武未激活
public const ushort ERR_LIGHT_EQUIP_NO_CFG = 3802; //光武类型有误
public const ushort ERR_LIGHT_EQUIP_GRADE_NO_ENOUGH = 3803; //请突破后再升级当前光武
public const ushort ERR_LIGHT_EQUIP_SOUL_POS_NOT_MATCH = 3804; //神魂穿戴孔位不匹配
public const ushort ERR_LIGHT_EQUIP_NO_SOUL = 3805; //背包找不到对应的神魂
public const ushort ERR_LIGHT_EQUIP_SOUL_MAX_LV = 3806; //当前神魂已达最高等级
public const ushort ERR_LIGHT_EQUIP_POS_NO_SOUL = 3807; //当前孔位没有穿戴神魂
public const ushort ERR_LIGHT_SOUL_MONEY_NOT_ENOUGH = 3808; //魂魄数量不足
public const ushort ERR_LIGHT_NO_SOUL_CFG = 3809; //神魂类型有误
public const ushort ERR_LIGHT_EQUIP_UNLOCK_BAG_FULL = 3810; //背包已满，请清理背包再领取奖励
public const ushort ERR_LIGHT_EQUIP_STAR_FULL = 3811; //光武升星已达上限
public const ushort ERR_LIMIT_SALE_LE_SELLOUT = 3901; //购买失败，物品已售罄
public const ushort ERR_LIMIT_SALE_LE_CLOSED = 3902; //购买失败，活动已关闭
public const ushort ERR_LIMIT_SALE_LE_NO_SHOP = 3903; //没有此类型抢购商店
public const ushort ERR_LIMIT_SALE_LE_NO_GOOD = 3904; //购买失败，商店已刷新
public const ushort ERR_SPAN_NOT_OPEN = 4001; //世界服未开启
public const ushort ERR_MSHOP_OUT = 4101; //商店已刷新, 请重新购买
public const ushort ERR_ID_TREASURE_END = 4110; //活动已结束，未领取的奖励已由邮件发放
public const ushort ERR_ID_TREASURE_END2 = 4111; //活动已结束
public const ushort ERR_DECOMPOSE_SUC = 4120; //拆解成功
public const ushort ERR_EQUIP_ENGRAVE_OUT_DOWNENS = 4130; //已自动拆解全部纹晶并放入背包
public const ushort ERR_EQUIP_ENGRAVE_CHANGE_NODOWNENS = 4131; //已自动转移全部纹晶
public const ushort ERR_EQUIP_ENGRAVE_CHANGE_DOWNENS = 4132; //已自动转移部分纹晶，多出的纹晶已放入背包
public const ushort ERR_LIMIT_BUY_WUYONG_NO = 4135; //无法购买此礼包
public const ushort ERR_PEAK_3P_NO_TIMES = 4140; //巅峰竞技挑战次数不足
public const ushort ERR_PEAK_3P_IN_MATCH = 4141; //正在巅峰竞技匹配中
public const ushort ERR_PEAK_3P_NO_MATCH = 4142; //不在匹配中
public const ushort ERR_PEAK_3P_CHECK_TIMEOUT = 4143; //等待检查进入匹配超时
public const ushort ERR_PEAK_3P_MEMBER_NOT_LOCAL = 4144; //队伍中有非本服玩家，无法进行匹配
public const ushort ERR_PEAK_3P_MEMBER_OFFLINE = 4145; //已离线，无法进行匹配
public const ushort ERR_PEAK_3P_MUST_LEADER = 4146; //您不是队长，无法进行匹配
public const ushort ERR_PEAK_3P_IN_BAN_SCENE = 4147; //处于特殊场景，无法进行匹配
public const ushort ERR_PEAK_3P_MATCH_NO_CLAN = 4148; //还没创建或加入战队，无法匹配
public const ushort ERR_PEAK_3P_MATCH_SINGLE_IN_TEAM = 4149; //您在队伍中，请退出队伍再开始匹配
public const ushort ERR_SGB_APPOINT_SUCCESS = 4150; //预约成功
public const ushort ERR_SGB_APPOINT_STATE_ERR = 4151; //该帮派预约状态已改变，请重新预约
public const ushort ERR_SGB_APPOINT_SCORE_LIMIT = 4152; //积分不足，无法抢夺预约
public const ushort ERR_SGB_APPOINT_LEADER_LIMIT = 4153; //只有帮主可以做预约操作
public const ushort ERR_PEAK_CLAN_TIME_LIMIT_LEVEL = 4160; //当前是赛季最后7天内，无法解散战队
public const ushort ERR_PEAK_CLAN_TIME_LIMIT_DISMISS = 4161; //当前是赛季最后7天内，无法踢出成员
public const ushort ERR_PEAK_CLAN_FULL_INVERT = 4162; //战队成员已满，无法邀请
public const ushort ERR_PEAK_CLAN_NOT_ONLINE_INVERT = 4163; //对方不在线，无法邀请
public const ushort ERR_PEAK_CLAN_HAVE_CLAN_INVERT = 4164; //对方已有战队，无法邀请
public const ushort ERR_PEAK_CLAN_NAME_EXIST = 4165; //战队名已存在
public const ushort ERR_PEAK_CLAN_NAME_LEN_LIMIT = 4166; //战队名过长
public const ushort ERR_PEAK_CLAN_NOT_EXIST_ACCEPT = 4167; //对方战队已解散，无法接受
public const ushort ERR_PEAK_CLAN_PERSON_FULL_ACCEPT = 4168; //对方战队已满员，无法加入
public const ushort ERR_PEAK_CLAN_NAME_ILLEGAL = 4169; //存在违规文字，无法创建战队
public const ushort ERR_PEAK_CLAN_CHANGE_NAME_SUCC = 4170; //战队改名成功
public const ushort ERR_PEAK_CLAN_APPROVE_FULL = 4171; //战队已满员
public const ushort ERR_PEAK_CLAN_APPROVE_HAS_CLAN = 4172; //对方已有战队
public const ushort ERR_PEAK_CLAN_ACT_LIMIT_DISMISS = 4173; //活动进行中，无法进行此操作
public const ushort ERR_PEAK_3P_BUY_COUNT_OK = 4174; //购买成功，挑战次数+1
public const ushort ERR_PEAK_CLAN_NOT_EXIST = 4175; //战队已解散
public const ushort ERR_PEAK_CLAN_HAS_CLAN = 4176; //您已有战队
public const ushort ERR_DUNGEON_MELEE_WAR_CLOSE = 4190; //您已参加过本次副本
public const ushort ERR_DUNGEON_MELEE_INVALID_GAME = 4191; //加入乱斗房间出错
public const ushort ERR_DUNGEON_MELEE_HAD_ROOM = 4192; //已加入乱斗副本房间
public const ushort ERR_DUNGEON_MELEE_HAD_FIN = 4193; //您已参加过本次副本
public const ushort ERR_ALL_SUBMIT_NO_IN_TIME = 4195; //每天00:00-06:00不能进行提交
public const ushort ERR_FAIRY_RELIC_ENTER_MAX = 4201; //仙陨遗迹进入次数不足
public const ushort ERR_FAIRY_RELIC_NO_TICKET = 4202; //仙陨遗迹门票不足
public const ushort ERR_FAIRY_RELIC_NO_HURT = 4203; //疲劳度已满，无法对BOSS造成伤害，提升VIP等级可提升疲劳度上限
public const ushort ERR_FAIRY_RELIC_NO_HURT_TOP = 4204; //今日疲劳度已满，无法对BOSS造成伤害
public const ushort ERR_LIMIT_SALE_SPAN_SELLOUT = 4301; //购买失败，物品已售罄
public const ushort ERR_LIMIT_SALE_SPAN_CLOSED = 4302; //购买失败，活动已关闭
public const ushort ERR_LIMIT_SALE_SPAN_NO_SHOP = 4303; //没有此类型抢购商店
public const ushort ERR_LIMIT_SALE_SPAN_NO_GOOD = 4304; //购买失败，商店已刷新
public const ushort ERR_FIVE_ELEM_NOEXIST = 4310; //战印不存在
public const ushort ERR_FIVE_ELEM_UP_ERR = 4311; //穿戴条件不足
public const ushort ERR_FIVE_ELEM_BAG_FULL = 4312; //战印背包已满，请及时清理
public const ushort ERR_FIVE_ELEM_UP_NONE = 4313; //请先穿戴战印
public const ushort ERR_FIVE_ELEM_STREN_MAX = 4314; //强化等级已满
public const ushort ERR_FIVE_ELEM_SOUL_LACK = 4315; //精魄不足
public const ushort ERR_FIVE_ELEM_TRAIN_MAX = 4316; //培养已满
public const ushort ERR_FIVE_ELEM_TRAIN_ITEM_LACK = 4317; //培养物品不足
public const ushort ERR_FIVE_ELEM_COMPOSE_DEL_FAIL = 4318; //合成扣除失败
public const ushort ERR_FIVE_ELEM_RESOLVE_EXP_LACK = 4319; //不可分解
public const ushort ERR_FIVE_ELEM_RESOLVE_DEL_FAIL = 4320; //分解扣除失败
public const ushort ERR_FIVE_ELEM_DECOMPOSE_DEL_FAIL = 4321; //拆解扣除失败
public const ushort ERR_GOD_DEMON_DUEL_CLOSE = 4330; //不在副本开启时间
public const ushort ERR_GOD_DEMON_DUEL_ROOM_CLOSE = 4331; //活动开启超过15分钟，无法进入
public const ushort ERR_GOD_DEMON_DUEL_ROOM_END = 4332; //您已参加过本次副本
public const ushort ERR_GOD_DEMON_DUEL_ALREADY_IN = 4333; //您已经在神魔对决场景中了
public const ushort ERR_PET_EQUIP_NOT_EXIST = 4340; //不存在的守护装备
public const ushort ERR_PET_EQUIP_BAG_FULL = 4341; //守护装备背包已满
public const ushort ERR_PET_EQUIP_STREN_MAX = 4342; //守护装备强化等级已满
public const ushort ERR_PET_EQUIP_MAGIC_MAX = 4343; //守护装备附魔等级已满
public const ushort ERR_PET_EQUIP_SPLIT_NOT_EXIST = 4344; //分解装备在背包中不存在
public const ushort ERR_PET_EQUIP_COMPOSE_NOT_EXIST = 4345; //错误的合成装备ID
public const ushort ERR_PET_EQUIP_STREN_LACK = 4346; //强化材料不足
public const ushort ERR_PET_EQUIP_MAGIC_LACK = 4347; //附魔材料不足
public const ushort ERR_PET_EQUIP_COMPOSE_LACK = 4348; //合成材料不足
public const ushort ERR_PET_EQUIP_SPLIT_LACK = 4349; //双倍分解元宝不够
public const ushort ERR_PET_EQUIP_BAG_FULL_MAIL = 4350; //守护背包已满，奖励已通过邮件发放
public const ushort ERR_EQUIP_SHAPE_REFINE_ERR = 4355; //炼形失效或等级不足
public const ushort ERR_EQUIP_SHAPE_REFINE_MAX = 4356; //炼形等级已满
public const ushort ERR_EQUIP_SHAPE_REFINE_CON_ERR = 4357; //炼形条件不足
public const ushort ERR_EQUIP_QUENCH_SPIRITS_MAX = 4358; //淬神等级已满
public const ushort ERR_TIME_LIMIT_BUY_MAX = 4360; //购买次数已达上限
public const ushort ERR_HONORABLE_GIFT_USE_MAX = 4365; //该礼包今日可开启次数已达上限，请明日再开启
public const ushort ERR_MATERIAL_BAG_FULL = 4370; //材料背包已满
public const ushort ERR_MATERIAL_NOT_EXIST = 4371; //材料在背包中不存在
public const ushort ERR_MATERIAL_FULL_MAIL = 4372; //材料背包已满，道具已通过邮件发放
public const ushort ERR_HOLY_EQUIP_NOT_EXIST = 4380; //不存在的圣装
public const ushort ERR_HOLY_EQUIP_BAG_FULL = 4381; //圣装背包已满
public const ushort ERR_HOLY_EQUIP_BAG_FULL_MAIL = 4382; //圣装背包已满，奖励已通过邮件发放
public const ushort ERR_SAINT_BEAST_NOT_OPEN = 4390; //圣兽之域没有开启
public const ushort ERR_SAINT_BEAST_WRONG_TEAMATE = 4391; //队伍存在其他帮派的成员，无法进入圣兽之域场景
public const ushort ERR_SAINT_BEAST_CALLED = 4392; //短时间能不能重复召唤
public const ushort ERR_SAINT_BEAST_LOCKED = 4393; //活动已开启4分钟，无法切换圣兽之域场景
public const ushort ERR_SAINT_BEAST_CALLTIME_LIMIT = 4394; //本次活动召集次数为0，无法使用召集功能
public const ushort ERR_SAINT_BEAST_NOT_EXIST = 4395; //圣兽副本ID错误
public const ushort ERR_SAINT_NOT_PASSED_PRE = 4396; //您的帮派未获得传送门归属权，无法使用传送门传送至麒麟圣域
public const ushort ERR_SAINT_WRONG_TEAM_MEMBER = 4397; //队伍存在其他帮派的成员，无法进入圣兽之域场景
public const ushort ERR_SAINT_NOT_GUILD_MEMBER = 4398; //圣兽之域中无法与其他帮派的成员进行组队
public const ushort ERR_SAINT_CANOT_EXIT_GUILD = 4399; //圣兽之域中无法退出帮派
public const ushort ERR_CUMULATIVE_LOGIN_RESIGN_ERR = 4400; //活动已跨天刷新，请重新确认是否补签
public const ushort ERR_TEMPORARY_BAG_FULL = 4410; //临时背包空间不足，请及时领取临时背包的物品
public const ushort ERR_FORSAKEN_NOT_OPEN = 4420; //遗忘战谷没有开启
public const ushort ERR_FORSAKEN_CANOT_FIND_BACK = 4421; //无法找回战谷资源
public const ushort ERR_SAME_CAREER = 4430; //职业相同，无需转职
public const ushort ERR_CHANGE_CAREER_CD = 4431; //转职CD中
public const ushort ERR_PREVIEW_NOT_OPEN = 4440; //新功能预告没有开启
public const ushort ERR_PREVIEW_ANSWER_ERROR = 4441; //错误的答题信息
public const ushort ERR_PREVIEW_FINISHED = 4442; //没有答题次数
}}

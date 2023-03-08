﻿/** 命名规范
 * 1. 类型名使用大驼峰命名法，不使用下划线分隔。
 * 2. 字段以下划线 _ 开头，使用下划线分隔每个单词。
 * 3. 局部变量不以下划线 _ 开头，使用下划线分隔每个单词。
 * 4. 属性、方法使用大驼峰命名法。
 * 5. 委托类型名使用 F_ 开头，后续使用大驼峰命名法。
 *	  委托变量使用 f_ 开头，后续使用大驼峰命名法。
 */

namespace ModulatorLib
{
	/// <summary>
	/// 结构体，储存：信道、频率
	/// </summary>
	public struct ChFre
	{
		public int Channel;//信道
		public double Frequency;//频率
	}

	public class ST7000Database
	{
		public static ChFre[] Ch_Fre_List = new ChFre[]
				{
					new ChFre { Channel = 2, Frequency = 57.0 },
					new ChFre { Channel = 3 , Frequency = 63.0 },
					new ChFre { Channel = 4 , Frequency = 69.0 },
					new ChFre { Channel = 5 , Frequency = 79.0 },
					new ChFre { Channel = 6 , Frequency = 85.0 },
					new ChFre { Channel = 7 , Frequency = 177.0 },
					new ChFre { Channel = 8 , Frequency = 183.0 },
					new ChFre { Channel = 9 , Frequency = 189.0 },
					new ChFre { Channel = 10 , Frequency = 195.0 },
					new ChFre { Channel = 11 , Frequency = 201.0 },
					new ChFre { Channel = 12 , Frequency = 207.0 },
					new ChFre { Channel = 13 , Frequency = 213.0 },
					new ChFre { Channel = 14 , Frequency = 123.0 },
					new ChFre { Channel = 15 , Frequency = 129.0 },
					new ChFre { Channel = 16 , Frequency = 135.0 },
					new ChFre { Channel = 17 , Frequency = 141.0 },
					new ChFre { Channel = 18 , Frequency = 147.0 },
					new ChFre { Channel = 19 , Frequency = 153.0 },
					new ChFre { Channel = 20 , Frequency = 159.0 },
					new ChFre { Channel = 21 , Frequency = 165.0 },
					new ChFre { Channel = 22 , Frequency = 171.0 },
					new ChFre { Channel = 23 , Frequency = 219.0 },
					new ChFre { Channel = 24 , Frequency = 225.0 },
					new ChFre { Channel = 25 , Frequency = 231.0 },
					new ChFre { Channel = 26 , Frequency = 237.0 },
					new ChFre { Channel = 27 , Frequency = 243.0 },
					new ChFre { Channel = 28 , Frequency = 249.0 },
					new ChFre { Channel = 29 , Frequency = 255.0 },
					new ChFre { Channel = 30 , Frequency = 261.0 },
					new ChFre { Channel = 31 , Frequency = 267.0 },
					new ChFre { Channel = 32 , Frequency = 273.0 },
					new ChFre { Channel = 33 , Frequency = 279.0 },
					new ChFre { Channel = 34 , Frequency = 285.0 },
					new ChFre { Channel = 35 , Frequency = 291.0 },
					new ChFre { Channel = 36 , Frequency = 297.0 },
					new ChFre { Channel = 37 , Frequency = 303.0 },
					new ChFre { Channel = 38 , Frequency = 309.0 },
					new ChFre { Channel = 39 , Frequency = 315.0 },
					new ChFre { Channel = 40 , Frequency = 321.0 },
					new ChFre { Channel = 41 , Frequency = 327.0 },
					new ChFre { Channel = 42 , Frequency = 333.0 },
					new ChFre { Channel = 43 , Frequency = 339.0 },
					new ChFre { Channel = 44 , Frequency = 345.0 },
					new ChFre { Channel = 45 , Frequency = 351.0 },
					new ChFre { Channel = 46 , Frequency = 357.0 },
					new ChFre { Channel = 47 , Frequency = 363.0 },
					new ChFre { Channel = 48 , Frequency = 369.0 },
					new ChFre { Channel = 49 , Frequency = 375.0 },
					new ChFre { Channel = 50 , Frequency = 381.0 },
					new ChFre { Channel = 51 , Frequency = 387.0 },
					new ChFre { Channel = 52 , Frequency = 393.0 },
					new ChFre { Channel = 53 , Frequency = 399.0 },
					new ChFre { Channel = 54 , Frequency = 405.0 },
					new ChFre { Channel = 55 , Frequency = 411.0 },
					new ChFre { Channel = 56 , Frequency = 417.0 },
					new ChFre { Channel = 57 , Frequency = 423.0 },
					new ChFre { Channel = 58 , Frequency = 429.0 },
					new ChFre { Channel = 59 , Frequency = 435.0 },
					new ChFre { Channel = 60 , Frequency = 441.0 },
					new ChFre { Channel = 61 , Frequency = 447.0 },
					new ChFre { Channel = 62 , Frequency = 453.0 },
					new ChFre { Channel = 63 , Frequency = 459.0 },
					new ChFre { Channel = 64 , Frequency = 465.0 },
					new ChFre { Channel = 65 , Frequency = 471.0 },
					new ChFre { Channel = 66 , Frequency = 477.0 },
					new ChFre { Channel = 67 , Frequency = 483.0 },
					new ChFre { Channel = 68 , Frequency = 489.0 },
					new ChFre { Channel = 69 , Frequency = 495.0 },
					new ChFre { Channel = 70 , Frequency = 501.0 },
					new ChFre { Channel = 71 , Frequency = 507.0 },
					new ChFre { Channel = 72 , Frequency = 513.0 },
					new ChFre { Channel = 73 , Frequency = 519.0 },
					new ChFre { Channel = 74 , Frequency = 525.0 },
					new ChFre { Channel = 75 , Frequency = 531.0 },
					new ChFre { Channel = 76 , Frequency = 537.0 },
					new ChFre { Channel = 77 , Frequency = 543.0 },
					new ChFre { Channel = 78 , Frequency = 549.0 },
					new ChFre { Channel = 79 , Frequency = 555.0 },
					new ChFre { Channel = 80 , Frequency = 561.0 },
					new ChFre { Channel = 81 , Frequency = 567.0 },
					new ChFre { Channel = 82 , Frequency = 573.0 },
					new ChFre { Channel = 83 , Frequency = 579.0 },
					new ChFre { Channel = 84 , Frequency = 585.0 },
					new ChFre { Channel = 85 , Frequency = 591.0 },
					new ChFre { Channel = 86 , Frequency = 597.0 },
					new ChFre { Channel = 87 , Frequency = 603.0 },
					new ChFre { Channel = 88 , Frequency = 609.0 },
					new ChFre { Channel = 89 , Frequency = 615.0 },
					new ChFre { Channel = 90 , Frequency = 621.0 },
					new ChFre { Channel = 91 , Frequency = 627.0 },
					new ChFre { Channel = 92 , Frequency = 633.0 },
					new ChFre { Channel = 93 , Frequency = 639.0 },
					new ChFre { Channel = 94 , Frequency = 645.0 },
					new ChFre { Channel = 95 , Frequency = 93.0 },
					new ChFre { Channel = 96 , Frequency = 99.0 },
					new ChFre { Channel = 97 , Frequency = 105.0 },
					new ChFre { Channel = 98 , Frequency = 111.0 },
					new ChFre { Channel = 99 , Frequency = 117.0 },
					new ChFre { Channel = 100 , Frequency = 651.0 },
					new ChFre { Channel = 101 , Frequency = 657.0 },
					new ChFre { Channel = 102 , Frequency = 663.0 },
					new ChFre { Channel = 103 , Frequency = 669.0 },
					new ChFre { Channel = 104 , Frequency = 675.0 },
					new ChFre { Channel = 105 , Frequency = 681.0 },
					new ChFre { Channel = 106 , Frequency = 687.0 },
					new ChFre { Channel = 107 , Frequency = 693.0 },
					new ChFre { Channel = 108 , Frequency = 699.0 },
					new ChFre { Channel = 109 , Frequency = 705.0 },
					new ChFre { Channel = 110 , Frequency = 711.0 },
					new ChFre { Channel = 111 , Frequency = 717.0 },
					new ChFre { Channel = 112 , Frequency = 723.0 },
					new ChFre { Channel = 113 , Frequency = 729.0 },
					new ChFre { Channel = 114 , Frequency = 735.0 },
					new ChFre { Channel = 115 , Frequency = 741.0 },
					new ChFre { Channel = 116 , Frequency = 747.0 },
					new ChFre { Channel = 117 , Frequency = 753.0 },
					new ChFre { Channel = 118 , Frequency = 759.0 },
					new ChFre { Channel = 119 , Frequency = 765.0 },
					new ChFre { Channel = 120 , Frequency = 771.0 },
					new ChFre { Channel = 121 , Frequency = 777.0 },
					new ChFre { Channel = 122 , Frequency = 783.0 },
					new ChFre { Channel = 123 , Frequency = 789.0 },
					new ChFre { Channel = 124 , Frequency = 795.0 },
					new ChFre { Channel = 125 , Frequency = 801.0 },
					new ChFre { Channel = 126 , Frequency = 807.0 },
					new ChFre { Channel = 127 , Frequency = 813.0 },
					new ChFre { Channel = 128 , Frequency = 819.0 },
					new ChFre { Channel = 129 , Frequency = 825.0 },
					new ChFre { Channel = 130 , Frequency = 831.0 },
					new ChFre { Channel = 131 , Frequency = 837.0 },
					new ChFre { Channel = 132 , Frequency = 843.0 },
					new ChFre { Channel = 133 , Frequency = 849.0 },
					new ChFre { Channel = 134 , Frequency = 855.0 },
					new ChFre { Channel = 135 , Frequency = 861.0 },
					new ChFre { Channel = 136 , Frequency = 867.0 },
					new ChFre { Channel = 137 , Frequency = 873.0 },
					new ChFre { Channel = 138 , Frequency = 879.0 },
					new ChFre { Channel = 139 , Frequency = 885.0 },
					new ChFre { Channel = 140 , Frequency = 891.0 },
					new ChFre { Channel = 141 , Frequency = 897.0 },
					new ChFre { Channel = 142 , Frequency = 903.0 },
					new ChFre { Channel = 143 , Frequency = 909.0 },
					new ChFre { Channel = 144 , Frequency = 915.0 },
					new ChFre { Channel = 145 , Frequency = 921.0 },
					new ChFre { Channel = 146 , Frequency = 927.0 },
					new ChFre { Channel = 147 , Frequency = 933.0 },
					new ChFre { Channel = 148 , Frequency = 939.0 },
					new ChFre { Channel = 149 , Frequency = 945.0 },
					new ChFre { Channel = 150 , Frequency = 951.0 },
					new ChFre { Channel = 151 , Frequency = 957.0 },
					new ChFre { Channel = 152 , Frequency = 963.0 },
					new ChFre { Channel = 153 , Frequency = 969.0 },
					new ChFre { Channel = 154 , Frequency = 975.0 },
					new ChFre { Channel = 155 , Frequency = 981.0 },
					new ChFre { Channel = 156 , Frequency = 987.0 },
					new ChFre { Channel = 157 , Frequency = 993.0 },
					new ChFre { Channel = 158 , Frequency = 999.0 },
			};
	}
}

using Capnp;
using Capnp.Rpc;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Cereal
{
    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xf8b13ce2183eb696UL)]
    public class Map<TKey, TValue> : ICapnpSerializable where TKey : class where TValue : class
    {
        public const UInt64 typeId = 0xf8b13ce2183eb696UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            Entries = reader.Entries?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.Map<TKey, TValue>.Entry>(_));
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.Entries.Init(Entries, (_s1, _v1) => _v1?.serialize(_s1));
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public IReadOnlyList<Cereal.Map<TKey, TValue>.Entry> Entries
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public IReadOnlyList<Cereal.Map<TKey, TValue>.Entry.READER> Entries => ctx.ReadList(0).Cast(Cereal.Map<TKey, TValue>.Entry.READER.create);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(0, 1);
            }

            public ListOfStructsSerializer<Cereal.Map<TKey, TValue>.Entry.WRITER> Entries
            {
                get => BuildPointer<ListOfStructsSerializer<Cereal.Map<TKey, TValue>.Entry.WRITER>>(0);
                set => Link(0, value);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xa5dfdd084a6eea0eUL)]
        public class Entry : ICapnpSerializable
        {
            public const UInt64 typeId = 0xa5dfdd084a6eea0eUL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Key = CapnpSerializable.Create<TKey>(reader.Key);
                Value = CapnpSerializable.Create<TValue>(reader.Value);
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Key.SetObject(Key);
                writer.Value.SetObject(Value);
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public TKey Key
            {
                get;
                set;
            }

            public TValue Value
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public DeserializerState Key => ctx.StructReadPointer(0);
                public DeserializerState Value => ctx.StructReadPointer(1);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 2);
                }

                public DynamicSerializerState Key
                {
                    get => BuildPointer<DynamicSerializerState>(0);
                    set => Link(0, value);
                }

                public DynamicSerializerState Value
                {
                    get => BuildPointer<DynamicSerializerState>(1);
                    set => Link(1, value);
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xd692e23d1a247d99UL)]
    public enum LongitudinalPersonality : ushort
    {
        aggressive,
        standard,
        relaxed
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xe71008caeb3fb65cUL)]
    public class InitData : ICapnpSerializable
    {
        public const UInt64 typeId = 0xe71008caeb3fb65cUL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            KernelArgs = reader.KernelArgs;
            GctxDEPRECATED = reader.GctxDEPRECATED;
            DongleId = reader.DongleId;
            TheDeviceType = reader.TheDeviceType;
            Version = reader.Version;
            TheAndroidBuildInfo = CapnpSerializable.Create<Cereal.InitData.AndroidBuildInfo>(reader.TheAndroidBuildInfo);
            AndroidSensorsDEPRECATED = reader.AndroidSensorsDEPRECATED?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.InitData.AndroidSensor>(_));
            ChffrAndroidExtraDEPRECATED = CapnpSerializable.Create<Cereal.InitData.ChffrAndroidExtra>(reader.ChffrAndroidExtraDEPRECATED);
            ThePandaInfo = CapnpSerializable.Create<Cereal.InitData.PandaInfo>(reader.ThePandaInfo);
            Dirty = reader.Dirty;
            GitCommit = reader.GitCommit;
            GitBranch = reader.GitBranch;
            Passive = reader.Passive;
            GitRemote = reader.GitRemote;
            IosBuildInfoDEPRECATED = CapnpSerializable.Create<Cereal.InitData.IosBuildInfo>(reader.IosBuildInfoDEPRECATED);
            KernelVersion = reader.KernelVersion;
            AndroidProperties = CapnpSerializable.Create<Cereal.Map<string, string>>(reader.AndroidProperties);
            Params = CapnpSerializable.Create<Cereal.Map<string, IReadOnlyList<byte>>>(reader.Params);
            OsVersion = reader.OsVersion;
            Commands = CapnpSerializable.Create<Cereal.Map<string, IReadOnlyList<byte>>>(reader.Commands);
            WallTimeNanos = reader.WallTimeNanos;
            GitCommitDate = reader.GitCommitDate;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.KernelArgs.Init(KernelArgs);
            writer.GctxDEPRECATED = GctxDEPRECATED;
            writer.DongleId = DongleId;
            writer.TheDeviceType = TheDeviceType;
            writer.Version = Version;
            TheAndroidBuildInfo?.serialize(writer.TheAndroidBuildInfo);
            writer.AndroidSensorsDEPRECATED.Init(AndroidSensorsDEPRECATED, (_s1, _v1) => _v1?.serialize(_s1));
            ChffrAndroidExtraDEPRECATED?.serialize(writer.ChffrAndroidExtraDEPRECATED);
            ThePandaInfo?.serialize(writer.ThePandaInfo);
            writer.Dirty = Dirty;
            writer.GitCommit = GitCommit;
            writer.GitBranch = GitBranch;
            writer.Passive = Passive;
            writer.GitRemote = GitRemote;
            IosBuildInfoDEPRECATED?.serialize(writer.IosBuildInfoDEPRECATED);
            writer.KernelVersion = KernelVersion;
            AndroidProperties?.serialize(writer.AndroidProperties);
            Params?.serialize(writer.Params);
            writer.OsVersion = OsVersion;
            Commands?.serialize(writer.Commands);
            writer.WallTimeNanos = WallTimeNanos;
            writer.GitCommitDate = GitCommitDate;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public IReadOnlyList<string> KernelArgs
        {
            get;
            set;
        }

        public string GctxDEPRECATED
        {
            get;
            set;
        }

        public string DongleId
        {
            get;
            set;
        }

        public Cereal.InitData.DeviceType TheDeviceType
        {
            get;
            set;
        }

        public string Version
        {
            get;
            set;
        }

        public Cereal.InitData.AndroidBuildInfo TheAndroidBuildInfo
        {
            get;
            set;
        }

        public IReadOnlyList<Cereal.InitData.AndroidSensor> AndroidSensorsDEPRECATED
        {
            get;
            set;
        }

        public Cereal.InitData.ChffrAndroidExtra ChffrAndroidExtraDEPRECATED
        {
            get;
            set;
        }

        public Cereal.InitData.PandaInfo ThePandaInfo
        {
            get;
            set;
        }

        public bool Dirty
        {
            get;
            set;
        }

        public string GitCommit
        {
            get;
            set;
        }

        public string GitBranch
        {
            get;
            set;
        }

        public bool Passive
        {
            get;
            set;
        }

        public string GitRemote
        {
            get;
            set;
        }

        public Cereal.InitData.IosBuildInfo IosBuildInfoDEPRECATED
        {
            get;
            set;
        }

        public string KernelVersion
        {
            get;
            set;
        }

        public Cereal.Map<string, string> AndroidProperties
        {
            get;
            set;
        }

        public Cereal.Map<string, IReadOnlyList<byte>> Params
        {
            get;
            set;
        }

        public string OsVersion
        {
            get;
            set;
        }

        public Cereal.Map<string, IReadOnlyList<byte>> Commands
        {
            get;
            set;
        }

        public ulong WallTimeNanos
        {
            get;
            set;
        }

        public string GitCommitDate
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public IReadOnlyList<string> KernelArgs => ctx.ReadList(0).CastText2();
            public string GctxDEPRECATED => ctx.ReadText(1, null);
            public string DongleId => ctx.ReadText(2, null);
            public Cereal.InitData.DeviceType TheDeviceType => (Cereal.InitData.DeviceType)ctx.ReadDataUShort(0UL, (ushort)0);
            public string Version => ctx.ReadText(3, null);
            public Cereal.InitData.AndroidBuildInfo.READER TheAndroidBuildInfo => ctx.ReadStruct(4, Cereal.InitData.AndroidBuildInfo.READER.create);
            public IReadOnlyList<Cereal.InitData.AndroidSensor.READER> AndroidSensorsDEPRECATED => ctx.ReadList(5).Cast(Cereal.InitData.AndroidSensor.READER.create);
            public Cereal.InitData.ChffrAndroidExtra.READER ChffrAndroidExtraDEPRECATED => ctx.ReadStruct(6, Cereal.InitData.ChffrAndroidExtra.READER.create);
            public Cereal.InitData.PandaInfo.READER ThePandaInfo => ctx.ReadStruct(7, Cereal.InitData.PandaInfo.READER.create);
            public bool Dirty => ctx.ReadDataBool(16UL, false);
            public string GitCommit => ctx.ReadText(8, null);
            public string GitBranch => ctx.ReadText(9, null);
            public bool Passive => ctx.ReadDataBool(17UL, false);
            public string GitRemote => ctx.ReadText(10, null);
            public Cereal.InitData.IosBuildInfo.READER IosBuildInfoDEPRECATED => ctx.ReadStruct(11, Cereal.InitData.IosBuildInfo.READER.create);
            public string KernelVersion => ctx.ReadText(12, null);
            public Cereal.Map<string, string>.READER AndroidProperties => ctx.ReadStruct(13, Cereal.Map<string, string>.READER.create);
            public Cereal.Map<string, IReadOnlyList<byte>>.READER Params => ctx.ReadStruct(14, Cereal.Map<string, IReadOnlyList<byte>>.READER.create);
            public string OsVersion => ctx.ReadText(15, null);
            public Cereal.Map<string, IReadOnlyList<byte>>.READER Commands => ctx.ReadStruct(16, Cereal.Map<string, IReadOnlyList<byte>>.READER.create);
            public ulong WallTimeNanos => ctx.ReadDataULong(64UL, 0UL);
            public string GitCommitDate => ctx.ReadText(17, null);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(2, 18);
            }

            public ListOfTextSerializer KernelArgs
            {
                get => BuildPointer<ListOfTextSerializer>(0);
                set => Link(0, value);
            }

            public string GctxDEPRECATED
            {
                get => this.ReadText(1, null);
                set => this.WriteText(1, value, null);
            }

            public string DongleId
            {
                get => this.ReadText(2, null);
                set => this.WriteText(2, value, null);
            }

            public Cereal.InitData.DeviceType TheDeviceType
            {
                get => (Cereal.InitData.DeviceType)this.ReadDataUShort(0UL, (ushort)0);
                set => this.WriteData(0UL, (ushort)value, (ushort)0);
            }

            public string Version
            {
                get => this.ReadText(3, null);
                set => this.WriteText(3, value, null);
            }

            public Cereal.InitData.AndroidBuildInfo.WRITER TheAndroidBuildInfo
            {
                get => BuildPointer<Cereal.InitData.AndroidBuildInfo.WRITER>(4);
                set => Link(4, value);
            }

            public ListOfStructsSerializer<Cereal.InitData.AndroidSensor.WRITER> AndroidSensorsDEPRECATED
            {
                get => BuildPointer<ListOfStructsSerializer<Cereal.InitData.AndroidSensor.WRITER>>(5);
                set => Link(5, value);
            }

            public Cereal.InitData.ChffrAndroidExtra.WRITER ChffrAndroidExtraDEPRECATED
            {
                get => BuildPointer<Cereal.InitData.ChffrAndroidExtra.WRITER>(6);
                set => Link(6, value);
            }

            public Cereal.InitData.PandaInfo.WRITER ThePandaInfo
            {
                get => BuildPointer<Cereal.InitData.PandaInfo.WRITER>(7);
                set => Link(7, value);
            }

            public bool Dirty
            {
                get => this.ReadDataBool(16UL, false);
                set => this.WriteData(16UL, value, false);
            }

            public string GitCommit
            {
                get => this.ReadText(8, null);
                set => this.WriteText(8, value, null);
            }

            public string GitBranch
            {
                get => this.ReadText(9, null);
                set => this.WriteText(9, value, null);
            }

            public bool Passive
            {
                get => this.ReadDataBool(17UL, false);
                set => this.WriteData(17UL, value, false);
            }

            public string GitRemote
            {
                get => this.ReadText(10, null);
                set => this.WriteText(10, value, null);
            }

            public Cereal.InitData.IosBuildInfo.WRITER IosBuildInfoDEPRECATED
            {
                get => BuildPointer<Cereal.InitData.IosBuildInfo.WRITER>(11);
                set => Link(11, value);
            }

            public string KernelVersion
            {
                get => this.ReadText(12, null);
                set => this.WriteText(12, value, null);
            }

            public Cereal.Map<string, string>.WRITER AndroidProperties
            {
                get => BuildPointer<Cereal.Map<string, string>.WRITER>(13);
                set => Link(13, value);
            }

            public Cereal.Map<string, IReadOnlyList<byte>>.WRITER Params
            {
                get => BuildPointer<Cereal.Map<string, IReadOnlyList<byte>>.WRITER>(14);
                set => Link(14, value);
            }

            public string OsVersion
            {
                get => this.ReadText(15, null);
                set => this.WriteText(15, value, null);
            }

            public Cereal.Map<string, IReadOnlyList<byte>>.WRITER Commands
            {
                get => BuildPointer<Cereal.Map<string, IReadOnlyList<byte>>.WRITER>(16);
                set => Link(16, value);
            }

            public ulong WallTimeNanos
            {
                get => this.ReadDataULong(64UL, 0UL);
                set => this.WriteData(64UL, value, 0UL);
            }

            public string GitCommitDate
            {
                get => this.ReadText(17, null);
                set => this.WriteText(17, value, null);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x9d5d7238eba86608UL)]
        public enum DeviceType : ushort
        {
            unknown,
            neo,
            chffrAndroid,
            chffrIos,
            tici,
            pc,
            tizi
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xe673e8725cdff0adUL)]
        public class PandaInfo : ICapnpSerializable
        {
            public const UInt64 typeId = 0xe673e8725cdff0adUL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                HasPanda = reader.HasPanda;
                DongleId = reader.DongleId;
                StVersion = reader.StVersion;
                EspVersion = reader.EspVersion;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.HasPanda = HasPanda;
                writer.DongleId = DongleId;
                writer.StVersion = StVersion;
                writer.EspVersion = EspVersion;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public bool HasPanda
            {
                get;
                set;
            }

            public string DongleId
            {
                get;
                set;
            }

            public string StVersion
            {
                get;
                set;
            }

            public string EspVersion
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public bool HasPanda => ctx.ReadDataBool(0UL, false);
                public string DongleId => ctx.ReadText(0, null);
                public string StVersion => ctx.ReadText(1, null);
                public string EspVersion => ctx.ReadText(2, null);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(1, 3);
                }

                public bool HasPanda
                {
                    get => this.ReadDataBool(0UL, false);
                    set => this.WriteData(0UL, value, false);
                }

                public string DongleId
                {
                    get => this.ReadText(0, null);
                    set => this.WriteText(0, value, null);
                }

                public string StVersion
                {
                    get => this.ReadText(1, null);
                    set => this.WriteText(1, value, null);
                }

                public string EspVersion
                {
                    get => this.ReadText(2, null);
                    set => this.WriteText(2, value, null);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xfe2919d5c21f426cUL)]
        public class AndroidBuildInfo : ICapnpSerializable
        {
            public const UInt64 typeId = 0xfe2919d5c21f426cUL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Board = reader.Board;
                Bootloader = reader.Bootloader;
                Brand = reader.Brand;
                Device = reader.Device;
                Display = reader.Display;
                Fingerprint = reader.Fingerprint;
                Hardware = reader.Hardware;
                Host = reader.Host;
                Id = reader.Id;
                Manufacturer = reader.Manufacturer;
                Model = reader.Model;
                Product = reader.Product;
                RadioVersion = reader.RadioVersion;
                Serial = reader.Serial;
                SupportedAbis = reader.SupportedAbis;
                Tags = reader.Tags;
                Time = reader.Time;
                Type = reader.Type;
                User = reader.User;
                VersionCodename = reader.VersionCodename;
                VersionRelease = reader.VersionRelease;
                VersionSdk = reader.VersionSdk;
                VersionSecurityPatch = reader.VersionSecurityPatch;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Board = Board;
                writer.Bootloader = Bootloader;
                writer.Brand = Brand;
                writer.Device = Device;
                writer.Display = Display;
                writer.Fingerprint = Fingerprint;
                writer.Hardware = Hardware;
                writer.Host = Host;
                writer.Id = Id;
                writer.Manufacturer = Manufacturer;
                writer.Model = Model;
                writer.Product = Product;
                writer.RadioVersion = RadioVersion;
                writer.Serial = Serial;
                writer.SupportedAbis.Init(SupportedAbis);
                writer.Tags = Tags;
                writer.Time = Time;
                writer.Type = Type;
                writer.User = User;
                writer.VersionCodename = VersionCodename;
                writer.VersionRelease = VersionRelease;
                writer.VersionSdk = VersionSdk;
                writer.VersionSecurityPatch = VersionSecurityPatch;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public string Board
            {
                get;
                set;
            }

            public string Bootloader
            {
                get;
                set;
            }

            public string Brand
            {
                get;
                set;
            }

            public string Device
            {
                get;
                set;
            }

            public string Display
            {
                get;
                set;
            }

            public string Fingerprint
            {
                get;
                set;
            }

            public string Hardware
            {
                get;
                set;
            }

            public string Host
            {
                get;
                set;
            }

            public string Id
            {
                get;
                set;
            }

            public string Manufacturer
            {
                get;
                set;
            }

            public string Model
            {
                get;
                set;
            }

            public string Product
            {
                get;
                set;
            }

            public string RadioVersion
            {
                get;
                set;
            }

            public string Serial
            {
                get;
                set;
            }

            public IReadOnlyList<string> SupportedAbis
            {
                get;
                set;
            }

            public string Tags
            {
                get;
                set;
            }

            public long Time
            {
                get;
                set;
            }

            public string Type
            {
                get;
                set;
            }

            public string User
            {
                get;
                set;
            }

            public string VersionCodename
            {
                get;
                set;
            }

            public string VersionRelease
            {
                get;
                set;
            }

            public int VersionSdk
            {
                get;
                set;
            }

            public string VersionSecurityPatch
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public string Board => ctx.ReadText(0, null);
                public string Bootloader => ctx.ReadText(1, null);
                public string Brand => ctx.ReadText(2, null);
                public string Device => ctx.ReadText(3, null);
                public string Display => ctx.ReadText(4, null);
                public string Fingerprint => ctx.ReadText(5, null);
                public string Hardware => ctx.ReadText(6, null);
                public string Host => ctx.ReadText(7, null);
                public string Id => ctx.ReadText(8, null);
                public string Manufacturer => ctx.ReadText(9, null);
                public string Model => ctx.ReadText(10, null);
                public string Product => ctx.ReadText(11, null);
                public string RadioVersion => ctx.ReadText(12, null);
                public string Serial => ctx.ReadText(13, null);
                public IReadOnlyList<string> SupportedAbis => ctx.ReadList(14).CastText2();
                public string Tags => ctx.ReadText(15, null);
                public long Time => ctx.ReadDataLong(0UL, 0L);
                public string Type => ctx.ReadText(16, null);
                public string User => ctx.ReadText(17, null);
                public string VersionCodename => ctx.ReadText(18, null);
                public string VersionRelease => ctx.ReadText(19, null);
                public int VersionSdk => ctx.ReadDataInt(64UL, 0);
                public string VersionSecurityPatch => ctx.ReadText(20, null);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(2, 21);
                }

                public string Board
                {
                    get => this.ReadText(0, null);
                    set => this.WriteText(0, value, null);
                }

                public string Bootloader
                {
                    get => this.ReadText(1, null);
                    set => this.WriteText(1, value, null);
                }

                public string Brand
                {
                    get => this.ReadText(2, null);
                    set => this.WriteText(2, value, null);
                }

                public string Device
                {
                    get => this.ReadText(3, null);
                    set => this.WriteText(3, value, null);
                }

                public string Display
                {
                    get => this.ReadText(4, null);
                    set => this.WriteText(4, value, null);
                }

                public string Fingerprint
                {
                    get => this.ReadText(5, null);
                    set => this.WriteText(5, value, null);
                }

                public string Hardware
                {
                    get => this.ReadText(6, null);
                    set => this.WriteText(6, value, null);
                }

                public string Host
                {
                    get => this.ReadText(7, null);
                    set => this.WriteText(7, value, null);
                }

                public string Id
                {
                    get => this.ReadText(8, null);
                    set => this.WriteText(8, value, null);
                }

                public string Manufacturer
                {
                    get => this.ReadText(9, null);
                    set => this.WriteText(9, value, null);
                }

                public string Model
                {
                    get => this.ReadText(10, null);
                    set => this.WriteText(10, value, null);
                }

                public string Product
                {
                    get => this.ReadText(11, null);
                    set => this.WriteText(11, value, null);
                }

                public string RadioVersion
                {
                    get => this.ReadText(12, null);
                    set => this.WriteText(12, value, null);
                }

                public string Serial
                {
                    get => this.ReadText(13, null);
                    set => this.WriteText(13, value, null);
                }

                public ListOfTextSerializer SupportedAbis
                {
                    get => BuildPointer<ListOfTextSerializer>(14);
                    set => Link(14, value);
                }

                public string Tags
                {
                    get => this.ReadText(15, null);
                    set => this.WriteText(15, value, null);
                }

                public long Time
                {
                    get => this.ReadDataLong(0UL, 0L);
                    set => this.WriteData(0UL, value, 0L);
                }

                public string Type
                {
                    get => this.ReadText(16, null);
                    set => this.WriteText(16, value, null);
                }

                public string User
                {
                    get => this.ReadText(17, null);
                    set => this.WriteText(17, value, null);
                }

                public string VersionCodename
                {
                    get => this.ReadText(18, null);
                    set => this.WriteText(18, value, null);
                }

                public string VersionRelease
                {
                    get => this.ReadText(19, null);
                    set => this.WriteText(19, value, null);
                }

                public int VersionSdk
                {
                    get => this.ReadDataInt(64UL, 0);
                    set => this.WriteData(64UL, value, 0);
                }

                public string VersionSecurityPatch
                {
                    get => this.ReadText(20, null);
                    set => this.WriteText(20, value, null);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x9b513b93a887dbcdUL)]
        public class AndroidSensor : ICapnpSerializable
        {
            public const UInt64 typeId = 0x9b513b93a887dbcdUL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Id = reader.Id;
                Name = reader.Name;
                Vendor = reader.Vendor;
                Version = reader.Version;
                Handle = reader.Handle;
                Type = reader.Type;
                MaxRange = reader.MaxRange;
                Resolution = reader.Resolution;
                Power = reader.Power;
                MinDelay = reader.MinDelay;
                FifoReservedEventCount = reader.FifoReservedEventCount;
                FifoMaxEventCount = reader.FifoMaxEventCount;
                StringType = reader.StringType;
                MaxDelay = reader.MaxDelay;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Id = Id;
                writer.Name = Name;
                writer.Vendor = Vendor;
                writer.Version = Version;
                writer.Handle = Handle;
                writer.Type = Type;
                writer.MaxRange = MaxRange;
                writer.Resolution = Resolution;
                writer.Power = Power;
                writer.MinDelay = MinDelay;
                writer.FifoReservedEventCount = FifoReservedEventCount;
                writer.FifoMaxEventCount = FifoMaxEventCount;
                writer.StringType = StringType;
                writer.MaxDelay = MaxDelay;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public int Id
            {
                get;
                set;
            }

            public string Name
            {
                get;
                set;
            }

            public string Vendor
            {
                get;
                set;
            }

            public int Version
            {
                get;
                set;
            }

            public int Handle
            {
                get;
                set;
            }

            public int Type
            {
                get;
                set;
            }

            public float MaxRange
            {
                get;
                set;
            }

            public float Resolution
            {
                get;
                set;
            }

            public float Power
            {
                get;
                set;
            }

            public int MinDelay
            {
                get;
                set;
            }

            public uint FifoReservedEventCount
            {
                get;
                set;
            }

            public uint FifoMaxEventCount
            {
                get;
                set;
            }

            public string StringType
            {
                get;
                set;
            }

            public int MaxDelay
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public int Id => ctx.ReadDataInt(0UL, 0);
                public string Name => ctx.ReadText(0, null);
                public string Vendor => ctx.ReadText(1, null);
                public int Version => ctx.ReadDataInt(32UL, 0);
                public int Handle => ctx.ReadDataInt(64UL, 0);
                public int Type => ctx.ReadDataInt(96UL, 0);
                public float MaxRange => ctx.ReadDataFloat(128UL, 0F);
                public float Resolution => ctx.ReadDataFloat(160UL, 0F);
                public float Power => ctx.ReadDataFloat(192UL, 0F);
                public int MinDelay => ctx.ReadDataInt(224UL, 0);
                public uint FifoReservedEventCount => ctx.ReadDataUInt(256UL, 0U);
                public uint FifoMaxEventCount => ctx.ReadDataUInt(288UL, 0U);
                public string StringType => ctx.ReadText(2, null);
                public int MaxDelay => ctx.ReadDataInt(320UL, 0);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(6, 3);
                }

                public int Id
                {
                    get => this.ReadDataInt(0UL, 0);
                    set => this.WriteData(0UL, value, 0);
                }

                public string Name
                {
                    get => this.ReadText(0, null);
                    set => this.WriteText(0, value, null);
                }

                public string Vendor
                {
                    get => this.ReadText(1, null);
                    set => this.WriteText(1, value, null);
                }

                public int Version
                {
                    get => this.ReadDataInt(32UL, 0);
                    set => this.WriteData(32UL, value, 0);
                }

                public int Handle
                {
                    get => this.ReadDataInt(64UL, 0);
                    set => this.WriteData(64UL, value, 0);
                }

                public int Type
                {
                    get => this.ReadDataInt(96UL, 0);
                    set => this.WriteData(96UL, value, 0);
                }

                public float MaxRange
                {
                    get => this.ReadDataFloat(128UL, 0F);
                    set => this.WriteData(128UL, value, 0F);
                }

                public float Resolution
                {
                    get => this.ReadDataFloat(160UL, 0F);
                    set => this.WriteData(160UL, value, 0F);
                }

                public float Power
                {
                    get => this.ReadDataFloat(192UL, 0F);
                    set => this.WriteData(192UL, value, 0F);
                }

                public int MinDelay
                {
                    get => this.ReadDataInt(224UL, 0);
                    set => this.WriteData(224UL, value, 0);
                }

                public uint FifoReservedEventCount
                {
                    get => this.ReadDataUInt(256UL, 0U);
                    set => this.WriteData(256UL, value, 0U);
                }

                public uint FifoMaxEventCount
                {
                    get => this.ReadDataUInt(288UL, 0U);
                    set => this.WriteData(288UL, value, 0U);
                }

                public string StringType
                {
                    get => this.ReadText(2, null);
                    set => this.WriteText(2, value, null);
                }

                public int MaxDelay
                {
                    get => this.ReadDataInt(320UL, 0);
                    set => this.WriteData(320UL, value, 0);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x9cfb5d53a4f615a5UL)]
        public class ChffrAndroidExtra : ICapnpSerializable
        {
            public const UInt64 typeId = 0x9cfb5d53a4f615a5UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                AllCameraCharacteristics = CapnpSerializable.Create<Cereal.Map<string, string>>(reader.AllCameraCharacteristics);
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                AllCameraCharacteristics?.serialize(writer.AllCameraCharacteristics);
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public Cereal.Map<string, string> AllCameraCharacteristics
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public Cereal.Map<string, string>.READER AllCameraCharacteristics => ctx.ReadStruct(0, Cereal.Map<string, string>.READER.create);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 1);
                }

                public Cereal.Map<string, string>.WRITER AllCameraCharacteristics
                {
                    get => BuildPointer<Cereal.Map<string, string>.WRITER>(0);
                    set => Link(0, value);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xd97e3b28239f5580UL)]
        public class IosBuildInfo : ICapnpSerializable
        {
            public const UInt64 typeId = 0xd97e3b28239f5580UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                AppVersion = reader.AppVersion;
                AppBuild = reader.AppBuild;
                OsVersion = reader.OsVersion;
                DeviceModel = reader.DeviceModel;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.AppVersion = AppVersion;
                writer.AppBuild = AppBuild;
                writer.OsVersion = OsVersion;
                writer.DeviceModel = DeviceModel;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public string AppVersion
            {
                get;
                set;
            }

            public uint AppBuild
            {
                get;
                set;
            }

            public string OsVersion
            {
                get;
                set;
            }

            public string DeviceModel
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public string AppVersion => ctx.ReadText(0, null);
                public uint AppBuild => ctx.ReadDataUInt(0UL, 0U);
                public string OsVersion => ctx.ReadText(1, null);
                public string DeviceModel => ctx.ReadText(2, null);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(1, 3);
                }

                public string AppVersion
                {
                    get => this.ReadText(0, null);
                    set => this.WriteText(0, value, null);
                }

                public uint AppBuild
                {
                    get => this.ReadDataUInt(0UL, 0U);
                    set => this.WriteData(0UL, value, 0U);
                }

                public string OsVersion
                {
                    get => this.ReadText(1, null);
                    set => this.WriteText(1, value, null);
                }

                public string DeviceModel
                {
                    get => this.ReadText(2, null);
                    set => this.WriteText(2, value, null);
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xea0245f695ae0a33UL)]
    public class FrameData : ICapnpSerializable
    {
        public const UInt64 typeId = 0xea0245f695ae0a33UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            FrameId = reader.FrameId;
            EncodeId = reader.EncodeId;
            TimestampEof = reader.TimestampEof;
            FrameLengthDEPRECATED = reader.FrameLengthDEPRECATED;
            IntegLines = reader.IntegLines;
            GlobalGainDEPRECATED = reader.GlobalGainDEPRECATED;
            Image = reader.Image;
            TheFrameType = reader.TheFrameType;
            TimestampSof = reader.TimestampSof;
            AndroidCaptureResultDEPRECATED = CapnpSerializable.Create<Cereal.FrameData.AndroidCaptureResult>(reader.AndroidCaptureResultDEPRECATED);
            Transform = reader.Transform;
            LensPosDEPRECATED = reader.LensPosDEPRECATED;
            LensSagDEPRECATED = reader.LensSagDEPRECATED;
            LensErrDEPRECATED = reader.LensErrDEPRECATED;
            LensTruePosDEPRECATED = reader.LensTruePosDEPRECATED;
            Gain = reader.Gain;
            FocusValDEPRECATED = reader.FocusValDEPRECATED;
            FocusConfDEPRECATED = reader.FocusConfDEPRECATED;
            SharpnessScoreDEPRECATED = reader.SharpnessScoreDEPRECATED;
            RecoverStateDEPRECATED = reader.RecoverStateDEPRECATED;
            HighConversionGain = reader.HighConversionGain;
            MeasuredGreyFraction = reader.MeasuredGreyFraction;
            TargetGreyFraction = reader.TargetGreyFraction;
            ProcessingTime = reader.ProcessingTime;
            TemperaturesC = reader.TemperaturesC;
            FrameIdSensor = reader.FrameIdSensor;
            Sensor = reader.Sensor;
            ExposureValPercent = reader.ExposureValPercent;
            RequestId = reader.RequestId;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.FrameId = FrameId;
            writer.EncodeId = EncodeId;
            writer.TimestampEof = TimestampEof;
            writer.FrameLengthDEPRECATED = FrameLengthDEPRECATED;
            writer.IntegLines = IntegLines;
            writer.GlobalGainDEPRECATED = GlobalGainDEPRECATED;
            writer.Image.Init(Image);
            writer.TheFrameType = TheFrameType;
            writer.TimestampSof = TimestampSof;
            AndroidCaptureResultDEPRECATED?.serialize(writer.AndroidCaptureResultDEPRECATED);
            writer.Transform.Init(Transform);
            writer.LensPosDEPRECATED = LensPosDEPRECATED;
            writer.LensSagDEPRECATED = LensSagDEPRECATED;
            writer.LensErrDEPRECATED = LensErrDEPRECATED;
            writer.LensTruePosDEPRECATED = LensTruePosDEPRECATED;
            writer.Gain = Gain;
            writer.FocusValDEPRECATED.Init(FocusValDEPRECATED);
            writer.FocusConfDEPRECATED.Init(FocusConfDEPRECATED);
            writer.SharpnessScoreDEPRECATED.Init(SharpnessScoreDEPRECATED);
            writer.RecoverStateDEPRECATED = RecoverStateDEPRECATED;
            writer.HighConversionGain = HighConversionGain;
            writer.MeasuredGreyFraction = MeasuredGreyFraction;
            writer.TargetGreyFraction = TargetGreyFraction;
            writer.ProcessingTime = ProcessingTime;
            writer.TemperaturesC.Init(TemperaturesC);
            writer.FrameIdSensor = FrameIdSensor;
            writer.Sensor = Sensor;
            writer.ExposureValPercent = ExposureValPercent;
            writer.RequestId = RequestId;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public uint FrameId
        {
            get;
            set;
        }

        public uint EncodeId
        {
            get;
            set;
        }

        public ulong TimestampEof
        {
            get;
            set;
        }

        public int FrameLengthDEPRECATED
        {
            get;
            set;
        }

        public int IntegLines
        {
            get;
            set;
        }

        public int GlobalGainDEPRECATED
        {
            get;
            set;
        }

        public IReadOnlyList<byte> Image
        {
            get;
            set;
        }

        public Cereal.FrameData.FrameType TheFrameType
        {
            get;
            set;
        }

        public ulong TimestampSof
        {
            get;
            set;
        }

        public Cereal.FrameData.AndroidCaptureResult AndroidCaptureResultDEPRECATED
        {
            get;
            set;
        }

        public IReadOnlyList<float> Transform
        {
            get;
            set;
        }

        public int LensPosDEPRECATED
        {
            get;
            set;
        }

        public float LensSagDEPRECATED
        {
            get;
            set;
        }

        public float LensErrDEPRECATED
        {
            get;
            set;
        }

        public float LensTruePosDEPRECATED
        {
            get;
            set;
        }

        public float Gain
        {
            get;
            set;
        }

        public IReadOnlyList<short> FocusValDEPRECATED
        {
            get;
            set;
        }

        public IReadOnlyList<byte> FocusConfDEPRECATED
        {
            get;
            set;
        }

        public IReadOnlyList<ushort> SharpnessScoreDEPRECATED
        {
            get;
            set;
        }

        public int RecoverStateDEPRECATED
        {
            get;
            set;
        }

        public bool HighConversionGain
        {
            get;
            set;
        }

        public float MeasuredGreyFraction
        {
            get;
            set;
        }

        public float TargetGreyFraction
        {
            get;
            set;
        }

        public float ProcessingTime
        {
            get;
            set;
        }

        public IReadOnlyList<float> TemperaturesC
        {
            get;
            set;
        }

        public uint FrameIdSensor
        {
            get;
            set;
        }

        public Cereal.FrameData.ImageSensor Sensor
        {
            get;
            set;
        }

        public float ExposureValPercent
        {
            get;
            set;
        }

        public uint RequestId
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public uint FrameId => ctx.ReadDataUInt(0UL, 0U);
            public uint EncodeId => ctx.ReadDataUInt(32UL, 0U);
            public ulong TimestampEof => ctx.ReadDataULong(64UL, 0UL);
            public int FrameLengthDEPRECATED => ctx.ReadDataInt(128UL, 0);
            public int IntegLines => ctx.ReadDataInt(160UL, 0);
            public int GlobalGainDEPRECATED => ctx.ReadDataInt(192UL, 0);
            public IReadOnlyList<byte> Image => ctx.ReadList(0).CastByte();
            public Cereal.FrameData.FrameType TheFrameType => (Cereal.FrameData.FrameType)ctx.ReadDataUShort(224UL, (ushort)0);
            public ulong TimestampSof => ctx.ReadDataULong(256UL, 0UL);
            public Cereal.FrameData.AndroidCaptureResult.READER AndroidCaptureResultDEPRECATED => ctx.ReadStruct(1, Cereal.FrameData.AndroidCaptureResult.READER.create);
            public IReadOnlyList<float> Transform => ctx.ReadList(2).CastFloat();
            public int LensPosDEPRECATED => ctx.ReadDataInt(320UL, 0);
            public float LensSagDEPRECATED => ctx.ReadDataFloat(352UL, 0F);
            public float LensErrDEPRECATED => ctx.ReadDataFloat(384UL, 0F);
            public float LensTruePosDEPRECATED => ctx.ReadDataFloat(416UL, 0F);
            public float Gain => ctx.ReadDataFloat(448UL, 0F);
            public IReadOnlyList<short> FocusValDEPRECATED => ctx.ReadList(3).CastShort();
            public IReadOnlyList<byte> FocusConfDEPRECATED => ctx.ReadList(4).CastByte();
            public IReadOnlyList<ushort> SharpnessScoreDEPRECATED => ctx.ReadList(5).CastUShort();
            public int RecoverStateDEPRECATED => ctx.ReadDataInt(480UL, 0);
            public bool HighConversionGain => ctx.ReadDataBool(240UL, false);
            public float MeasuredGreyFraction => ctx.ReadDataFloat(512UL, 0F);
            public float TargetGreyFraction => ctx.ReadDataFloat(544UL, 0F);
            public float ProcessingTime => ctx.ReadDataFloat(576UL, 0F);
            public IReadOnlyList<float> TemperaturesC => ctx.ReadList(6).CastFloat();
            public uint FrameIdSensor => ctx.ReadDataUInt(608UL, 0U);
            public Cereal.FrameData.ImageSensor Sensor => (Cereal.FrameData.ImageSensor)ctx.ReadDataUShort(640UL, (ushort)0);
            public float ExposureValPercent => ctx.ReadDataFloat(672UL, 0F);
            public uint RequestId => ctx.ReadDataUInt(704UL, 0U);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(12, 7);
            }

            public uint FrameId
            {
                get => this.ReadDataUInt(0UL, 0U);
                set => this.WriteData(0UL, value, 0U);
            }

            public uint EncodeId
            {
                get => this.ReadDataUInt(32UL, 0U);
                set => this.WriteData(32UL, value, 0U);
            }

            public ulong TimestampEof
            {
                get => this.ReadDataULong(64UL, 0UL);
                set => this.WriteData(64UL, value, 0UL);
            }

            public int FrameLengthDEPRECATED
            {
                get => this.ReadDataInt(128UL, 0);
                set => this.WriteData(128UL, value, 0);
            }

            public int IntegLines
            {
                get => this.ReadDataInt(160UL, 0);
                set => this.WriteData(160UL, value, 0);
            }

            public int GlobalGainDEPRECATED
            {
                get => this.ReadDataInt(192UL, 0);
                set => this.WriteData(192UL, value, 0);
            }

            public ListOfPrimitivesSerializer<byte> Image
            {
                get => BuildPointer<ListOfPrimitivesSerializer<byte>>(0);
                set => Link(0, value);
            }

            public Cereal.FrameData.FrameType TheFrameType
            {
                get => (Cereal.FrameData.FrameType)this.ReadDataUShort(224UL, (ushort)0);
                set => this.WriteData(224UL, (ushort)value, (ushort)0);
            }

            public ulong TimestampSof
            {
                get => this.ReadDataULong(256UL, 0UL);
                set => this.WriteData(256UL, value, 0UL);
            }

            public Cereal.FrameData.AndroidCaptureResult.WRITER AndroidCaptureResultDEPRECATED
            {
                get => BuildPointer<Cereal.FrameData.AndroidCaptureResult.WRITER>(1);
                set => Link(1, value);
            }

            public ListOfPrimitivesSerializer<float> Transform
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(2);
                set => Link(2, value);
            }

            public int LensPosDEPRECATED
            {
                get => this.ReadDataInt(320UL, 0);
                set => this.WriteData(320UL, value, 0);
            }

            public float LensSagDEPRECATED
            {
                get => this.ReadDataFloat(352UL, 0F);
                set => this.WriteData(352UL, value, 0F);
            }

            public float LensErrDEPRECATED
            {
                get => this.ReadDataFloat(384UL, 0F);
                set => this.WriteData(384UL, value, 0F);
            }

            public float LensTruePosDEPRECATED
            {
                get => this.ReadDataFloat(416UL, 0F);
                set => this.WriteData(416UL, value, 0F);
            }

            public float Gain
            {
                get => this.ReadDataFloat(448UL, 0F);
                set => this.WriteData(448UL, value, 0F);
            }

            public ListOfPrimitivesSerializer<short> FocusValDEPRECATED
            {
                get => BuildPointer<ListOfPrimitivesSerializer<short>>(3);
                set => Link(3, value);
            }

            public ListOfPrimitivesSerializer<byte> FocusConfDEPRECATED
            {
                get => BuildPointer<ListOfPrimitivesSerializer<byte>>(4);
                set => Link(4, value);
            }

            public ListOfPrimitivesSerializer<ushort> SharpnessScoreDEPRECATED
            {
                get => BuildPointer<ListOfPrimitivesSerializer<ushort>>(5);
                set => Link(5, value);
            }

            public int RecoverStateDEPRECATED
            {
                get => this.ReadDataInt(480UL, 0);
                set => this.WriteData(480UL, value, 0);
            }

            public bool HighConversionGain
            {
                get => this.ReadDataBool(240UL, false);
                set => this.WriteData(240UL, value, false);
            }

            public float MeasuredGreyFraction
            {
                get => this.ReadDataFloat(512UL, 0F);
                set => this.WriteData(512UL, value, 0F);
            }

            public float TargetGreyFraction
            {
                get => this.ReadDataFloat(544UL, 0F);
                set => this.WriteData(544UL, value, 0F);
            }

            public float ProcessingTime
            {
                get => this.ReadDataFloat(576UL, 0F);
                set => this.WriteData(576UL, value, 0F);
            }

            public ListOfPrimitivesSerializer<float> TemperaturesC
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(6);
                set => Link(6, value);
            }

            public uint FrameIdSensor
            {
                get => this.ReadDataUInt(608UL, 0U);
                set => this.WriteData(608UL, value, 0U);
            }

            public Cereal.FrameData.ImageSensor Sensor
            {
                get => (Cereal.FrameData.ImageSensor)this.ReadDataUShort(640UL, (ushort)0);
                set => this.WriteData(640UL, (ushort)value, (ushort)0);
            }

            public float ExposureValPercent
            {
                get => this.ReadDataFloat(672UL, 0F);
                set => this.WriteData(672UL, value, 0F);
            }

            public uint RequestId
            {
                get => this.ReadDataUInt(704UL, 0U);
                set => this.WriteData(704UL, value, 0U);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xddb169f01e102879UL)]
        public enum FrameType : ushort
        {
            unknown,
            neo,
            chffrAndroid,
            front
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xd810b1e7705dd69cUL)]
        public enum ImageSensor : ushort
        {
            unknown,
            ar0231,
            ox03c10,
            os04c10
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xbcc3efbac41d2048UL)]
        public class AndroidCaptureResult : ICapnpSerializable
        {
            public const UInt64 typeId = 0xbcc3efbac41d2048UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Sensitivity = reader.Sensitivity;
                FrameDuration = reader.FrameDuration;
                ExposureTime = reader.ExposureTime;
                RollingShutterSkew = reader.RollingShutterSkew;
                ColorCorrectionTransform = reader.ColorCorrectionTransform;
                ColorCorrectionGains = reader.ColorCorrectionGains;
                DisplayRotation = reader.DisplayRotation;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Sensitivity = Sensitivity;
                writer.FrameDuration = FrameDuration;
                writer.ExposureTime = ExposureTime;
                writer.RollingShutterSkew = RollingShutterSkew;
                writer.ColorCorrectionTransform.Init(ColorCorrectionTransform);
                writer.ColorCorrectionGains.Init(ColorCorrectionGains);
                writer.DisplayRotation = DisplayRotation;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public int Sensitivity
            {
                get;
                set;
            }

            public long FrameDuration
            {
                get;
                set;
            }

            public long ExposureTime
            {
                get;
                set;
            }

            public ulong RollingShutterSkew
            {
                get;
                set;
            }

            public IReadOnlyList<int> ColorCorrectionTransform
            {
                get;
                set;
            }

            public IReadOnlyList<float> ColorCorrectionGains
            {
                get;
                set;
            }

            public sbyte DisplayRotation
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public int Sensitivity => ctx.ReadDataInt(0UL, 0);
                public long FrameDuration => ctx.ReadDataLong(64UL, 0L);
                public long ExposureTime => ctx.ReadDataLong(128UL, 0L);
                public ulong RollingShutterSkew => ctx.ReadDataULong(192UL, 0UL);
                public IReadOnlyList<int> ColorCorrectionTransform => ctx.ReadList(0).CastInt();
                public IReadOnlyList<float> ColorCorrectionGains => ctx.ReadList(1).CastFloat();
                public sbyte DisplayRotation => ctx.ReadDataSByte(32UL, (sbyte)0);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(4, 2);
                }

                public int Sensitivity
                {
                    get => this.ReadDataInt(0UL, 0);
                    set => this.WriteData(0UL, value, 0);
                }

                public long FrameDuration
                {
                    get => this.ReadDataLong(64UL, 0L);
                    set => this.WriteData(64UL, value, 0L);
                }

                public long ExposureTime
                {
                    get => this.ReadDataLong(128UL, 0L);
                    set => this.WriteData(128UL, value, 0L);
                }

                public ulong RollingShutterSkew
                {
                    get => this.ReadDataULong(192UL, 0UL);
                    set => this.WriteData(192UL, value, 0UL);
                }

                public ListOfPrimitivesSerializer<int> ColorCorrectionTransform
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<int>>(0);
                    set => Link(0, value);
                }

                public ListOfPrimitivesSerializer<float> ColorCorrectionGains
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(1);
                    set => Link(1, value);
                }

                public sbyte DisplayRotation
                {
                    get => this.ReadDataSByte(32UL, (sbyte)0);
                    set => this.WriteData(32UL, value, (sbyte)0);
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xb65fce64120af7d3UL)]
    public class Thumbnail : ICapnpSerializable
    {
        public const UInt64 typeId = 0xb65fce64120af7d3UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            FrameId = reader.FrameId;
            TimestampEof = reader.TimestampEof;
            TheThumbnail = reader.TheThumbnail;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.FrameId = FrameId;
            writer.TimestampEof = TimestampEof;
            writer.TheThumbnail.Init(TheThumbnail);
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public uint FrameId
        {
            get;
            set;
        }

        public ulong TimestampEof
        {
            get;
            set;
        }

        public IReadOnlyList<byte> TheThumbnail
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public uint FrameId => ctx.ReadDataUInt(0UL, 0U);
            public ulong TimestampEof => ctx.ReadDataULong(64UL, 0UL);
            public IReadOnlyList<byte> TheThumbnail => ctx.ReadList(0).CastByte();
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(2, 1);
            }

            public uint FrameId
            {
                get => this.ReadDataUInt(0UL, 0U);
                set => this.WriteData(0UL, value, 0U);
            }

            public ulong TimestampEof
            {
                get => this.ReadDataULong(64UL, 0UL);
                set => this.WriteData(64UL, value, 0UL);
            }

            public ListOfPrimitivesSerializer<byte> TheThumbnail
            {
                get => BuildPointer<ListOfPrimitivesSerializer<byte>>(0);
                set => Link(0, value);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x9d291d7813ba4a88UL)]
    public class GPSNMEAData : ICapnpSerializable
    {
        public const UInt64 typeId = 0x9d291d7813ba4a88UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            Timestamp = reader.Timestamp;
            LocalWallTime = reader.LocalWallTime;
            Nmea = reader.Nmea;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.Timestamp = Timestamp;
            writer.LocalWallTime = LocalWallTime;
            writer.Nmea = Nmea;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public long Timestamp
        {
            get;
            set;
        }

        public ulong LocalWallTime
        {
            get;
            set;
        }

        public string Nmea
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public long Timestamp => ctx.ReadDataLong(0UL, 0L);
            public ulong LocalWallTime => ctx.ReadDataULong(64UL, 0UL);
            public string Nmea => ctx.ReadText(0, null);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(2, 1);
            }

            public long Timestamp
            {
                get => this.ReadDataLong(0UL, 0L);
                set => this.WriteData(0UL, value, 0L);
            }

            public ulong LocalWallTime
            {
                get => this.ReadDataULong(64UL, 0UL);
                set => this.WriteData(64UL, value, 0UL);
            }

            public string Nmea
            {
                get => this.ReadText(0, null);
                set => this.WriteText(0, value, null);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xa2b29a69d44529a1UL)]
    public class SensorEventData : ICapnpSerializable
    {
        public const UInt64 typeId = 0xa2b29a69d44529a1UL;
        public enum WHICH : ushort
        {
            Acceleration = 0,
            Magnetic = 1,
            Orientation = 2,
            Gyro = 3,
            Pressure = 4,
            MagneticUncalibrated = 5,
            GyroUncalibrated = 6,
            Proximity = 7,
            Light = 8,
            Temperature = 9,
            undefined = 65535
        }

        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            switch (reader.which)
            {
                case WHICH.Acceleration:
                    Acceleration = CapnpSerializable.Create<Cereal.SensorEventData.SensorVec>(reader.Acceleration);
                    break;
                case WHICH.Magnetic:
                    Magnetic = CapnpSerializable.Create<Cereal.SensorEventData.SensorVec>(reader.Magnetic);
                    break;
                case WHICH.Orientation:
                    Orientation = CapnpSerializable.Create<Cereal.SensorEventData.SensorVec>(reader.Orientation);
                    break;
                case WHICH.Gyro:
                    Gyro = CapnpSerializable.Create<Cereal.SensorEventData.SensorVec>(reader.Gyro);
                    break;
                case WHICH.Pressure:
                    Pressure = CapnpSerializable.Create<Cereal.SensorEventData.SensorVec>(reader.Pressure);
                    break;
                case WHICH.MagneticUncalibrated:
                    MagneticUncalibrated = CapnpSerializable.Create<Cereal.SensorEventData.SensorVec>(reader.MagneticUncalibrated);
                    break;
                case WHICH.GyroUncalibrated:
                    GyroUncalibrated = CapnpSerializable.Create<Cereal.SensorEventData.SensorVec>(reader.GyroUncalibrated);
                    break;
                case WHICH.Proximity:
                    Proximity = reader.Proximity;
                    break;
                case WHICH.Light:
                    Light = reader.Light;
                    break;
                case WHICH.Temperature:
                    Temperature = reader.Temperature;
                    break;
            }

            Version = reader.Version;
            Sensor = reader.Sensor;
            Type = reader.Type;
            Timestamp = reader.Timestamp;
            Source = reader.Source;
            UncalibratedDEPRECATED = reader.UncalibratedDEPRECATED;
            applyDefaults();
        }

        private WHICH _which = WHICH.undefined;
        private object _content;
        public WHICH which
        {
            get => _which;
            set
            {
                if (value == _which)
                    return;
                _which = value;
                switch (value)
                {
                    case WHICH.Acceleration:
                        _content = null;
                        break;
                    case WHICH.Magnetic:
                        _content = null;
                        break;
                    case WHICH.Orientation:
                        _content = null;
                        break;
                    case WHICH.Gyro:
                        _content = null;
                        break;
                    case WHICH.Pressure:
                        _content = null;
                        break;
                    case WHICH.MagneticUncalibrated:
                        _content = null;
                        break;
                    case WHICH.GyroUncalibrated:
                        _content = null;
                        break;
                    case WHICH.Proximity:
                        _content = 0F;
                        break;
                    case WHICH.Light:
                        _content = 0F;
                        break;
                    case WHICH.Temperature:
                        _content = 0F;
                        break;
                }
            }
        }

        public void serialize(WRITER writer)
        {
            writer.which = which;
            switch (which)
            {
                case WHICH.Acceleration:
                    Acceleration?.serialize(writer.Acceleration);
                    break;
                case WHICH.Magnetic:
                    Magnetic?.serialize(writer.Magnetic);
                    break;
                case WHICH.Orientation:
                    Orientation?.serialize(writer.Orientation);
                    break;
                case WHICH.Gyro:
                    Gyro?.serialize(writer.Gyro);
                    break;
                case WHICH.Pressure:
                    Pressure?.serialize(writer.Pressure);
                    break;
                case WHICH.MagneticUncalibrated:
                    MagneticUncalibrated?.serialize(writer.MagneticUncalibrated);
                    break;
                case WHICH.GyroUncalibrated:
                    GyroUncalibrated?.serialize(writer.GyroUncalibrated);
                    break;
                case WHICH.Proximity:
                    writer.Proximity = Proximity.Value;
                    break;
                case WHICH.Light:
                    writer.Light = Light.Value;
                    break;
                case WHICH.Temperature:
                    writer.Temperature = Temperature.Value;
                    break;
            }

            writer.Version = Version;
            writer.Sensor = Sensor;
            writer.Type = Type;
            writer.Timestamp = Timestamp;
            writer.Source = Source;
            writer.UncalibratedDEPRECATED = UncalibratedDEPRECATED;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public int Version
        {
            get;
            set;
        }

        public int Sensor
        {
            get;
            set;
        }

        public int Type
        {
            get;
            set;
        }

        public long Timestamp
        {
            get;
            set;
        }

        public Cereal.SensorEventData.SensorVec Acceleration
        {
            get => _which == WHICH.Acceleration ? (Cereal.SensorEventData.SensorVec)_content : null;
            set
            {
                _which = WHICH.Acceleration;
                _content = value;
            }
        }

        public Cereal.SensorEventData.SensorVec Magnetic
        {
            get => _which == WHICH.Magnetic ? (Cereal.SensorEventData.SensorVec)_content : null;
            set
            {
                _which = WHICH.Magnetic;
                _content = value;
            }
        }

        public Cereal.SensorEventData.SensorVec Orientation
        {
            get => _which == WHICH.Orientation ? (Cereal.SensorEventData.SensorVec)_content : null;
            set
            {
                _which = WHICH.Orientation;
                _content = value;
            }
        }

        public Cereal.SensorEventData.SensorVec Gyro
        {
            get => _which == WHICH.Gyro ? (Cereal.SensorEventData.SensorVec)_content : null;
            set
            {
                _which = WHICH.Gyro;
                _content = value;
            }
        }

        public Cereal.SensorEventData.SensorSource Source
        {
            get;
            set;
        }

        public Cereal.SensorEventData.SensorVec Pressure
        {
            get => _which == WHICH.Pressure ? (Cereal.SensorEventData.SensorVec)_content : null;
            set
            {
                _which = WHICH.Pressure;
                _content = value;
            }
        }

        public bool UncalibratedDEPRECATED
        {
            get;
            set;
        }

        public Cereal.SensorEventData.SensorVec MagneticUncalibrated
        {
            get => _which == WHICH.MagneticUncalibrated ? (Cereal.SensorEventData.SensorVec)_content : null;
            set
            {
                _which = WHICH.MagneticUncalibrated;
                _content = value;
            }
        }

        public Cereal.SensorEventData.SensorVec GyroUncalibrated
        {
            get => _which == WHICH.GyroUncalibrated ? (Cereal.SensorEventData.SensorVec)_content : null;
            set
            {
                _which = WHICH.GyroUncalibrated;
                _content = value;
            }
        }

        public float? Proximity
        {
            get => _which == WHICH.Proximity ? (float? )_content : null;
            set
            {
                _which = WHICH.Proximity;
                _content = value;
            }
        }

        public float? Light
        {
            get => _which == WHICH.Light ? (float? )_content : null;
            set
            {
                _which = WHICH.Light;
                _content = value;
            }
        }

        public float? Temperature
        {
            get => _which == WHICH.Temperature ? (float? )_content : null;
            set
            {
                _which = WHICH.Temperature;
                _content = value;
            }
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public WHICH which => (WHICH)ctx.ReadDataUShort(96U, (ushort)0);
            public int Version => ctx.ReadDataInt(0UL, 0);
            public int Sensor => ctx.ReadDataInt(32UL, 0);
            public int Type => ctx.ReadDataInt(64UL, 0);
            public long Timestamp => ctx.ReadDataLong(128UL, 0L);
            public Cereal.SensorEventData.SensorVec.READER Acceleration => which == WHICH.Acceleration ? ctx.ReadStruct(0, Cereal.SensorEventData.SensorVec.READER.create) : default;
            public Cereal.SensorEventData.SensorVec.READER Magnetic => which == WHICH.Magnetic ? ctx.ReadStruct(0, Cereal.SensorEventData.SensorVec.READER.create) : default;
            public Cereal.SensorEventData.SensorVec.READER Orientation => which == WHICH.Orientation ? ctx.ReadStruct(0, Cereal.SensorEventData.SensorVec.READER.create) : default;
            public Cereal.SensorEventData.SensorVec.READER Gyro => which == WHICH.Gyro ? ctx.ReadStruct(0, Cereal.SensorEventData.SensorVec.READER.create) : default;
            public Cereal.SensorEventData.SensorSource Source => (Cereal.SensorEventData.SensorSource)ctx.ReadDataUShort(112UL, (ushort)0);
            public Cereal.SensorEventData.SensorVec.READER Pressure => which == WHICH.Pressure ? ctx.ReadStruct(0, Cereal.SensorEventData.SensorVec.READER.create) : default;
            public bool UncalibratedDEPRECATED => ctx.ReadDataBool(192UL, false);
            public Cereal.SensorEventData.SensorVec.READER MagneticUncalibrated => which == WHICH.MagneticUncalibrated ? ctx.ReadStruct(0, Cereal.SensorEventData.SensorVec.READER.create) : default;
            public Cereal.SensorEventData.SensorVec.READER GyroUncalibrated => which == WHICH.GyroUncalibrated ? ctx.ReadStruct(0, Cereal.SensorEventData.SensorVec.READER.create) : default;
            public float Proximity => which == WHICH.Proximity ? ctx.ReadDataFloat(224UL, 0F) : default;
            public float Light => which == WHICH.Light ? ctx.ReadDataFloat(224UL, 0F) : default;
            public float Temperature => which == WHICH.Temperature ? ctx.ReadDataFloat(224UL, 0F) : default;
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(4, 1);
            }

            public WHICH which
            {
                get => (WHICH)this.ReadDataUShort(96U, (ushort)0);
                set => this.WriteData(96U, (ushort)value, (ushort)0);
            }

            public int Version
            {
                get => this.ReadDataInt(0UL, 0);
                set => this.WriteData(0UL, value, 0);
            }

            public int Sensor
            {
                get => this.ReadDataInt(32UL, 0);
                set => this.WriteData(32UL, value, 0);
            }

            public int Type
            {
                get => this.ReadDataInt(64UL, 0);
                set => this.WriteData(64UL, value, 0);
            }

            public long Timestamp
            {
                get => this.ReadDataLong(128UL, 0L);
                set => this.WriteData(128UL, value, 0L);
            }

            public Cereal.SensorEventData.SensorVec.WRITER Acceleration
            {
                get => which == WHICH.Acceleration ? BuildPointer<Cereal.SensorEventData.SensorVec.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.SensorEventData.SensorVec.WRITER Magnetic
            {
                get => which == WHICH.Magnetic ? BuildPointer<Cereal.SensorEventData.SensorVec.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.SensorEventData.SensorVec.WRITER Orientation
            {
                get => which == WHICH.Orientation ? BuildPointer<Cereal.SensorEventData.SensorVec.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.SensorEventData.SensorVec.WRITER Gyro
            {
                get => which == WHICH.Gyro ? BuildPointer<Cereal.SensorEventData.SensorVec.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.SensorEventData.SensorSource Source
            {
                get => (Cereal.SensorEventData.SensorSource)this.ReadDataUShort(112UL, (ushort)0);
                set => this.WriteData(112UL, (ushort)value, (ushort)0);
            }

            public Cereal.SensorEventData.SensorVec.WRITER Pressure
            {
                get => which == WHICH.Pressure ? BuildPointer<Cereal.SensorEventData.SensorVec.WRITER>(0) : default;
                set => Link(0, value);
            }

            public bool UncalibratedDEPRECATED
            {
                get => this.ReadDataBool(192UL, false);
                set => this.WriteData(192UL, value, false);
            }

            public Cereal.SensorEventData.SensorVec.WRITER MagneticUncalibrated
            {
                get => which == WHICH.MagneticUncalibrated ? BuildPointer<Cereal.SensorEventData.SensorVec.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.SensorEventData.SensorVec.WRITER GyroUncalibrated
            {
                get => which == WHICH.GyroUncalibrated ? BuildPointer<Cereal.SensorEventData.SensorVec.WRITER>(0) : default;
                set => Link(0, value);
            }

            public float Proximity
            {
                get => which == WHICH.Proximity ? this.ReadDataFloat(224UL, 0F) : default;
                set => this.WriteData(224UL, value, 0F);
            }

            public float Light
            {
                get => which == WHICH.Light ? this.ReadDataFloat(224UL, 0F) : default;
                set => this.WriteData(224UL, value, 0F);
            }

            public float Temperature
            {
                get => which == WHICH.Temperature ? this.ReadDataFloat(224UL, 0F) : default;
                set => this.WriteData(224UL, value, 0F);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xa43429bd2bfc24fcUL)]
        public class SensorVec : ICapnpSerializable
        {
            public const UInt64 typeId = 0xa43429bd2bfc24fcUL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                V = reader.V;
                Status = reader.Status;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.V.Init(V);
                writer.Status = Status;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public IReadOnlyList<float> V
            {
                get;
                set;
            }

            public sbyte Status
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public IReadOnlyList<float> V => ctx.ReadList(0).CastFloat();
                public sbyte Status => ctx.ReadDataSByte(0UL, (sbyte)0);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(1, 1);
                }

                public ListOfPrimitivesSerializer<float> V
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(0);
                    set => Link(0, value);
                }

                public sbyte Status
                {
                    get => this.ReadDataSByte(0UL, (sbyte)0);
                    set => this.WriteData(0UL, value, (sbyte)0);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xe49b3ce8f7f48d0dUL)]
        public enum SensorSource : ushort
        {
            android,
            iOS,
            fiber,
            velodyne,
            bno055,
            lsm6ds3,
            bmp280,
            mmc3416x,
            bmx055,
            rpr0521,
            lsm6ds3trc,
            mmc5603nj
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xe946524859add50eUL)]
    public class GpsLocationData : ICapnpSerializable
    {
        public const UInt64 typeId = 0xe946524859add50eUL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            Flags = reader.Flags;
            Latitude = reader.Latitude;
            Longitude = reader.Longitude;
            Altitude = reader.Altitude;
            Speed = reader.Speed;
            BearingDeg = reader.BearingDeg;
            Accuracy = reader.Accuracy;
            UnixTimestampMillis = reader.UnixTimestampMillis;
            Source = reader.Source;
            VNED = reader.VNED;
            VerticalAccuracy = reader.VerticalAccuracy;
            BearingAccuracyDeg = reader.BearingAccuracyDeg;
            SpeedAccuracy = reader.SpeedAccuracy;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.Flags = Flags;
            writer.Latitude = Latitude;
            writer.Longitude = Longitude;
            writer.Altitude = Altitude;
            writer.Speed = Speed;
            writer.BearingDeg = BearingDeg;
            writer.Accuracy = Accuracy;
            writer.UnixTimestampMillis = UnixTimestampMillis;
            writer.Source = Source;
            writer.VNED.Init(VNED);
            writer.VerticalAccuracy = VerticalAccuracy;
            writer.BearingAccuracyDeg = BearingAccuracyDeg;
            writer.SpeedAccuracy = SpeedAccuracy;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public ushort Flags
        {
            get;
            set;
        }

        public double Latitude
        {
            get;
            set;
        }

        public double Longitude
        {
            get;
            set;
        }

        public double Altitude
        {
            get;
            set;
        }

        public float Speed
        {
            get;
            set;
        }

        public float BearingDeg
        {
            get;
            set;
        }

        public float Accuracy
        {
            get;
            set;
        }

        public long UnixTimestampMillis
        {
            get;
            set;
        }

        public Cereal.GpsLocationData.SensorSource Source
        {
            get;
            set;
        }

        public IReadOnlyList<float> VNED
        {
            get;
            set;
        }

        public float VerticalAccuracy
        {
            get;
            set;
        }

        public float BearingAccuracyDeg
        {
            get;
            set;
        }

        public float SpeedAccuracy
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public ushort Flags => ctx.ReadDataUShort(0UL, (ushort)0);
            public double Latitude => ctx.ReadDataDouble(64UL, 0);
            public double Longitude => ctx.ReadDataDouble(128UL, 0);
            public double Altitude => ctx.ReadDataDouble(192UL, 0);
            public float Speed => ctx.ReadDataFloat(32UL, 0F);
            public float BearingDeg => ctx.ReadDataFloat(256UL, 0F);
            public float Accuracy => ctx.ReadDataFloat(288UL, 0F);
            public long UnixTimestampMillis => ctx.ReadDataLong(320UL, 0L);
            public Cereal.GpsLocationData.SensorSource Source => (Cereal.GpsLocationData.SensorSource)ctx.ReadDataUShort(16UL, (ushort)0);
            public IReadOnlyList<float> VNED => ctx.ReadList(0).CastFloat();
            public float VerticalAccuracy => ctx.ReadDataFloat(384UL, 0F);
            public float BearingAccuracyDeg => ctx.ReadDataFloat(416UL, 0F);
            public float SpeedAccuracy => ctx.ReadDataFloat(448UL, 0F);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(8, 1);
            }

            public ushort Flags
            {
                get => this.ReadDataUShort(0UL, (ushort)0);
                set => this.WriteData(0UL, value, (ushort)0);
            }

            public double Latitude
            {
                get => this.ReadDataDouble(64UL, 0);
                set => this.WriteData(64UL, value, 0);
            }

            public double Longitude
            {
                get => this.ReadDataDouble(128UL, 0);
                set => this.WriteData(128UL, value, 0);
            }

            public double Altitude
            {
                get => this.ReadDataDouble(192UL, 0);
                set => this.WriteData(192UL, value, 0);
            }

            public float Speed
            {
                get => this.ReadDataFloat(32UL, 0F);
                set => this.WriteData(32UL, value, 0F);
            }

            public float BearingDeg
            {
                get => this.ReadDataFloat(256UL, 0F);
                set => this.WriteData(256UL, value, 0F);
            }

            public float Accuracy
            {
                get => this.ReadDataFloat(288UL, 0F);
                set => this.WriteData(288UL, value, 0F);
            }

            public long UnixTimestampMillis
            {
                get => this.ReadDataLong(320UL, 0L);
                set => this.WriteData(320UL, value, 0L);
            }

            public Cereal.GpsLocationData.SensorSource Source
            {
                get => (Cereal.GpsLocationData.SensorSource)this.ReadDataUShort(16UL, (ushort)0);
                set => this.WriteData(16UL, (ushort)value, (ushort)0);
            }

            public ListOfPrimitivesSerializer<float> VNED
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(0);
                set => Link(0, value);
            }

            public float VerticalAccuracy
            {
                get => this.ReadDataFloat(384UL, 0F);
                set => this.WriteData(384UL, value, 0F);
            }

            public float BearingAccuracyDeg
            {
                get => this.ReadDataFloat(416UL, 0F);
                set => this.WriteData(416UL, value, 0F);
            }

            public float SpeedAccuracy
            {
                get => this.ReadDataFloat(448UL, 0F);
                set => this.WriteData(448UL, value, 0F);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xd3ff79f25c734863UL)]
        public enum SensorSource : ushort
        {
            android,
            iOS,
            car,
            velodyne,
            fusion,
            external,
            ublox,
            trimble,
            qcomdiag
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xae674a34ba421466UL)]
    public enum Desire : ushort
    {
        none,
        turnLeft,
        turnRight,
        laneChangeLeft,
        laneChangeRight,
        keepLeft,
        keepRight
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xcd37924bf7b2d3d2UL)]
    public enum LaneChangeState : ushort
    {
        off,
        preLaneChange,
        laneChangeStarting,
        laneChangeFinishing
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x9d0bc0c1fe671176UL)]
    public enum LaneChangeDirection : ushort
    {
        none,
        left,
        right
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x8785009a964c7c59UL)]
    public class CanData : ICapnpSerializable
    {
        public const UInt64 typeId = 0x8785009a964c7c59UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            Address = reader.Address;
            BusTime = reader.BusTime;
            Dat = reader.Dat;
            Src = reader.Src;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.Address = Address;
            writer.BusTime = BusTime;
            writer.Dat.Init(Dat);
            writer.Src = Src;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public uint Address
        {
            get;
            set;
        }

        public ushort BusTime
        {
            get;
            set;
        }

        public IReadOnlyList<byte> Dat
        {
            get;
            set;
        }

        public byte Src
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public uint Address => ctx.ReadDataUInt(0UL, 0U);
            public ushort BusTime => ctx.ReadDataUShort(32UL, (ushort)0);
            public IReadOnlyList<byte> Dat => ctx.ReadList(0).CastByte();
            public byte Src => ctx.ReadDataByte(48UL, (byte)0);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(1, 1);
            }

            public uint Address
            {
                get => this.ReadDataUInt(0UL, 0U);
                set => this.WriteData(0UL, value, 0U);
            }

            public ushort BusTime
            {
                get => this.ReadDataUShort(32UL, (ushort)0);
                set => this.WriteData(32UL, value, (ushort)0);
            }

            public ListOfPrimitivesSerializer<byte> Dat
            {
                get => BuildPointer<ListOfPrimitivesSerializer<byte>>(0);
                set => Link(0, value);
            }

            public byte Src
            {
                get => this.ReadDataByte(48UL, (byte)0);
                set => this.WriteData(48UL, value, (byte)0);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xa4d8b5af2aa492ebUL)]
    public class DeviceState : ICapnpSerializable
    {
        public const UInt64 typeId = 0xa4d8b5af2aa492ebUL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            Cpu0DEPRECATED = reader.Cpu0DEPRECATED;
            Cpu1DEPRECATED = reader.Cpu1DEPRECATED;
            Cpu2DEPRECATED = reader.Cpu2DEPRECATED;
            Cpu3DEPRECATED = reader.Cpu3DEPRECATED;
            MemDEPRECATED = reader.MemDEPRECATED;
            GpuDEPRECATED = reader.GpuDEPRECATED;
            BatDEPRECATED = reader.BatDEPRECATED;
            FreeSpacePercent = reader.FreeSpacePercent;
            BatteryPercentDEPRECATED = reader.BatteryPercentDEPRECATED;
            BatteryStatusDEPRECATED = reader.BatteryStatusDEPRECATED;
            FanSpeedPercentDesired = reader.FanSpeedPercentDesired;
            Started = reader.Started;
            UsbOnlineDEPRECATED = reader.UsbOnlineDEPRECATED;
            StartedMonoTime = reader.StartedMonoTime;
            TheThermalStatus = reader.TheThermalStatus;
            BatteryCurrentDEPRECATED = reader.BatteryCurrentDEPRECATED;
            BatteryVoltageDEPRECATED = reader.BatteryVoltageDEPRECATED;
            ChargingErrorDEPRECATED = reader.ChargingErrorDEPRECATED;
            ChargingDisabledDEPRECATED = reader.ChargingDisabledDEPRECATED;
            MemoryUsagePercent = reader.MemoryUsagePercent;
            CpuUsagePercentDEPRECATED = reader.CpuUsagePercentDEPRECATED;
            Pa0DEPRECATED = reader.Pa0DEPRECATED;
            TheNetworkType = reader.TheNetworkType;
            OffroadPowerUsageUwh = reader.OffroadPowerUsageUwh;
            TheNetworkStrength = reader.TheNetworkStrength;
            CarBatteryCapacityUwh = reader.CarBatteryCapacityUwh;
            CpuTempC = reader.CpuTempC;
            GpuTempC = reader.GpuTempC;
            MemoryTempC = reader.MemoryTempC;
            BatteryTempCDEPRECATED = reader.BatteryTempCDEPRECATED;
            AmbientTempC = reader.AmbientTempC;
            TheNetworkInfo = CapnpSerializable.Create<Cereal.DeviceState.NetworkInfo>(reader.TheNetworkInfo);
            LastAthenaPingTime = reader.LastAthenaPingTime;
            GpuUsagePercent = reader.GpuUsagePercent;
            CpuUsagePercent = reader.CpuUsagePercent;
            NvmeTempC = reader.NvmeTempC;
            ModemTempC = reader.ModemTempC;
            ScreenBrightnessPercent = reader.ScreenBrightnessPercent;
            ThermalZones = reader.ThermalZones?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.DeviceState.ThermalZone>(_));
            PmicTempC = reader.PmicTempC;
            PowerDrawW = reader.PowerDrawW;
            NetworkMetered = reader.NetworkMetered;
            SomPowerDrawW = reader.SomPowerDrawW;
            TheNetworkStats = CapnpSerializable.Create<Cereal.DeviceState.NetworkStats>(reader.TheNetworkStats);
            MaxTempC = reader.MaxTempC;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.Cpu0DEPRECATED = Cpu0DEPRECATED;
            writer.Cpu1DEPRECATED = Cpu1DEPRECATED;
            writer.Cpu2DEPRECATED = Cpu2DEPRECATED;
            writer.Cpu3DEPRECATED = Cpu3DEPRECATED;
            writer.MemDEPRECATED = MemDEPRECATED;
            writer.GpuDEPRECATED = GpuDEPRECATED;
            writer.BatDEPRECATED = BatDEPRECATED;
            writer.FreeSpacePercent = FreeSpacePercent;
            writer.BatteryPercentDEPRECATED = BatteryPercentDEPRECATED;
            writer.BatteryStatusDEPRECATED = BatteryStatusDEPRECATED;
            writer.FanSpeedPercentDesired = FanSpeedPercentDesired;
            writer.Started = Started;
            writer.UsbOnlineDEPRECATED = UsbOnlineDEPRECATED;
            writer.StartedMonoTime = StartedMonoTime;
            writer.TheThermalStatus = TheThermalStatus;
            writer.BatteryCurrentDEPRECATED = BatteryCurrentDEPRECATED;
            writer.BatteryVoltageDEPRECATED = BatteryVoltageDEPRECATED;
            writer.ChargingErrorDEPRECATED = ChargingErrorDEPRECATED;
            writer.ChargingDisabledDEPRECATED = ChargingDisabledDEPRECATED;
            writer.MemoryUsagePercent = MemoryUsagePercent;
            writer.CpuUsagePercentDEPRECATED = CpuUsagePercentDEPRECATED;
            writer.Pa0DEPRECATED = Pa0DEPRECATED;
            writer.TheNetworkType = TheNetworkType;
            writer.OffroadPowerUsageUwh = OffroadPowerUsageUwh;
            writer.TheNetworkStrength = TheNetworkStrength;
            writer.CarBatteryCapacityUwh = CarBatteryCapacityUwh;
            writer.CpuTempC.Init(CpuTempC);
            writer.GpuTempC.Init(GpuTempC);
            writer.MemoryTempC = MemoryTempC;
            writer.BatteryTempCDEPRECATED = BatteryTempCDEPRECATED;
            writer.AmbientTempC = AmbientTempC;
            TheNetworkInfo?.serialize(writer.TheNetworkInfo);
            writer.LastAthenaPingTime = LastAthenaPingTime;
            writer.GpuUsagePercent = GpuUsagePercent;
            writer.CpuUsagePercent.Init(CpuUsagePercent);
            writer.NvmeTempC.Init(NvmeTempC);
            writer.ModemTempC.Init(ModemTempC);
            writer.ScreenBrightnessPercent = ScreenBrightnessPercent;
            writer.ThermalZones.Init(ThermalZones, (_s1, _v1) => _v1?.serialize(_s1));
            writer.PmicTempC.Init(PmicTempC);
            writer.PowerDrawW = PowerDrawW;
            writer.NetworkMetered = NetworkMetered;
            writer.SomPowerDrawW = SomPowerDrawW;
            TheNetworkStats?.serialize(writer.TheNetworkStats);
            writer.MaxTempC = MaxTempC;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public ushort Cpu0DEPRECATED
        {
            get;
            set;
        }

        public ushort Cpu1DEPRECATED
        {
            get;
            set;
        }

        public ushort Cpu2DEPRECATED
        {
            get;
            set;
        }

        public ushort Cpu3DEPRECATED
        {
            get;
            set;
        }

        public ushort MemDEPRECATED
        {
            get;
            set;
        }

        public ushort GpuDEPRECATED
        {
            get;
            set;
        }

        public uint BatDEPRECATED
        {
            get;
            set;
        }

        public float FreeSpacePercent
        {
            get;
            set;
        }

        public short BatteryPercentDEPRECATED
        {
            get;
            set;
        }

        public string BatteryStatusDEPRECATED
        {
            get;
            set;
        }

        public ushort FanSpeedPercentDesired
        {
            get;
            set;
        }

        public bool Started
        {
            get;
            set;
        }

        public bool UsbOnlineDEPRECATED
        {
            get;
            set;
        }

        public ulong StartedMonoTime
        {
            get;
            set;
        }

        public Cereal.DeviceState.ThermalStatus TheThermalStatus
        {
            get;
            set;
        }

        public int BatteryCurrentDEPRECATED
        {
            get;
            set;
        }

        public int BatteryVoltageDEPRECATED
        {
            get;
            set;
        }

        public bool ChargingErrorDEPRECATED
        {
            get;
            set;
        }

        public bool ChargingDisabledDEPRECATED
        {
            get;
            set;
        }

        public sbyte MemoryUsagePercent
        {
            get;
            set;
        }

        public sbyte CpuUsagePercentDEPRECATED
        {
            get;
            set;
        }

        public ushort Pa0DEPRECATED
        {
            get;
            set;
        }

        public Cereal.DeviceState.NetworkType TheNetworkType
        {
            get;
            set;
        }

        public uint OffroadPowerUsageUwh
        {
            get;
            set;
        }

        public Cereal.DeviceState.NetworkStrength TheNetworkStrength
        {
            get;
            set;
        }

        public uint CarBatteryCapacityUwh
        {
            get;
            set;
        }

        public IReadOnlyList<float> CpuTempC
        {
            get;
            set;
        }

        public IReadOnlyList<float> GpuTempC
        {
            get;
            set;
        }

        public float MemoryTempC
        {
            get;
            set;
        }

        public float BatteryTempCDEPRECATED
        {
            get;
            set;
        }

        public float AmbientTempC
        {
            get;
            set;
        }

        public Cereal.DeviceState.NetworkInfo TheNetworkInfo
        {
            get;
            set;
        }

        public ulong LastAthenaPingTime
        {
            get;
            set;
        }

        public sbyte GpuUsagePercent
        {
            get;
            set;
        }

        public IReadOnlyList<sbyte> CpuUsagePercent
        {
            get;
            set;
        }

        public IReadOnlyList<float> NvmeTempC
        {
            get;
            set;
        }

        public IReadOnlyList<float> ModemTempC
        {
            get;
            set;
        }

        public sbyte ScreenBrightnessPercent
        {
            get;
            set;
        }

        public IReadOnlyList<Cereal.DeviceState.ThermalZone> ThermalZones
        {
            get;
            set;
        }

        public IReadOnlyList<float> PmicTempC
        {
            get;
            set;
        }

        public float PowerDrawW
        {
            get;
            set;
        }

        public bool NetworkMetered
        {
            get;
            set;
        }

        public float SomPowerDrawW
        {
            get;
            set;
        }

        public Cereal.DeviceState.NetworkStats TheNetworkStats
        {
            get;
            set;
        }

        public float MaxTempC
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public ushort Cpu0DEPRECATED => ctx.ReadDataUShort(0UL, (ushort)0);
            public ushort Cpu1DEPRECATED => ctx.ReadDataUShort(16UL, (ushort)0);
            public ushort Cpu2DEPRECATED => ctx.ReadDataUShort(32UL, (ushort)0);
            public ushort Cpu3DEPRECATED => ctx.ReadDataUShort(48UL, (ushort)0);
            public ushort MemDEPRECATED => ctx.ReadDataUShort(64UL, (ushort)0);
            public ushort GpuDEPRECATED => ctx.ReadDataUShort(80UL, (ushort)0);
            public uint BatDEPRECATED => ctx.ReadDataUInt(96UL, 0U);
            public float FreeSpacePercent => ctx.ReadDataFloat(128UL, 0F);
            public short BatteryPercentDEPRECATED => ctx.ReadDataShort(160UL, (short)0);
            public string BatteryStatusDEPRECATED => ctx.ReadText(0, null);
            public ushort FanSpeedPercentDesired => ctx.ReadDataUShort(176UL, (ushort)0);
            public bool Started => ctx.ReadDataBool(192UL, false);
            public bool UsbOnlineDEPRECATED => ctx.ReadDataBool(193UL, false);
            public ulong StartedMonoTime => ctx.ReadDataULong(256UL, 0UL);
            public Cereal.DeviceState.ThermalStatus TheThermalStatus => (Cereal.DeviceState.ThermalStatus)ctx.ReadDataUShort(208UL, (ushort)0);
            public int BatteryCurrentDEPRECATED => ctx.ReadDataInt(224UL, 0);
            public int BatteryVoltageDEPRECATED => ctx.ReadDataInt(320UL, 0);
            public bool ChargingErrorDEPRECATED => ctx.ReadDataBool(194UL, false);
            public bool ChargingDisabledDEPRECATED => ctx.ReadDataBool(195UL, false);
            public sbyte MemoryUsagePercent => ctx.ReadDataSByte(200UL, (sbyte)0);
            public sbyte CpuUsagePercentDEPRECATED => ctx.ReadDataSByte(352UL, (sbyte)0);
            public ushort Pa0DEPRECATED => ctx.ReadDataUShort(368UL, (ushort)0);
            public Cereal.DeviceState.NetworkType TheNetworkType => (Cereal.DeviceState.NetworkType)ctx.ReadDataUShort(384UL, (ushort)0);
            public uint OffroadPowerUsageUwh => ctx.ReadDataUInt(416UL, 0U);
            public Cereal.DeviceState.NetworkStrength TheNetworkStrength => (Cereal.DeviceState.NetworkStrength)ctx.ReadDataUShort(400UL, (ushort)0);
            public uint CarBatteryCapacityUwh => ctx.ReadDataUInt(448UL, 0U);
            public IReadOnlyList<float> CpuTempC => ctx.ReadList(1).CastFloat();
            public IReadOnlyList<float> GpuTempC => ctx.ReadList(2).CastFloat();
            public float MemoryTempC => ctx.ReadDataFloat(480UL, 0F);
            public float BatteryTempCDEPRECATED => ctx.ReadDataFloat(512UL, 0F);
            public float AmbientTempC => ctx.ReadDataFloat(544UL, 0F);
            public Cereal.DeviceState.NetworkInfo.READER TheNetworkInfo => ctx.ReadStruct(3, Cereal.DeviceState.NetworkInfo.READER.create);
            public ulong LastAthenaPingTime => ctx.ReadDataULong(576UL, 0UL);
            public sbyte GpuUsagePercent => ctx.ReadDataSByte(360UL, (sbyte)0);
            public IReadOnlyList<sbyte> CpuUsagePercent => ctx.ReadList(4).CastSByte();
            public IReadOnlyList<float> NvmeTempC => ctx.ReadList(5).CastFloat();
            public IReadOnlyList<float> ModemTempC => ctx.ReadList(6).CastFloat();
            public sbyte ScreenBrightnessPercent => ctx.ReadDataSByte(640UL, (sbyte)0);
            public IReadOnlyList<Cereal.DeviceState.ThermalZone.READER> ThermalZones => ctx.ReadList(7).Cast(Cereal.DeviceState.ThermalZone.READER.create);
            public IReadOnlyList<float> PmicTempC => ctx.ReadList(8).CastFloat();
            public float PowerDrawW => ctx.ReadDataFloat(672UL, 0F);
            public bool NetworkMetered => ctx.ReadDataBool(196UL, false);
            public float SomPowerDrawW => ctx.ReadDataFloat(704UL, 0F);
            public Cereal.DeviceState.NetworkStats.READER TheNetworkStats => ctx.ReadStruct(9, Cereal.DeviceState.NetworkStats.READER.create);
            public float MaxTempC => ctx.ReadDataFloat(736UL, 0F);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(12, 10);
            }

            public ushort Cpu0DEPRECATED
            {
                get => this.ReadDataUShort(0UL, (ushort)0);
                set => this.WriteData(0UL, value, (ushort)0);
            }

            public ushort Cpu1DEPRECATED
            {
                get => this.ReadDataUShort(16UL, (ushort)0);
                set => this.WriteData(16UL, value, (ushort)0);
            }

            public ushort Cpu2DEPRECATED
            {
                get => this.ReadDataUShort(32UL, (ushort)0);
                set => this.WriteData(32UL, value, (ushort)0);
            }

            public ushort Cpu3DEPRECATED
            {
                get => this.ReadDataUShort(48UL, (ushort)0);
                set => this.WriteData(48UL, value, (ushort)0);
            }

            public ushort MemDEPRECATED
            {
                get => this.ReadDataUShort(64UL, (ushort)0);
                set => this.WriteData(64UL, value, (ushort)0);
            }

            public ushort GpuDEPRECATED
            {
                get => this.ReadDataUShort(80UL, (ushort)0);
                set => this.WriteData(80UL, value, (ushort)0);
            }

            public uint BatDEPRECATED
            {
                get => this.ReadDataUInt(96UL, 0U);
                set => this.WriteData(96UL, value, 0U);
            }

            public float FreeSpacePercent
            {
                get => this.ReadDataFloat(128UL, 0F);
                set => this.WriteData(128UL, value, 0F);
            }

            public short BatteryPercentDEPRECATED
            {
                get => this.ReadDataShort(160UL, (short)0);
                set => this.WriteData(160UL, value, (short)0);
            }

            public string BatteryStatusDEPRECATED
            {
                get => this.ReadText(0, null);
                set => this.WriteText(0, value, null);
            }

            public ushort FanSpeedPercentDesired
            {
                get => this.ReadDataUShort(176UL, (ushort)0);
                set => this.WriteData(176UL, value, (ushort)0);
            }

            public bool Started
            {
                get => this.ReadDataBool(192UL, false);
                set => this.WriteData(192UL, value, false);
            }

            public bool UsbOnlineDEPRECATED
            {
                get => this.ReadDataBool(193UL, false);
                set => this.WriteData(193UL, value, false);
            }

            public ulong StartedMonoTime
            {
                get => this.ReadDataULong(256UL, 0UL);
                set => this.WriteData(256UL, value, 0UL);
            }

            public Cereal.DeviceState.ThermalStatus TheThermalStatus
            {
                get => (Cereal.DeviceState.ThermalStatus)this.ReadDataUShort(208UL, (ushort)0);
                set => this.WriteData(208UL, (ushort)value, (ushort)0);
            }

            public int BatteryCurrentDEPRECATED
            {
                get => this.ReadDataInt(224UL, 0);
                set => this.WriteData(224UL, value, 0);
            }

            public int BatteryVoltageDEPRECATED
            {
                get => this.ReadDataInt(320UL, 0);
                set => this.WriteData(320UL, value, 0);
            }

            public bool ChargingErrorDEPRECATED
            {
                get => this.ReadDataBool(194UL, false);
                set => this.WriteData(194UL, value, false);
            }

            public bool ChargingDisabledDEPRECATED
            {
                get => this.ReadDataBool(195UL, false);
                set => this.WriteData(195UL, value, false);
            }

            public sbyte MemoryUsagePercent
            {
                get => this.ReadDataSByte(200UL, (sbyte)0);
                set => this.WriteData(200UL, value, (sbyte)0);
            }

            public sbyte CpuUsagePercentDEPRECATED
            {
                get => this.ReadDataSByte(352UL, (sbyte)0);
                set => this.WriteData(352UL, value, (sbyte)0);
            }

            public ushort Pa0DEPRECATED
            {
                get => this.ReadDataUShort(368UL, (ushort)0);
                set => this.WriteData(368UL, value, (ushort)0);
            }

            public Cereal.DeviceState.NetworkType TheNetworkType
            {
                get => (Cereal.DeviceState.NetworkType)this.ReadDataUShort(384UL, (ushort)0);
                set => this.WriteData(384UL, (ushort)value, (ushort)0);
            }

            public uint OffroadPowerUsageUwh
            {
                get => this.ReadDataUInt(416UL, 0U);
                set => this.WriteData(416UL, value, 0U);
            }

            public Cereal.DeviceState.NetworkStrength TheNetworkStrength
            {
                get => (Cereal.DeviceState.NetworkStrength)this.ReadDataUShort(400UL, (ushort)0);
                set => this.WriteData(400UL, (ushort)value, (ushort)0);
            }

            public uint CarBatteryCapacityUwh
            {
                get => this.ReadDataUInt(448UL, 0U);
                set => this.WriteData(448UL, value, 0U);
            }

            public ListOfPrimitivesSerializer<float> CpuTempC
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(1);
                set => Link(1, value);
            }

            public ListOfPrimitivesSerializer<float> GpuTempC
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(2);
                set => Link(2, value);
            }

            public float MemoryTempC
            {
                get => this.ReadDataFloat(480UL, 0F);
                set => this.WriteData(480UL, value, 0F);
            }

            public float BatteryTempCDEPRECATED
            {
                get => this.ReadDataFloat(512UL, 0F);
                set => this.WriteData(512UL, value, 0F);
            }

            public float AmbientTempC
            {
                get => this.ReadDataFloat(544UL, 0F);
                set => this.WriteData(544UL, value, 0F);
            }

            public Cereal.DeviceState.NetworkInfo.WRITER TheNetworkInfo
            {
                get => BuildPointer<Cereal.DeviceState.NetworkInfo.WRITER>(3);
                set => Link(3, value);
            }

            public ulong LastAthenaPingTime
            {
                get => this.ReadDataULong(576UL, 0UL);
                set => this.WriteData(576UL, value, 0UL);
            }

            public sbyte GpuUsagePercent
            {
                get => this.ReadDataSByte(360UL, (sbyte)0);
                set => this.WriteData(360UL, value, (sbyte)0);
            }

            public ListOfPrimitivesSerializer<sbyte> CpuUsagePercent
            {
                get => BuildPointer<ListOfPrimitivesSerializer<sbyte>>(4);
                set => Link(4, value);
            }

            public ListOfPrimitivesSerializer<float> NvmeTempC
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(5);
                set => Link(5, value);
            }

            public ListOfPrimitivesSerializer<float> ModemTempC
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(6);
                set => Link(6, value);
            }

            public sbyte ScreenBrightnessPercent
            {
                get => this.ReadDataSByte(640UL, (sbyte)0);
                set => this.WriteData(640UL, value, (sbyte)0);
            }

            public ListOfStructsSerializer<Cereal.DeviceState.ThermalZone.WRITER> ThermalZones
            {
                get => BuildPointer<ListOfStructsSerializer<Cereal.DeviceState.ThermalZone.WRITER>>(7);
                set => Link(7, value);
            }

            public ListOfPrimitivesSerializer<float> PmicTempC
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(8);
                set => Link(8, value);
            }

            public float PowerDrawW
            {
                get => this.ReadDataFloat(672UL, 0F);
                set => this.WriteData(672UL, value, 0F);
            }

            public bool NetworkMetered
            {
                get => this.ReadDataBool(196UL, false);
                set => this.WriteData(196UL, value, false);
            }

            public float SomPowerDrawW
            {
                get => this.ReadDataFloat(704UL, 0F);
                set => this.WriteData(704UL, value, 0F);
            }

            public Cereal.DeviceState.NetworkStats.WRITER TheNetworkStats
            {
                get => BuildPointer<Cereal.DeviceState.NetworkStats.WRITER>(9);
                set => Link(9, value);
            }

            public float MaxTempC
            {
                get => this.ReadDataFloat(736UL, 0F);
                set => this.WriteData(736UL, value, 0F);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xd0790029853df66fUL)]
        public class ThermalZone : ICapnpSerializable
        {
            public const UInt64 typeId = 0xd0790029853df66fUL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Name = reader.Name;
                Temp = reader.Temp;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Name = Name;
                writer.Temp = Temp;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public string Name
            {
                get;
                set;
            }

            public float Temp
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public string Name => ctx.ReadText(0, null);
                public float Temp => ctx.ReadDataFloat(0UL, 0F);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(1, 1);
                }

                public string Name
                {
                    get => this.ReadText(0, null);
                    set => this.WriteText(0, value, null);
                }

                public float Temp
                {
                    get => this.ReadDataFloat(0UL, 0F);
                    set => this.WriteData(0UL, value, 0F);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xaf0f7110c254f77eUL)]
        public enum ThermalStatus : ushort
        {
            green,
            yellow,
            red,
            danger
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xbbc79cc958d1049dUL)]
        public enum NetworkType : ushort
        {
            none,
            wifi,
            cell2G,
            cell3G,
            cell4G,
            cell5G,
            ethernet
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xdd308c8a13203e13UL)]
        public enum NetworkStrength : ushort
        {
            unknown,
            poor,
            moderate,
            good,
            great
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x9d57532d82c04afcUL)]
        public class NetworkInfo : ICapnpSerializable
        {
            public const UInt64 typeId = 0x9d57532d82c04afcUL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Technology = reader.Technology;
                Operator = reader.Operator;
                Band = reader.Band;
                Channel = reader.Channel;
                Extra = reader.Extra;
                State = reader.State;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Technology = Technology;
                writer.Operator = Operator;
                writer.Band = Band;
                writer.Channel = Channel;
                writer.Extra = Extra;
                writer.State = State;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public string Technology
            {
                get;
                set;
            }

            public string Operator
            {
                get;
                set;
            }

            public string Band
            {
                get;
                set;
            }

            public ushort Channel
            {
                get;
                set;
            }

            public string Extra
            {
                get;
                set;
            }

            public string State
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public string Technology => ctx.ReadText(0, null);
                public string Operator => ctx.ReadText(1, null);
                public string Band => ctx.ReadText(2, null);
                public ushort Channel => ctx.ReadDataUShort(0UL, (ushort)0);
                public string Extra => ctx.ReadText(3, null);
                public string State => ctx.ReadText(4, null);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(1, 5);
                }

                public string Technology
                {
                    get => this.ReadText(0, null);
                    set => this.WriteText(0, value, null);
                }

                public string Operator
                {
                    get => this.ReadText(1, null);
                    set => this.WriteText(1, value, null);
                }

                public string Band
                {
                    get => this.ReadText(2, null);
                    set => this.WriteText(2, value, null);
                }

                public ushort Channel
                {
                    get => this.ReadDataUShort(0UL, (ushort)0);
                    set => this.WriteData(0UL, value, (ushort)0);
                }

                public string Extra
                {
                    get => this.ReadText(3, null);
                    set => this.WriteText(3, value, null);
                }

                public string State
                {
                    get => this.ReadText(4, null);
                    set => this.WriteText(4, value, null);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xb98c64ea27898ea0UL)]
        public class NetworkStats : ICapnpSerializable
        {
            public const UInt64 typeId = 0xb98c64ea27898ea0UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                WwanTx = reader.WwanTx;
                WwanRx = reader.WwanRx;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.WwanTx = WwanTx;
                writer.WwanRx = WwanRx;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public long WwanTx
            {
                get;
                set;
            }

            public long WwanRx
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public long WwanTx => ctx.ReadDataLong(0UL, 0L);
                public long WwanRx => ctx.ReadDataLong(64UL, 0L);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(2, 0);
                }

                public long WwanTx
                {
                    get => this.ReadDataLong(0UL, 0L);
                    set => this.WriteData(0UL, value, 0L);
                }

                public long WwanRx
                {
                    get => this.ReadDataLong(64UL, 0L);
                    set => this.WriteData(64UL, value, 0L);
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xa7649e2575e4591eUL)]
    public class PandaState : ICapnpSerializable
    {
        public const UInt64 typeId = 0xa7649e2575e4591eUL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            Voltage = reader.Voltage;
            Current = reader.Current;
            IgnitionLine = reader.IgnitionLine;
            ControlsAllowed = reader.ControlsAllowed;
            GasInterceptorDetectedDEPRECATED = reader.GasInterceptorDetectedDEPRECATED;
            StartedSignalDetectedDEPRECATED = reader.StartedSignalDetectedDEPRECATED;
            HasGpsDEPRECATED = reader.HasGpsDEPRECATED;
            RxBufferOverflow = reader.RxBufferOverflow;
            TxBufferOverflow = reader.TxBufferOverflow;
            GmlanSendErrs = reader.GmlanSendErrs;
            ThePandaType = reader.ThePandaType;
            FanSpeedRpmDEPRECATED = reader.FanSpeedRpmDEPRECATED;
            UsbPowerModeDEPRECATED = reader.UsbPowerModeDEPRECATED;
            IgnitionCan = reader.IgnitionCan;
            SafetyModel = reader.SafetyModel;
            TheFaultStatus = reader.TheFaultStatus;
            PowerSaveEnabled = reader.PowerSaveEnabled;
            Uptime = reader.Uptime;
            Faults = reader.Faults;
            SafetyRxInvalid = reader.SafetyRxInvalid;
            SafetyParamDEPRECATED = reader.SafetyParamDEPRECATED;
            TheHarnessStatus = reader.TheHarnessStatus;
            HeartbeatLost = reader.HeartbeatLost;
            AlternativeExperience = reader.AlternativeExperience;
            SafetyTxBlocked = reader.SafetyTxBlocked;
            InterruptLoad = reader.InterruptLoad;
            SafetyParam2DEPRECATED = reader.SafetyParam2DEPRECATED;
            SafetyParam = reader.SafetyParam;
            FanPower = reader.FanPower;
            CanState0 = CapnpSerializable.Create<Cereal.PandaState.PandaCanState>(reader.CanState0);
            CanState1 = CapnpSerializable.Create<Cereal.PandaState.PandaCanState>(reader.CanState1);
            CanState2 = CapnpSerializable.Create<Cereal.PandaState.PandaCanState>(reader.CanState2);
            SafetyRxChecksInvalid = reader.SafetyRxChecksInvalid;
            SpiChecksumErrorCount = reader.SpiChecksumErrorCount;
            FanStallCount = reader.FanStallCount;
            Sbu1Voltage = reader.Sbu1Voltage;
            Sbu2Voltage = reader.Sbu2Voltage;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.Voltage = Voltage;
            writer.Current = Current;
            writer.IgnitionLine = IgnitionLine;
            writer.ControlsAllowed = ControlsAllowed;
            writer.GasInterceptorDetectedDEPRECATED = GasInterceptorDetectedDEPRECATED;
            writer.StartedSignalDetectedDEPRECATED = StartedSignalDetectedDEPRECATED;
            writer.HasGpsDEPRECATED = HasGpsDEPRECATED;
            writer.RxBufferOverflow = RxBufferOverflow;
            writer.TxBufferOverflow = TxBufferOverflow;
            writer.GmlanSendErrs = GmlanSendErrs;
            writer.ThePandaType = ThePandaType;
            writer.FanSpeedRpmDEPRECATED = FanSpeedRpmDEPRECATED;
            writer.UsbPowerModeDEPRECATED = UsbPowerModeDEPRECATED;
            writer.IgnitionCan = IgnitionCan;
            writer.SafetyModel = SafetyModel;
            writer.TheFaultStatus = TheFaultStatus;
            writer.PowerSaveEnabled = PowerSaveEnabled;
            writer.Uptime = Uptime;
            writer.Faults.Init(Faults);
            writer.SafetyRxInvalid = SafetyRxInvalid;
            writer.SafetyParamDEPRECATED = SafetyParamDEPRECATED;
            writer.TheHarnessStatus = TheHarnessStatus;
            writer.HeartbeatLost = HeartbeatLost;
            writer.AlternativeExperience = AlternativeExperience;
            writer.SafetyTxBlocked = SafetyTxBlocked;
            writer.InterruptLoad = InterruptLoad;
            writer.SafetyParam2DEPRECATED = SafetyParam2DEPRECATED;
            writer.SafetyParam = SafetyParam;
            writer.FanPower = FanPower;
            CanState0?.serialize(writer.CanState0);
            CanState1?.serialize(writer.CanState1);
            CanState2?.serialize(writer.CanState2);
            writer.SafetyRxChecksInvalid = SafetyRxChecksInvalid;
            writer.SpiChecksumErrorCount = SpiChecksumErrorCount;
            writer.FanStallCount = FanStallCount;
            writer.Sbu1Voltage = Sbu1Voltage;
            writer.Sbu2Voltage = Sbu2Voltage;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public uint Voltage
        {
            get;
            set;
        }

        public uint Current
        {
            get;
            set;
        }

        public bool IgnitionLine
        {
            get;
            set;
        }

        public bool ControlsAllowed
        {
            get;
            set;
        }

        public bool GasInterceptorDetectedDEPRECATED
        {
            get;
            set;
        }

        public bool StartedSignalDetectedDEPRECATED
        {
            get;
            set;
        }

        public bool HasGpsDEPRECATED
        {
            get;
            set;
        }

        public uint RxBufferOverflow
        {
            get;
            set;
        }

        public uint TxBufferOverflow
        {
            get;
            set;
        }

        public uint GmlanSendErrs
        {
            get;
            set;
        }

        public Cereal.PandaState.PandaType ThePandaType
        {
            get;
            set;
        }

        public ushort FanSpeedRpmDEPRECATED
        {
            get;
            set;
        }

        public Cereal.PeripheralState.UsbPowerModeDEPRECATED UsbPowerModeDEPRECATED
        {
            get;
            set;
        }

        public bool IgnitionCan
        {
            get;
            set;
        }

        public Cereal.CarParams.SafetyModel SafetyModel
        {
            get;
            set;
        }

        public Cereal.PandaState.FaultStatus TheFaultStatus
        {
            get;
            set;
        }

        public bool PowerSaveEnabled
        {
            get;
            set;
        }

        public uint Uptime
        {
            get;
            set;
        }

        public IReadOnlyList<Cereal.PandaState.FaultType> Faults
        {
            get;
            set;
        }

        public uint SafetyRxInvalid
        {
            get;
            set;
        }

        public short SafetyParamDEPRECATED
        {
            get;
            set;
        }

        public Cereal.PandaState.HarnessStatus TheHarnessStatus
        {
            get;
            set;
        }

        public bool HeartbeatLost
        {
            get;
            set;
        }

        public short AlternativeExperience
        {
            get;
            set;
        }

        public uint SafetyTxBlocked
        {
            get;
            set;
        }

        public float InterruptLoad
        {
            get;
            set;
        }

        public uint SafetyParam2DEPRECATED
        {
            get;
            set;
        }

        public ushort SafetyParam
        {
            get;
            set;
        }

        public byte FanPower
        {
            get;
            set;
        }

        public Cereal.PandaState.PandaCanState CanState0
        {
            get;
            set;
        }

        public Cereal.PandaState.PandaCanState CanState1
        {
            get;
            set;
        }

        public Cereal.PandaState.PandaCanState CanState2
        {
            get;
            set;
        }

        public bool SafetyRxChecksInvalid
        {
            get;
            set;
        }

        public ushort SpiChecksumErrorCount
        {
            get;
            set;
        }

        public byte FanStallCount
        {
            get;
            set;
        }

        public float Sbu1Voltage
        {
            get;
            set;
        }

        public float Sbu2Voltage
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public uint Voltage => ctx.ReadDataUInt(0UL, 0U);
            public uint Current => ctx.ReadDataUInt(32UL, 0U);
            public bool IgnitionLine => ctx.ReadDataBool(64UL, false);
            public bool ControlsAllowed => ctx.ReadDataBool(65UL, false);
            public bool GasInterceptorDetectedDEPRECATED => ctx.ReadDataBool(66UL, false);
            public bool StartedSignalDetectedDEPRECATED => ctx.ReadDataBool(67UL, false);
            public bool HasGpsDEPRECATED => ctx.ReadDataBool(68UL, false);
            public uint RxBufferOverflow => ctx.ReadDataUInt(96UL, 0U);
            public uint TxBufferOverflow => ctx.ReadDataUInt(128UL, 0U);
            public uint GmlanSendErrs => ctx.ReadDataUInt(160UL, 0U);
            public Cereal.PandaState.PandaType ThePandaType => (Cereal.PandaState.PandaType)ctx.ReadDataUShort(80UL, (ushort)0);
            public ushort FanSpeedRpmDEPRECATED => ctx.ReadDataUShort(192UL, (ushort)0);
            public Cereal.PeripheralState.UsbPowerModeDEPRECATED UsbPowerModeDEPRECATED => (Cereal.PeripheralState.UsbPowerModeDEPRECATED)ctx.ReadDataUShort(208UL, (ushort)0);
            public bool IgnitionCan => ctx.ReadDataBool(69UL, false);
            public Cereal.CarParams.SafetyModel SafetyModel => (Cereal.CarParams.SafetyModel)ctx.ReadDataUShort(224UL, (ushort)0);
            public Cereal.PandaState.FaultStatus TheFaultStatus => (Cereal.PandaState.FaultStatus)ctx.ReadDataUShort(240UL, (ushort)0);
            public bool PowerSaveEnabled => ctx.ReadDataBool(70UL, false);
            public uint Uptime => ctx.ReadDataUInt(256UL, 0U);
            public IReadOnlyList<Cereal.PandaState.FaultType> Faults => ctx.ReadList(0).CastEnums(_0 => (Cereal.PandaState.FaultType)_0);
            public uint SafetyRxInvalid => ctx.ReadDataUInt(288UL, 0U);
            public short SafetyParamDEPRECATED => ctx.ReadDataShort(320UL, (short)0);
            public Cereal.PandaState.HarnessStatus TheHarnessStatus => (Cereal.PandaState.HarnessStatus)ctx.ReadDataUShort(336UL, (ushort)0);
            public bool HeartbeatLost => ctx.ReadDataBool(71UL, false);
            public short AlternativeExperience => ctx.ReadDataShort(352UL, (short)0);
            public uint SafetyTxBlocked => ctx.ReadDataUInt(384UL, 0U);
            public float InterruptLoad => ctx.ReadDataFloat(416UL, 0F);
            public uint SafetyParam2DEPRECATED => ctx.ReadDataUInt(448UL, 0U);
            public ushort SafetyParam => ctx.ReadDataUShort(368UL, (ushort)0);
            public byte FanPower => ctx.ReadDataByte(72UL, (byte)0);
            public Cereal.PandaState.PandaCanState.READER CanState0 => ctx.ReadStruct(1, Cereal.PandaState.PandaCanState.READER.create);
            public Cereal.PandaState.PandaCanState.READER CanState1 => ctx.ReadStruct(2, Cereal.PandaState.PandaCanState.READER.create);
            public Cereal.PandaState.PandaCanState.READER CanState2 => ctx.ReadStruct(3, Cereal.PandaState.PandaCanState.READER.create);
            public bool SafetyRxChecksInvalid => ctx.ReadDataBool(480UL, false);
            public ushort SpiChecksumErrorCount => ctx.ReadDataUShort(496UL, (ushort)0);
            public byte FanStallCount => ctx.ReadDataByte(488UL, (byte)0);
            public float Sbu1Voltage => ctx.ReadDataFloat(512UL, 0F);
            public float Sbu2Voltage => ctx.ReadDataFloat(544UL, 0F);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(9, 4);
            }

            public uint Voltage
            {
                get => this.ReadDataUInt(0UL, 0U);
                set => this.WriteData(0UL, value, 0U);
            }

            public uint Current
            {
                get => this.ReadDataUInt(32UL, 0U);
                set => this.WriteData(32UL, value, 0U);
            }

            public bool IgnitionLine
            {
                get => this.ReadDataBool(64UL, false);
                set => this.WriteData(64UL, value, false);
            }

            public bool ControlsAllowed
            {
                get => this.ReadDataBool(65UL, false);
                set => this.WriteData(65UL, value, false);
            }

            public bool GasInterceptorDetectedDEPRECATED
            {
                get => this.ReadDataBool(66UL, false);
                set => this.WriteData(66UL, value, false);
            }

            public bool StartedSignalDetectedDEPRECATED
            {
                get => this.ReadDataBool(67UL, false);
                set => this.WriteData(67UL, value, false);
            }

            public bool HasGpsDEPRECATED
            {
                get => this.ReadDataBool(68UL, false);
                set => this.WriteData(68UL, value, false);
            }

            public uint RxBufferOverflow
            {
                get => this.ReadDataUInt(96UL, 0U);
                set => this.WriteData(96UL, value, 0U);
            }

            public uint TxBufferOverflow
            {
                get => this.ReadDataUInt(128UL, 0U);
                set => this.WriteData(128UL, value, 0U);
            }

            public uint GmlanSendErrs
            {
                get => this.ReadDataUInt(160UL, 0U);
                set => this.WriteData(160UL, value, 0U);
            }

            public Cereal.PandaState.PandaType ThePandaType
            {
                get => (Cereal.PandaState.PandaType)this.ReadDataUShort(80UL, (ushort)0);
                set => this.WriteData(80UL, (ushort)value, (ushort)0);
            }

            public ushort FanSpeedRpmDEPRECATED
            {
                get => this.ReadDataUShort(192UL, (ushort)0);
                set => this.WriteData(192UL, value, (ushort)0);
            }

            public Cereal.PeripheralState.UsbPowerModeDEPRECATED UsbPowerModeDEPRECATED
            {
                get => (Cereal.PeripheralState.UsbPowerModeDEPRECATED)this.ReadDataUShort(208UL, (ushort)0);
                set => this.WriteData(208UL, (ushort)value, (ushort)0);
            }

            public bool IgnitionCan
            {
                get => this.ReadDataBool(69UL, false);
                set => this.WriteData(69UL, value, false);
            }

            public Cereal.CarParams.SafetyModel SafetyModel
            {
                get => (Cereal.CarParams.SafetyModel)this.ReadDataUShort(224UL, (ushort)0);
                set => this.WriteData(224UL, (ushort)value, (ushort)0);
            }

            public Cereal.PandaState.FaultStatus TheFaultStatus
            {
                get => (Cereal.PandaState.FaultStatus)this.ReadDataUShort(240UL, (ushort)0);
                set => this.WriteData(240UL, (ushort)value, (ushort)0);
            }

            public bool PowerSaveEnabled
            {
                get => this.ReadDataBool(70UL, false);
                set => this.WriteData(70UL, value, false);
            }

            public uint Uptime
            {
                get => this.ReadDataUInt(256UL, 0U);
                set => this.WriteData(256UL, value, 0U);
            }

            public ListOfPrimitivesSerializer<Cereal.PandaState.FaultType> Faults
            {
                get => BuildPointer<ListOfPrimitivesSerializer<Cereal.PandaState.FaultType>>(0);
                set => Link(0, value);
            }

            public uint SafetyRxInvalid
            {
                get => this.ReadDataUInt(288UL, 0U);
                set => this.WriteData(288UL, value, 0U);
            }

            public short SafetyParamDEPRECATED
            {
                get => this.ReadDataShort(320UL, (short)0);
                set => this.WriteData(320UL, value, (short)0);
            }

            public Cereal.PandaState.HarnessStatus TheHarnessStatus
            {
                get => (Cereal.PandaState.HarnessStatus)this.ReadDataUShort(336UL, (ushort)0);
                set => this.WriteData(336UL, (ushort)value, (ushort)0);
            }

            public bool HeartbeatLost
            {
                get => this.ReadDataBool(71UL, false);
                set => this.WriteData(71UL, value, false);
            }

            public short AlternativeExperience
            {
                get => this.ReadDataShort(352UL, (short)0);
                set => this.WriteData(352UL, value, (short)0);
            }

            public uint SafetyTxBlocked
            {
                get => this.ReadDataUInt(384UL, 0U);
                set => this.WriteData(384UL, value, 0U);
            }

            public float InterruptLoad
            {
                get => this.ReadDataFloat(416UL, 0F);
                set => this.WriteData(416UL, value, 0F);
            }

            public uint SafetyParam2DEPRECATED
            {
                get => this.ReadDataUInt(448UL, 0U);
                set => this.WriteData(448UL, value, 0U);
            }

            public ushort SafetyParam
            {
                get => this.ReadDataUShort(368UL, (ushort)0);
                set => this.WriteData(368UL, value, (ushort)0);
            }

            public byte FanPower
            {
                get => this.ReadDataByte(72UL, (byte)0);
                set => this.WriteData(72UL, value, (byte)0);
            }

            public Cereal.PandaState.PandaCanState.WRITER CanState0
            {
                get => BuildPointer<Cereal.PandaState.PandaCanState.WRITER>(1);
                set => Link(1, value);
            }

            public Cereal.PandaState.PandaCanState.WRITER CanState1
            {
                get => BuildPointer<Cereal.PandaState.PandaCanState.WRITER>(2);
                set => Link(2, value);
            }

            public Cereal.PandaState.PandaCanState.WRITER CanState2
            {
                get => BuildPointer<Cereal.PandaState.PandaCanState.WRITER>(3);
                set => Link(3, value);
            }

            public bool SafetyRxChecksInvalid
            {
                get => this.ReadDataBool(480UL, false);
                set => this.WriteData(480UL, value, false);
            }

            public ushort SpiChecksumErrorCount
            {
                get => this.ReadDataUShort(496UL, (ushort)0);
                set => this.WriteData(496UL, value, (ushort)0);
            }

            public byte FanStallCount
            {
                get => this.ReadDataByte(488UL, (byte)0);
                set => this.WriteData(488UL, value, (byte)0);
            }

            public float Sbu1Voltage
            {
                get => this.ReadDataFloat(512UL, 0F);
                set => this.WriteData(512UL, value, 0F);
            }

            public float Sbu2Voltage
            {
                get => this.ReadDataFloat(544UL, 0F);
                set => this.WriteData(544UL, value, 0F);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xf2fd0b8b0ac9adbbUL)]
        public enum FaultStatus : ushort
        {
            none,
            faultTemp,
            faultPerm
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xcd55c07f69249798UL)]
        public enum FaultType : ushort
        {
            relayMalfunction,
            unusedInterruptHandled,
            interruptRateCan1,
            interruptRateCan2,
            interruptRateCan3,
            interruptRateTach,
            interruptRateGmlan,
            interruptRateInterrupts,
            interruptRateSpiDma,
            interruptRateSpiCs,
            interruptRateUart1,
            interruptRateUart2,
            interruptRateUart3,
            interruptRateUart5,
            interruptRateUartDma,
            interruptRateUsb,
            interruptRateTim1,
            interruptRateTim3,
            registerDivergent,
            interruptRateKlineInit,
            interruptRateClockSource,
            interruptRateTick,
            interruptRateExti,
            interruptRateSpi,
            interruptRateUart7,
            sirenMalfunction,
            heartbeatLoopWatchdog
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x8a58adf93e5b3751UL)]
        public enum PandaType : ushort
        {
            unknown,
            whitePanda,
            greyPanda,
            blackPanda,
            pedal,
            uno,
            dos,
            redPanda,
            redPandaV2,
            tres,
            cuatro
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xf69a3ed1e8c081bfUL)]
        public enum HarnessStatus : ushort
        {
            notConnected,
            normal,
            flipped
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xf8d2972deb0cd45cUL)]
        public class PandaCanState : ICapnpSerializable
        {
            public const UInt64 typeId = 0xf8d2972deb0cd45cUL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                BusOff = reader.BusOff;
                BusOffCnt = reader.BusOffCnt;
                ErrorWarning = reader.ErrorWarning;
                ErrorPassive = reader.ErrorPassive;
                LastError = reader.LastError;
                LastStoredError = reader.LastStoredError;
                LastDataError = reader.LastDataError;
                LastDataStoredError = reader.LastDataStoredError;
                ReceiveErrorCnt = reader.ReceiveErrorCnt;
                TransmitErrorCnt = reader.TransmitErrorCnt;
                TotalErrorCnt = reader.TotalErrorCnt;
                TotalTxLostCnt = reader.TotalTxLostCnt;
                TotalRxLostCnt = reader.TotalRxLostCnt;
                TotalTxCnt = reader.TotalTxCnt;
                TotalRxCnt = reader.TotalRxCnt;
                TotalFwdCnt = reader.TotalFwdCnt;
                CanSpeed = reader.CanSpeed;
                CanDataSpeed = reader.CanDataSpeed;
                CanfdEnabled = reader.CanfdEnabled;
                BrsEnabled = reader.BrsEnabled;
                CanfdNonIso = reader.CanfdNonIso;
                Irq0CallRate = reader.Irq0CallRate;
                Irq1CallRate = reader.Irq1CallRate;
                Irq2CallRate = reader.Irq2CallRate;
                CanCoreResetCnt = reader.CanCoreResetCnt;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.BusOff = BusOff;
                writer.BusOffCnt = BusOffCnt;
                writer.ErrorWarning = ErrorWarning;
                writer.ErrorPassive = ErrorPassive;
                writer.LastError = LastError;
                writer.LastStoredError = LastStoredError;
                writer.LastDataError = LastDataError;
                writer.LastDataStoredError = LastDataStoredError;
                writer.ReceiveErrorCnt = ReceiveErrorCnt;
                writer.TransmitErrorCnt = TransmitErrorCnt;
                writer.TotalErrorCnt = TotalErrorCnt;
                writer.TotalTxLostCnt = TotalTxLostCnt;
                writer.TotalRxLostCnt = TotalRxLostCnt;
                writer.TotalTxCnt = TotalTxCnt;
                writer.TotalRxCnt = TotalRxCnt;
                writer.TotalFwdCnt = TotalFwdCnt;
                writer.CanSpeed = CanSpeed;
                writer.CanDataSpeed = CanDataSpeed;
                writer.CanfdEnabled = CanfdEnabled;
                writer.BrsEnabled = BrsEnabled;
                writer.CanfdNonIso = CanfdNonIso;
                writer.Irq0CallRate = Irq0CallRate;
                writer.Irq1CallRate = Irq1CallRate;
                writer.Irq2CallRate = Irq2CallRate;
                writer.CanCoreResetCnt = CanCoreResetCnt;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public bool BusOff
            {
                get;
                set;
            }

            public uint BusOffCnt
            {
                get;
                set;
            }

            public bool ErrorWarning
            {
                get;
                set;
            }

            public bool ErrorPassive
            {
                get;
                set;
            }

            public Cereal.PandaState.PandaCanState.LecErrorCode LastError
            {
                get;
                set;
            }

            public Cereal.PandaState.PandaCanState.LecErrorCode LastStoredError
            {
                get;
                set;
            }

            public Cereal.PandaState.PandaCanState.LecErrorCode LastDataError
            {
                get;
                set;
            }

            public Cereal.PandaState.PandaCanState.LecErrorCode LastDataStoredError
            {
                get;
                set;
            }

            public byte ReceiveErrorCnt
            {
                get;
                set;
            }

            public byte TransmitErrorCnt
            {
                get;
                set;
            }

            public uint TotalErrorCnt
            {
                get;
                set;
            }

            public uint TotalTxLostCnt
            {
                get;
                set;
            }

            public uint TotalRxLostCnt
            {
                get;
                set;
            }

            public uint TotalTxCnt
            {
                get;
                set;
            }

            public uint TotalRxCnt
            {
                get;
                set;
            }

            public uint TotalFwdCnt
            {
                get;
                set;
            }

            public ushort CanSpeed
            {
                get;
                set;
            }

            public ushort CanDataSpeed
            {
                get;
                set;
            }

            public bool CanfdEnabled
            {
                get;
                set;
            }

            public bool BrsEnabled
            {
                get;
                set;
            }

            public bool CanfdNonIso
            {
                get;
                set;
            }

            public uint Irq0CallRate
            {
                get;
                set;
            }

            public uint Irq1CallRate
            {
                get;
                set;
            }

            public uint Irq2CallRate
            {
                get;
                set;
            }

            public uint CanCoreResetCnt
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public bool BusOff => ctx.ReadDataBool(0UL, false);
                public uint BusOffCnt => ctx.ReadDataUInt(32UL, 0U);
                public bool ErrorWarning => ctx.ReadDataBool(1UL, false);
                public bool ErrorPassive => ctx.ReadDataBool(2UL, false);
                public Cereal.PandaState.PandaCanState.LecErrorCode LastError => (Cereal.PandaState.PandaCanState.LecErrorCode)ctx.ReadDataUShort(16UL, (ushort)0);
                public Cereal.PandaState.PandaCanState.LecErrorCode LastStoredError => (Cereal.PandaState.PandaCanState.LecErrorCode)ctx.ReadDataUShort(64UL, (ushort)0);
                public Cereal.PandaState.PandaCanState.LecErrorCode LastDataError => (Cereal.PandaState.PandaCanState.LecErrorCode)ctx.ReadDataUShort(80UL, (ushort)0);
                public Cereal.PandaState.PandaCanState.LecErrorCode LastDataStoredError => (Cereal.PandaState.PandaCanState.LecErrorCode)ctx.ReadDataUShort(96UL, (ushort)0);
                public byte ReceiveErrorCnt => ctx.ReadDataByte(8UL, (byte)0);
                public byte TransmitErrorCnt => ctx.ReadDataByte(112UL, (byte)0);
                public uint TotalErrorCnt => ctx.ReadDataUInt(128UL, 0U);
                public uint TotalTxLostCnt => ctx.ReadDataUInt(160UL, 0U);
                public uint TotalRxLostCnt => ctx.ReadDataUInt(192UL, 0U);
                public uint TotalTxCnt => ctx.ReadDataUInt(224UL, 0U);
                public uint TotalRxCnt => ctx.ReadDataUInt(256UL, 0U);
                public uint TotalFwdCnt => ctx.ReadDataUInt(288UL, 0U);
                public ushort CanSpeed => ctx.ReadDataUShort(320UL, (ushort)0);
                public ushort CanDataSpeed => ctx.ReadDataUShort(336UL, (ushort)0);
                public bool CanfdEnabled => ctx.ReadDataBool(3UL, false);
                public bool BrsEnabled => ctx.ReadDataBool(4UL, false);
                public bool CanfdNonIso => ctx.ReadDataBool(5UL, false);
                public uint Irq0CallRate => ctx.ReadDataUInt(352UL, 0U);
                public uint Irq1CallRate => ctx.ReadDataUInt(384UL, 0U);
                public uint Irq2CallRate => ctx.ReadDataUInt(416UL, 0U);
                public uint CanCoreResetCnt => ctx.ReadDataUInt(448UL, 0U);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(8, 0);
                }

                public bool BusOff
                {
                    get => this.ReadDataBool(0UL, false);
                    set => this.WriteData(0UL, value, false);
                }

                public uint BusOffCnt
                {
                    get => this.ReadDataUInt(32UL, 0U);
                    set => this.WriteData(32UL, value, 0U);
                }

                public bool ErrorWarning
                {
                    get => this.ReadDataBool(1UL, false);
                    set => this.WriteData(1UL, value, false);
                }

                public bool ErrorPassive
                {
                    get => this.ReadDataBool(2UL, false);
                    set => this.WriteData(2UL, value, false);
                }

                public Cereal.PandaState.PandaCanState.LecErrorCode LastError
                {
                    get => (Cereal.PandaState.PandaCanState.LecErrorCode)this.ReadDataUShort(16UL, (ushort)0);
                    set => this.WriteData(16UL, (ushort)value, (ushort)0);
                }

                public Cereal.PandaState.PandaCanState.LecErrorCode LastStoredError
                {
                    get => (Cereal.PandaState.PandaCanState.LecErrorCode)this.ReadDataUShort(64UL, (ushort)0);
                    set => this.WriteData(64UL, (ushort)value, (ushort)0);
                }

                public Cereal.PandaState.PandaCanState.LecErrorCode LastDataError
                {
                    get => (Cereal.PandaState.PandaCanState.LecErrorCode)this.ReadDataUShort(80UL, (ushort)0);
                    set => this.WriteData(80UL, (ushort)value, (ushort)0);
                }

                public Cereal.PandaState.PandaCanState.LecErrorCode LastDataStoredError
                {
                    get => (Cereal.PandaState.PandaCanState.LecErrorCode)this.ReadDataUShort(96UL, (ushort)0);
                    set => this.WriteData(96UL, (ushort)value, (ushort)0);
                }

                public byte ReceiveErrorCnt
                {
                    get => this.ReadDataByte(8UL, (byte)0);
                    set => this.WriteData(8UL, value, (byte)0);
                }

                public byte TransmitErrorCnt
                {
                    get => this.ReadDataByte(112UL, (byte)0);
                    set => this.WriteData(112UL, value, (byte)0);
                }

                public uint TotalErrorCnt
                {
                    get => this.ReadDataUInt(128UL, 0U);
                    set => this.WriteData(128UL, value, 0U);
                }

                public uint TotalTxLostCnt
                {
                    get => this.ReadDataUInt(160UL, 0U);
                    set => this.WriteData(160UL, value, 0U);
                }

                public uint TotalRxLostCnt
                {
                    get => this.ReadDataUInt(192UL, 0U);
                    set => this.WriteData(192UL, value, 0U);
                }

                public uint TotalTxCnt
                {
                    get => this.ReadDataUInt(224UL, 0U);
                    set => this.WriteData(224UL, value, 0U);
                }

                public uint TotalRxCnt
                {
                    get => this.ReadDataUInt(256UL, 0U);
                    set => this.WriteData(256UL, value, 0U);
                }

                public uint TotalFwdCnt
                {
                    get => this.ReadDataUInt(288UL, 0U);
                    set => this.WriteData(288UL, value, 0U);
                }

                public ushort CanSpeed
                {
                    get => this.ReadDataUShort(320UL, (ushort)0);
                    set => this.WriteData(320UL, value, (ushort)0);
                }

                public ushort CanDataSpeed
                {
                    get => this.ReadDataUShort(336UL, (ushort)0);
                    set => this.WriteData(336UL, value, (ushort)0);
                }

                public bool CanfdEnabled
                {
                    get => this.ReadDataBool(3UL, false);
                    set => this.WriteData(3UL, value, false);
                }

                public bool BrsEnabled
                {
                    get => this.ReadDataBool(4UL, false);
                    set => this.WriteData(4UL, value, false);
                }

                public bool CanfdNonIso
                {
                    get => this.ReadDataBool(5UL, false);
                    set => this.WriteData(5UL, value, false);
                }

                public uint Irq0CallRate
                {
                    get => this.ReadDataUInt(352UL, 0U);
                    set => this.WriteData(352UL, value, 0U);
                }

                public uint Irq1CallRate
                {
                    get => this.ReadDataUInt(384UL, 0U);
                    set => this.WriteData(384UL, value, 0U);
                }

                public uint Irq2CallRate
                {
                    get => this.ReadDataUInt(416UL, 0U);
                    set => this.WriteData(416UL, value, 0U);
                }

                public uint CanCoreResetCnt
                {
                    get => this.ReadDataUInt(448UL, 0U);
                    set => this.WriteData(448UL, value, 0U);
                }
            }

            [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xc0db50b4d13283ffUL)]
            public enum LecErrorCode : ushort
            {
                noError,
                stuffError,
                formError,
                ackError,
                bit1Error,
                bit0Error,
                crcError,
                noChange
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xceb8f49734857a88UL)]
    public class PeripheralState : ICapnpSerializable
    {
        public const UInt64 typeId = 0xceb8f49734857a88UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            PandaType = reader.PandaType;
            Voltage = reader.Voltage;
            Current = reader.Current;
            FanSpeedRpm = reader.FanSpeedRpm;
            TheUsbPowerModeDEPRECATED = reader.TheUsbPowerModeDEPRECATED;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.PandaType = PandaType;
            writer.Voltage = Voltage;
            writer.Current = Current;
            writer.FanSpeedRpm = FanSpeedRpm;
            writer.TheUsbPowerModeDEPRECATED = TheUsbPowerModeDEPRECATED;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public Cereal.PandaState.PandaType PandaType
        {
            get;
            set;
        }

        public uint Voltage
        {
            get;
            set;
        }

        public uint Current
        {
            get;
            set;
        }

        public ushort FanSpeedRpm
        {
            get;
            set;
        }

        public Cereal.PeripheralState.UsbPowerModeDEPRECATED TheUsbPowerModeDEPRECATED
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public Cereal.PandaState.PandaType PandaType => (Cereal.PandaState.PandaType)ctx.ReadDataUShort(0UL, (ushort)0);
            public uint Voltage => ctx.ReadDataUInt(32UL, 0U);
            public uint Current => ctx.ReadDataUInt(64UL, 0U);
            public ushort FanSpeedRpm => ctx.ReadDataUShort(16UL, (ushort)0);
            public Cereal.PeripheralState.UsbPowerModeDEPRECATED TheUsbPowerModeDEPRECATED => (Cereal.PeripheralState.UsbPowerModeDEPRECATED)ctx.ReadDataUShort(96UL, (ushort)0);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(2, 0);
            }

            public Cereal.PandaState.PandaType PandaType
            {
                get => (Cereal.PandaState.PandaType)this.ReadDataUShort(0UL, (ushort)0);
                set => this.WriteData(0UL, (ushort)value, (ushort)0);
            }

            public uint Voltage
            {
                get => this.ReadDataUInt(32UL, 0U);
                set => this.WriteData(32UL, value, 0U);
            }

            public uint Current
            {
                get => this.ReadDataUInt(64UL, 0U);
                set => this.WriteData(64UL, value, 0U);
            }

            public ushort FanSpeedRpm
            {
                get => this.ReadDataUShort(16UL, (ushort)0);
                set => this.WriteData(16UL, value, (ushort)0);
            }

            public Cereal.PeripheralState.UsbPowerModeDEPRECATED TheUsbPowerModeDEPRECATED
            {
                get => (Cereal.PeripheralState.UsbPowerModeDEPRECATED)this.ReadDataUShort(96UL, (ushort)0);
                set => this.WriteData(96UL, (ushort)value, (ushort)0);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xa8883583b32c9877UL)]
        public enum UsbPowerModeDEPRECATED : ushort
        {
            none,
            client,
            cdp,
            dcp
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x9a185389d6fdd05fUL)]
    public class RadarState : ICapnpSerializable
    {
        public const UInt64 typeId = 0x9a185389d6fdd05fUL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            WarpMatrixDEPRECATED = reader.WarpMatrixDEPRECATED;
            AngleOffsetDEPRECATED = reader.AngleOffsetDEPRECATED;
            CalStatusDEPRECATED = reader.CalStatusDEPRECATED;
            LeadOne = CapnpSerializable.Create<Cereal.RadarState.LeadData>(reader.LeadOne);
            LeadTwo = CapnpSerializable.Create<Cereal.RadarState.LeadData>(reader.LeadTwo);
            CumLagMs = reader.CumLagMs;
            MdMonoTime = reader.MdMonoTime;
            FtMonoTimeDEPRECATED = reader.FtMonoTimeDEPRECATED;
            CalCycleDEPRECATED = reader.CalCycleDEPRECATED;
            CalPercDEPRECATED = reader.CalPercDEPRECATED;
            CanMonoTimesDEPRECATED = reader.CanMonoTimesDEPRECATED;
            CarStateMonoTime = reader.CarStateMonoTime;
            RadarErrors = reader.RadarErrors;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.WarpMatrixDEPRECATED.Init(WarpMatrixDEPRECATED);
            writer.AngleOffsetDEPRECATED = AngleOffsetDEPRECATED;
            writer.CalStatusDEPRECATED = CalStatusDEPRECATED;
            LeadOne?.serialize(writer.LeadOne);
            LeadTwo?.serialize(writer.LeadTwo);
            writer.CumLagMs = CumLagMs;
            writer.MdMonoTime = MdMonoTime;
            writer.FtMonoTimeDEPRECATED = FtMonoTimeDEPRECATED;
            writer.CalCycleDEPRECATED = CalCycleDEPRECATED;
            writer.CalPercDEPRECATED = CalPercDEPRECATED;
            writer.CanMonoTimesDEPRECATED.Init(CanMonoTimesDEPRECATED);
            writer.CarStateMonoTime = CarStateMonoTime;
            writer.RadarErrors.Init(RadarErrors);
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public IReadOnlyList<float> WarpMatrixDEPRECATED
        {
            get;
            set;
        }

        public float AngleOffsetDEPRECATED
        {
            get;
            set;
        }

        public sbyte CalStatusDEPRECATED
        {
            get;
            set;
        }

        public Cereal.RadarState.LeadData LeadOne
        {
            get;
            set;
        }

        public Cereal.RadarState.LeadData LeadTwo
        {
            get;
            set;
        }

        public float CumLagMs
        {
            get;
            set;
        }

        public ulong MdMonoTime
        {
            get;
            set;
        }

        public ulong FtMonoTimeDEPRECATED
        {
            get;
            set;
        }

        public int CalCycleDEPRECATED
        {
            get;
            set;
        }

        public sbyte CalPercDEPRECATED
        {
            get;
            set;
        }

        public IReadOnlyList<ulong> CanMonoTimesDEPRECATED
        {
            get;
            set;
        }

        public ulong CarStateMonoTime
        {
            get;
            set;
        }

        public IReadOnlyList<Cereal.RadarData.Error> RadarErrors
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public IReadOnlyList<float> WarpMatrixDEPRECATED => ctx.ReadList(0).CastFloat();
            public float AngleOffsetDEPRECATED => ctx.ReadDataFloat(0UL, 0F);
            public sbyte CalStatusDEPRECATED => ctx.ReadDataSByte(32UL, (sbyte)0);
            public Cereal.RadarState.LeadData.READER LeadOne => ctx.ReadStruct(1, Cereal.RadarState.LeadData.READER.create);
            public Cereal.RadarState.LeadData.READER LeadTwo => ctx.ReadStruct(2, Cereal.RadarState.LeadData.READER.create);
            public float CumLagMs => ctx.ReadDataFloat(64UL, 0F);
            public ulong MdMonoTime => ctx.ReadDataULong(128UL, 0UL);
            public ulong FtMonoTimeDEPRECATED => ctx.ReadDataULong(192UL, 0UL);
            public int CalCycleDEPRECATED => ctx.ReadDataInt(96UL, 0);
            public sbyte CalPercDEPRECATED => ctx.ReadDataSByte(40UL, (sbyte)0);
            public IReadOnlyList<ulong> CanMonoTimesDEPRECATED => ctx.ReadList(3).CastULong();
            public ulong CarStateMonoTime => ctx.ReadDataULong(256UL, 0UL);
            public IReadOnlyList<Cereal.RadarData.Error> RadarErrors => ctx.ReadList(4).CastEnums(_0 => (Cereal.RadarData.Error)_0);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(5, 5);
            }

            public ListOfPrimitivesSerializer<float> WarpMatrixDEPRECATED
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(0);
                set => Link(0, value);
            }

            public float AngleOffsetDEPRECATED
            {
                get => this.ReadDataFloat(0UL, 0F);
                set => this.WriteData(0UL, value, 0F);
            }

            public sbyte CalStatusDEPRECATED
            {
                get => this.ReadDataSByte(32UL, (sbyte)0);
                set => this.WriteData(32UL, value, (sbyte)0);
            }

            public Cereal.RadarState.LeadData.WRITER LeadOne
            {
                get => BuildPointer<Cereal.RadarState.LeadData.WRITER>(1);
                set => Link(1, value);
            }

            public Cereal.RadarState.LeadData.WRITER LeadTwo
            {
                get => BuildPointer<Cereal.RadarState.LeadData.WRITER>(2);
                set => Link(2, value);
            }

            public float CumLagMs
            {
                get => this.ReadDataFloat(64UL, 0F);
                set => this.WriteData(64UL, value, 0F);
            }

            public ulong MdMonoTime
            {
                get => this.ReadDataULong(128UL, 0UL);
                set => this.WriteData(128UL, value, 0UL);
            }

            public ulong FtMonoTimeDEPRECATED
            {
                get => this.ReadDataULong(192UL, 0UL);
                set => this.WriteData(192UL, value, 0UL);
            }

            public int CalCycleDEPRECATED
            {
                get => this.ReadDataInt(96UL, 0);
                set => this.WriteData(96UL, value, 0);
            }

            public sbyte CalPercDEPRECATED
            {
                get => this.ReadDataSByte(40UL, (sbyte)0);
                set => this.WriteData(40UL, value, (sbyte)0);
            }

            public ListOfPrimitivesSerializer<ulong> CanMonoTimesDEPRECATED
            {
                get => BuildPointer<ListOfPrimitivesSerializer<ulong>>(3);
                set => Link(3, value);
            }

            public ulong CarStateMonoTime
            {
                get => this.ReadDataULong(256UL, 0UL);
                set => this.WriteData(256UL, value, 0UL);
            }

            public ListOfPrimitivesSerializer<Cereal.RadarData.Error> RadarErrors
            {
                get => BuildPointer<ListOfPrimitivesSerializer<Cereal.RadarData.Error>>(4);
                set => Link(4, value);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xb96f3ad9170cf085UL)]
        public class LeadData : ICapnpSerializable
        {
            public const UInt64 typeId = 0xb96f3ad9170cf085UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                DRel = reader.DRel;
                YRel = reader.YRel;
                VRel = reader.VRel;
                ARel = reader.ARel;
                VLead = reader.VLead;
                ALeadDEPRECATED = reader.ALeadDEPRECATED;
                DPath = reader.DPath;
                VLat = reader.VLat;
                VLeadK = reader.VLeadK;
                ALeadK = reader.ALeadK;
                Fcw = reader.Fcw;
                Status = reader.Status;
                ALeadTau = reader.ALeadTau;
                ModelProb = reader.ModelProb;
                Radar = reader.Radar;
                RadarTrackId = reader.RadarTrackId;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.DRel = DRel;
                writer.YRel = YRel;
                writer.VRel = VRel;
                writer.ARel = ARel;
                writer.VLead = VLead;
                writer.ALeadDEPRECATED = ALeadDEPRECATED;
                writer.DPath = DPath;
                writer.VLat = VLat;
                writer.VLeadK = VLeadK;
                writer.ALeadK = ALeadK;
                writer.Fcw = Fcw;
                writer.Status = Status;
                writer.ALeadTau = ALeadTau;
                writer.ModelProb = ModelProb;
                writer.Radar = Radar;
                writer.RadarTrackId = RadarTrackId;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public float DRel
            {
                get;
                set;
            }

            public float YRel
            {
                get;
                set;
            }

            public float VRel
            {
                get;
                set;
            }

            public float ARel
            {
                get;
                set;
            }

            public float VLead
            {
                get;
                set;
            }

            public float ALeadDEPRECATED
            {
                get;
                set;
            }

            public float DPath
            {
                get;
                set;
            }

            public float VLat
            {
                get;
                set;
            }

            public float VLeadK
            {
                get;
                set;
            }

            public float ALeadK
            {
                get;
                set;
            }

            public bool Fcw
            {
                get;
                set;
            }

            public bool Status
            {
                get;
                set;
            }

            public float ALeadTau
            {
                get;
                set;
            }

            public float ModelProb
            {
                get;
                set;
            }

            public bool Radar
            {
                get;
                set;
            }

            public int RadarTrackId
            {
                get;
                set;
            }

            = -1;
            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public float DRel => ctx.ReadDataFloat(0UL, 0F);
                public float YRel => ctx.ReadDataFloat(32UL, 0F);
                public float VRel => ctx.ReadDataFloat(64UL, 0F);
                public float ARel => ctx.ReadDataFloat(96UL, 0F);
                public float VLead => ctx.ReadDataFloat(128UL, 0F);
                public float ALeadDEPRECATED => ctx.ReadDataFloat(160UL, 0F);
                public float DPath => ctx.ReadDataFloat(192UL, 0F);
                public float VLat => ctx.ReadDataFloat(224UL, 0F);
                public float VLeadK => ctx.ReadDataFloat(256UL, 0F);
                public float ALeadK => ctx.ReadDataFloat(288UL, 0F);
                public bool Fcw => ctx.ReadDataBool(320UL, false);
                public bool Status => ctx.ReadDataBool(321UL, false);
                public float ALeadTau => ctx.ReadDataFloat(352UL, 0F);
                public float ModelProb => ctx.ReadDataFloat(384UL, 0F);
                public bool Radar => ctx.ReadDataBool(322UL, false);
                public int RadarTrackId => ctx.ReadDataInt(416UL, -1);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(7, 0);
                }

                public float DRel
                {
                    get => this.ReadDataFloat(0UL, 0F);
                    set => this.WriteData(0UL, value, 0F);
                }

                public float YRel
                {
                    get => this.ReadDataFloat(32UL, 0F);
                    set => this.WriteData(32UL, value, 0F);
                }

                public float VRel
                {
                    get => this.ReadDataFloat(64UL, 0F);
                    set => this.WriteData(64UL, value, 0F);
                }

                public float ARel
                {
                    get => this.ReadDataFloat(96UL, 0F);
                    set => this.WriteData(96UL, value, 0F);
                }

                public float VLead
                {
                    get => this.ReadDataFloat(128UL, 0F);
                    set => this.WriteData(128UL, value, 0F);
                }

                public float ALeadDEPRECATED
                {
                    get => this.ReadDataFloat(160UL, 0F);
                    set => this.WriteData(160UL, value, 0F);
                }

                public float DPath
                {
                    get => this.ReadDataFloat(192UL, 0F);
                    set => this.WriteData(192UL, value, 0F);
                }

                public float VLat
                {
                    get => this.ReadDataFloat(224UL, 0F);
                    set => this.WriteData(224UL, value, 0F);
                }

                public float VLeadK
                {
                    get => this.ReadDataFloat(256UL, 0F);
                    set => this.WriteData(256UL, value, 0F);
                }

                public float ALeadK
                {
                    get => this.ReadDataFloat(288UL, 0F);
                    set => this.WriteData(288UL, value, 0F);
                }

                public bool Fcw
                {
                    get => this.ReadDataBool(320UL, false);
                    set => this.WriteData(320UL, value, false);
                }

                public bool Status
                {
                    get => this.ReadDataBool(321UL, false);
                    set => this.WriteData(321UL, value, false);
                }

                public float ALeadTau
                {
                    get => this.ReadDataFloat(352UL, 0F);
                    set => this.WriteData(352UL, value, 0F);
                }

                public float ModelProb
                {
                    get => this.ReadDataFloat(384UL, 0F);
                    set => this.WriteData(384UL, value, 0F);
                }

                public bool Radar
                {
                    get => this.ReadDataBool(322UL, false);
                    set => this.WriteData(322UL, value, false);
                }

                public int RadarTrackId
                {
                    get => this.ReadDataInt(416UL, -1);
                    set => this.WriteData(416UL, value, -1);
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x96df70754d8390bcUL)]
    public class LiveCalibrationData : ICapnpSerializable
    {
        public const UInt64 typeId = 0x96df70754d8390bcUL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            WarpMatrixDEPRECATED = reader.WarpMatrixDEPRECATED;
            CalStatusDEPRECATED = reader.CalStatusDEPRECATED;
            CalCycle = reader.CalCycle;
            CalPerc = reader.CalPerc;
            ExtrinsicMatrix = reader.ExtrinsicMatrix;
            WarpMatrix2DEPRECATED = reader.WarpMatrix2DEPRECATED;
            WarpMatrixBigDEPRECATED = reader.WarpMatrixBigDEPRECATED;
            RpyCalib = reader.RpyCalib;
            RpyCalibSpread = reader.RpyCalibSpread;
            ValidBlocks = reader.ValidBlocks;
            WideFromDeviceEuler = reader.WideFromDeviceEuler;
            CalStatus = reader.CalStatus;
            Height = reader.Height;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.WarpMatrixDEPRECATED.Init(WarpMatrixDEPRECATED);
            writer.CalStatusDEPRECATED = CalStatusDEPRECATED;
            writer.CalCycle = CalCycle;
            writer.CalPerc = CalPerc;
            writer.ExtrinsicMatrix.Init(ExtrinsicMatrix);
            writer.WarpMatrix2DEPRECATED.Init(WarpMatrix2DEPRECATED);
            writer.WarpMatrixBigDEPRECATED.Init(WarpMatrixBigDEPRECATED);
            writer.RpyCalib.Init(RpyCalib);
            writer.RpyCalibSpread.Init(RpyCalibSpread);
            writer.ValidBlocks = ValidBlocks;
            writer.WideFromDeviceEuler.Init(WideFromDeviceEuler);
            writer.CalStatus = CalStatus;
            writer.Height.Init(Height);
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public IReadOnlyList<float> WarpMatrixDEPRECATED
        {
            get;
            set;
        }

        public sbyte CalStatusDEPRECATED
        {
            get;
            set;
        }

        public int CalCycle
        {
            get;
            set;
        }

        public sbyte CalPerc
        {
            get;
            set;
        }

        public IReadOnlyList<float> ExtrinsicMatrix
        {
            get;
            set;
        }

        public IReadOnlyList<float> WarpMatrix2DEPRECATED
        {
            get;
            set;
        }

        public IReadOnlyList<float> WarpMatrixBigDEPRECATED
        {
            get;
            set;
        }

        public IReadOnlyList<float> RpyCalib
        {
            get;
            set;
        }

        public IReadOnlyList<float> RpyCalibSpread
        {
            get;
            set;
        }

        public int ValidBlocks
        {
            get;
            set;
        }

        public IReadOnlyList<float> WideFromDeviceEuler
        {
            get;
            set;
        }

        public Cereal.LiveCalibrationData.Status CalStatus
        {
            get;
            set;
        }

        public IReadOnlyList<float> Height
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public IReadOnlyList<float> WarpMatrixDEPRECATED => ctx.ReadList(0).CastFloat();
            public sbyte CalStatusDEPRECATED => ctx.ReadDataSByte(0UL, (sbyte)0);
            public int CalCycle => ctx.ReadDataInt(32UL, 0);
            public sbyte CalPerc => ctx.ReadDataSByte(8UL, (sbyte)0);
            public IReadOnlyList<float> ExtrinsicMatrix => ctx.ReadList(1).CastFloat();
            public IReadOnlyList<float> WarpMatrix2DEPRECATED => ctx.ReadList(2).CastFloat();
            public IReadOnlyList<float> WarpMatrixBigDEPRECATED => ctx.ReadList(3).CastFloat();
            public IReadOnlyList<float> RpyCalib => ctx.ReadList(4).CastFloat();
            public IReadOnlyList<float> RpyCalibSpread => ctx.ReadList(5).CastFloat();
            public int ValidBlocks => ctx.ReadDataInt(64UL, 0);
            public IReadOnlyList<float> WideFromDeviceEuler => ctx.ReadList(6).CastFloat();
            public Cereal.LiveCalibrationData.Status CalStatus => (Cereal.LiveCalibrationData.Status)ctx.ReadDataUShort(16UL, (ushort)0);
            public IReadOnlyList<float> Height => ctx.ReadList(7).CastFloat();
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(2, 8);
            }

            public ListOfPrimitivesSerializer<float> WarpMatrixDEPRECATED
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(0);
                set => Link(0, value);
            }

            public sbyte CalStatusDEPRECATED
            {
                get => this.ReadDataSByte(0UL, (sbyte)0);
                set => this.WriteData(0UL, value, (sbyte)0);
            }

            public int CalCycle
            {
                get => this.ReadDataInt(32UL, 0);
                set => this.WriteData(32UL, value, 0);
            }

            public sbyte CalPerc
            {
                get => this.ReadDataSByte(8UL, (sbyte)0);
                set => this.WriteData(8UL, value, (sbyte)0);
            }

            public ListOfPrimitivesSerializer<float> ExtrinsicMatrix
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(1);
                set => Link(1, value);
            }

            public ListOfPrimitivesSerializer<float> WarpMatrix2DEPRECATED
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(2);
                set => Link(2, value);
            }

            public ListOfPrimitivesSerializer<float> WarpMatrixBigDEPRECATED
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(3);
                set => Link(3, value);
            }

            public ListOfPrimitivesSerializer<float> RpyCalib
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(4);
                set => Link(4, value);
            }

            public ListOfPrimitivesSerializer<float> RpyCalibSpread
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(5);
                set => Link(5, value);
            }

            public int ValidBlocks
            {
                get => this.ReadDataInt(64UL, 0);
                set => this.WriteData(64UL, value, 0);
            }

            public ListOfPrimitivesSerializer<float> WideFromDeviceEuler
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(6);
                set => Link(6, value);
            }

            public Cereal.LiveCalibrationData.Status CalStatus
            {
                get => (Cereal.LiveCalibrationData.Status)this.ReadDataUShort(16UL, (ushort)0);
                set => this.WriteData(16UL, (ushort)value, (ushort)0);
            }

            public ListOfPrimitivesSerializer<float> Height
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(7);
                set => Link(7, value);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xcaaa029466ad394dUL)]
        public enum Status : ushort
        {
            uncalibrated,
            calibrated,
            invalid,
            recalibrating
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x8faa644732dec251UL)]
    public class LiveTracks : ICapnpSerializable
    {
        public const UInt64 typeId = 0x8faa644732dec251UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            TrackId = reader.TrackId;
            DRel = reader.DRel;
            YRel = reader.YRel;
            VRel = reader.VRel;
            ARel = reader.ARel;
            TimeStamp = reader.TimeStamp;
            Status = reader.Status;
            CurrentTime = reader.CurrentTime;
            Stationary = reader.Stationary;
            Oncoming = reader.Oncoming;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.TrackId = TrackId;
            writer.DRel = DRel;
            writer.YRel = YRel;
            writer.VRel = VRel;
            writer.ARel = ARel;
            writer.TimeStamp = TimeStamp;
            writer.Status = Status;
            writer.CurrentTime = CurrentTime;
            writer.Stationary = Stationary;
            writer.Oncoming = Oncoming;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public int TrackId
        {
            get;
            set;
        }

        public float DRel
        {
            get;
            set;
        }

        public float YRel
        {
            get;
            set;
        }

        public float VRel
        {
            get;
            set;
        }

        public float ARel
        {
            get;
            set;
        }

        public float TimeStamp
        {
            get;
            set;
        }

        public float Status
        {
            get;
            set;
        }

        public float CurrentTime
        {
            get;
            set;
        }

        public bool Stationary
        {
            get;
            set;
        }

        public bool Oncoming
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public int TrackId => ctx.ReadDataInt(0UL, 0);
            public float DRel => ctx.ReadDataFloat(32UL, 0F);
            public float YRel => ctx.ReadDataFloat(64UL, 0F);
            public float VRel => ctx.ReadDataFloat(96UL, 0F);
            public float ARel => ctx.ReadDataFloat(128UL, 0F);
            public float TimeStamp => ctx.ReadDataFloat(160UL, 0F);
            public float Status => ctx.ReadDataFloat(192UL, 0F);
            public float CurrentTime => ctx.ReadDataFloat(224UL, 0F);
            public bool Stationary => ctx.ReadDataBool(256UL, false);
            public bool Oncoming => ctx.ReadDataBool(257UL, false);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(5, 0);
            }

            public int TrackId
            {
                get => this.ReadDataInt(0UL, 0);
                set => this.WriteData(0UL, value, 0);
            }

            public float DRel
            {
                get => this.ReadDataFloat(32UL, 0F);
                set => this.WriteData(32UL, value, 0F);
            }

            public float YRel
            {
                get => this.ReadDataFloat(64UL, 0F);
                set => this.WriteData(64UL, value, 0F);
            }

            public float VRel
            {
                get => this.ReadDataFloat(96UL, 0F);
                set => this.WriteData(96UL, value, 0F);
            }

            public float ARel
            {
                get => this.ReadDataFloat(128UL, 0F);
                set => this.WriteData(128UL, value, 0F);
            }

            public float TimeStamp
            {
                get => this.ReadDataFloat(160UL, 0F);
                set => this.WriteData(160UL, value, 0F);
            }

            public float Status
            {
                get => this.ReadDataFloat(192UL, 0F);
                set => this.WriteData(192UL, value, 0F);
            }

            public float CurrentTime
            {
                get => this.ReadDataFloat(224UL, 0F);
                set => this.WriteData(224UL, value, 0F);
            }

            public bool Stationary
            {
                get => this.ReadDataBool(256UL, false);
                set => this.WriteData(256UL, value, false);
            }

            public bool Oncoming
            {
                get => this.ReadDataBool(257UL, false);
                set => this.WriteData(257UL, value, false);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x97ff69c53601abf1UL)]
    public class ControlsState : ICapnpSerializable
    {
        public const UInt64 typeId = 0x97ff69c53601abf1UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            VEgoDEPRECATED = reader.VEgoDEPRECATED;
            AEgoDEPRECATED = reader.AEgoDEPRECATED;
            VPid = reader.VPid;
            VTargetLead = reader.VTargetLead;
            UpAccelCmd = reader.UpAccelCmd;
            UiAccelCmd = reader.UiAccelCmd;
            YActualDEPRECATED = reader.YActualDEPRECATED;
            YDesDEPRECATED = reader.YDesDEPRECATED;
            UpSteerDEPRECATED = reader.UpSteerDEPRECATED;
            UiSteerDEPRECATED = reader.UiSteerDEPRECATED;
            ATargetMinDEPRECATED = reader.ATargetMinDEPRECATED;
            ATargetMaxDEPRECATED = reader.ATargetMaxDEPRECATED;
            JerkFactorDEPRECATED = reader.JerkFactorDEPRECATED;
            AngleSteersDEPRECATED = reader.AngleSteersDEPRECATED;
            HudLeadDEPRECATED = reader.HudLeadDEPRECATED;
            CumLagMs = reader.CumLagMs;
            CanMonoTimeDEPRECATED = reader.CanMonoTimeDEPRECATED;
            RadarStateMonoTimeDEPRECATED = reader.RadarStateMonoTimeDEPRECATED;
            MdMonoTimeDEPRECATED = reader.MdMonoTimeDEPRECATED;
            Enabled = reader.Enabled;
            SteerOverrideDEPRECATED = reader.SteerOverrideDEPRECATED;
            CanMonoTimesDEPRECATED = reader.CanMonoTimesDEPRECATED;
            VCruise = reader.VCruise;
            RearViewCamDEPRECATED = reader.RearViewCamDEPRECATED;
            AlertText1 = reader.AlertText1;
            AlertText2 = reader.AlertText2;
            AwarenessStatusDEPRECATED = reader.AwarenessStatusDEPRECATED;
            AngleModelBiasDEPRECATED = reader.AngleModelBiasDEPRECATED;
            LongitudinalPlanMonoTime = reader.LongitudinalPlanMonoTime;
            SteeringAngleDesiredDegDEPRECATED = reader.SteeringAngleDesiredDegDEPRECATED;
            LongControlState = reader.LongControlState;
            State = reader.State;
            VEgoRawDEPRECATED = reader.VEgoRawDEPRECATED;
            UfAccelCmd = reader.UfAccelCmd;
            UfSteerDEPRECATED = reader.UfSteerDEPRECATED;
            ATarget = reader.ATarget;
            Active = reader.Active;
            Curvature = reader.Curvature;
            TheAlertStatus = reader.TheAlertStatus;
            TheAlertSize = reader.TheAlertSize;
            GpsPlannerActiveDEPRECATED = reader.GpsPlannerActiveDEPRECATED;
            Engageable = reader.Engageable;
            AlertBlinkingRate = reader.AlertBlinkingRate;
            DriverMonitoringOnDEPRECATED = reader.DriverMonitoringOnDEPRECATED;
            AlertType = reader.AlertType;
            AlertSoundDEPRECATED = reader.AlertSoundDEPRECATED;
            VCurvatureDEPRECATED = reader.VCurvatureDEPRECATED;
            DecelForTurnDEPRECATED = reader.DecelForTurnDEPRECATED;
            StartMonoTime = reader.StartMonoTime;
            MapValidDEPRECATED = reader.MapValidDEPRECATED;
            LateralPlanMonoTime = reader.LateralPlanMonoTime;
            ForceDecel = reader.ForceDecel;
            LateralControlState = CapnpSerializable.Create<Cereal.ControlsState.lateralControlState>(reader.LateralControlState);
            DecelForModelDEPRECATED = reader.DecelForModelDEPRECATED;
            AlertSound = reader.AlertSound;
            CanErrorCounter = reader.CanErrorCounter;
            DesiredCurvature = reader.DesiredCurvature;
            DesiredCurvatureRateDEPRECATED = reader.DesiredCurvatureRateDEPRECATED;
            VCruiseCluster = reader.VCruiseCluster;
            ExperimentalMode = reader.ExperimentalMode;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.VEgoDEPRECATED = VEgoDEPRECATED;
            writer.AEgoDEPRECATED = AEgoDEPRECATED;
            writer.VPid = VPid;
            writer.VTargetLead = VTargetLead;
            writer.UpAccelCmd = UpAccelCmd;
            writer.UiAccelCmd = UiAccelCmd;
            writer.YActualDEPRECATED = YActualDEPRECATED;
            writer.YDesDEPRECATED = YDesDEPRECATED;
            writer.UpSteerDEPRECATED = UpSteerDEPRECATED;
            writer.UiSteerDEPRECATED = UiSteerDEPRECATED;
            writer.ATargetMinDEPRECATED = ATargetMinDEPRECATED;
            writer.ATargetMaxDEPRECATED = ATargetMaxDEPRECATED;
            writer.JerkFactorDEPRECATED = JerkFactorDEPRECATED;
            writer.AngleSteersDEPRECATED = AngleSteersDEPRECATED;
            writer.HudLeadDEPRECATED = HudLeadDEPRECATED;
            writer.CumLagMs = CumLagMs;
            writer.CanMonoTimeDEPRECATED = CanMonoTimeDEPRECATED;
            writer.RadarStateMonoTimeDEPRECATED = RadarStateMonoTimeDEPRECATED;
            writer.MdMonoTimeDEPRECATED = MdMonoTimeDEPRECATED;
            writer.Enabled = Enabled;
            writer.SteerOverrideDEPRECATED = SteerOverrideDEPRECATED;
            writer.CanMonoTimesDEPRECATED.Init(CanMonoTimesDEPRECATED);
            writer.VCruise = VCruise;
            writer.RearViewCamDEPRECATED = RearViewCamDEPRECATED;
            writer.AlertText1 = AlertText1;
            writer.AlertText2 = AlertText2;
            writer.AwarenessStatusDEPRECATED = AwarenessStatusDEPRECATED;
            writer.AngleModelBiasDEPRECATED = AngleModelBiasDEPRECATED;
            writer.LongitudinalPlanMonoTime = LongitudinalPlanMonoTime;
            writer.SteeringAngleDesiredDegDEPRECATED = SteeringAngleDesiredDegDEPRECATED;
            writer.LongControlState = LongControlState;
            writer.State = State;
            writer.VEgoRawDEPRECATED = VEgoRawDEPRECATED;
            writer.UfAccelCmd = UfAccelCmd;
            writer.UfSteerDEPRECATED = UfSteerDEPRECATED;
            writer.ATarget = ATarget;
            writer.Active = Active;
            writer.Curvature = Curvature;
            writer.TheAlertStatus = TheAlertStatus;
            writer.TheAlertSize = TheAlertSize;
            writer.GpsPlannerActiveDEPRECATED = GpsPlannerActiveDEPRECATED;
            writer.Engageable = Engageable;
            writer.AlertBlinkingRate = AlertBlinkingRate;
            writer.DriverMonitoringOnDEPRECATED = DriverMonitoringOnDEPRECATED;
            writer.AlertType = AlertType;
            writer.AlertSoundDEPRECATED = AlertSoundDEPRECATED;
            writer.VCurvatureDEPRECATED = VCurvatureDEPRECATED;
            writer.DecelForTurnDEPRECATED = DecelForTurnDEPRECATED;
            writer.StartMonoTime = StartMonoTime;
            writer.MapValidDEPRECATED = MapValidDEPRECATED;
            writer.LateralPlanMonoTime = LateralPlanMonoTime;
            writer.ForceDecel = ForceDecel;
            LateralControlState?.serialize(writer.LateralControlState);
            writer.DecelForModelDEPRECATED = DecelForModelDEPRECATED;
            writer.AlertSound = AlertSound;
            writer.CanErrorCounter = CanErrorCounter;
            writer.DesiredCurvature = DesiredCurvature;
            writer.DesiredCurvatureRateDEPRECATED = DesiredCurvatureRateDEPRECATED;
            writer.VCruiseCluster = VCruiseCluster;
            writer.ExperimentalMode = ExperimentalMode;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public float VEgoDEPRECATED
        {
            get;
            set;
        }

        public float AEgoDEPRECATED
        {
            get;
            set;
        }

        public float VPid
        {
            get;
            set;
        }

        public float VTargetLead
        {
            get;
            set;
        }

        public float UpAccelCmd
        {
            get;
            set;
        }

        public float UiAccelCmd
        {
            get;
            set;
        }

        public float YActualDEPRECATED
        {
            get;
            set;
        }

        public float YDesDEPRECATED
        {
            get;
            set;
        }

        public float UpSteerDEPRECATED
        {
            get;
            set;
        }

        public float UiSteerDEPRECATED
        {
            get;
            set;
        }

        public float ATargetMinDEPRECATED
        {
            get;
            set;
        }

        public float ATargetMaxDEPRECATED
        {
            get;
            set;
        }

        public float JerkFactorDEPRECATED
        {
            get;
            set;
        }

        public float AngleSteersDEPRECATED
        {
            get;
            set;
        }

        public int HudLeadDEPRECATED
        {
            get;
            set;
        }

        public float CumLagMs
        {
            get;
            set;
        }

        public ulong CanMonoTimeDEPRECATED
        {
            get;
            set;
        }

        public ulong RadarStateMonoTimeDEPRECATED
        {
            get;
            set;
        }

        public ulong MdMonoTimeDEPRECATED
        {
            get;
            set;
        }

        public bool Enabled
        {
            get;
            set;
        }

        public bool SteerOverrideDEPRECATED
        {
            get;
            set;
        }

        public IReadOnlyList<ulong> CanMonoTimesDEPRECATED
        {
            get;
            set;
        }

        public float VCruise
        {
            get;
            set;
        }

        public bool RearViewCamDEPRECATED
        {
            get;
            set;
        }

        public string AlertText1
        {
            get;
            set;
        }

        public string AlertText2
        {
            get;
            set;
        }

        public float AwarenessStatusDEPRECATED
        {
            get;
            set;
        }

        public float AngleModelBiasDEPRECATED
        {
            get;
            set;
        }

        public ulong LongitudinalPlanMonoTime
        {
            get;
            set;
        }

        public float SteeringAngleDesiredDegDEPRECATED
        {
            get;
            set;
        }

        public Cereal.CarControl.Actuators.LongControlState LongControlState
        {
            get;
            set;
        }

        public Cereal.ControlsState.OpenpilotState State
        {
            get;
            set;
        }

        public float VEgoRawDEPRECATED
        {
            get;
            set;
        }

        public float UfAccelCmd
        {
            get;
            set;
        }

        public float UfSteerDEPRECATED
        {
            get;
            set;
        }

        public float ATarget
        {
            get;
            set;
        }

        public bool Active
        {
            get;
            set;
        }

        public float Curvature
        {
            get;
            set;
        }

        public Cereal.ControlsState.AlertStatus TheAlertStatus
        {
            get;
            set;
        }

        public Cereal.ControlsState.AlertSize TheAlertSize
        {
            get;
            set;
        }

        public bool GpsPlannerActiveDEPRECATED
        {
            get;
            set;
        }

        public bool Engageable
        {
            get;
            set;
        }

        public float AlertBlinkingRate
        {
            get;
            set;
        }

        public bool DriverMonitoringOnDEPRECATED
        {
            get;
            set;
        }

        public string AlertType
        {
            get;
            set;
        }

        public string AlertSoundDEPRECATED
        {
            get;
            set;
        }

        public float VCurvatureDEPRECATED
        {
            get;
            set;
        }

        public bool DecelForTurnDEPRECATED
        {
            get;
            set;
        }

        public ulong StartMonoTime
        {
            get;
            set;
        }

        public bool MapValidDEPRECATED
        {
            get;
            set;
        }

        public ulong LateralPlanMonoTime
        {
            get;
            set;
        }

        public bool ForceDecel
        {
            get;
            set;
        }

        public Cereal.ControlsState.lateralControlState LateralControlState
        {
            get;
            set;
        }

        public bool DecelForModelDEPRECATED
        {
            get;
            set;
        }

        public Cereal.CarControl.HUDControl.AudibleAlert AlertSound
        {
            get;
            set;
        }

        public uint CanErrorCounter
        {
            get;
            set;
        }

        public float DesiredCurvature
        {
            get;
            set;
        }

        public float DesiredCurvatureRateDEPRECATED
        {
            get;
            set;
        }

        public float VCruiseCluster
        {
            get;
            set;
        }

        public bool ExperimentalMode
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public float VEgoDEPRECATED => ctx.ReadDataFloat(0UL, 0F);
            public float AEgoDEPRECATED => ctx.ReadDataFloat(32UL, 0F);
            public float VPid => ctx.ReadDataFloat(64UL, 0F);
            public float VTargetLead => ctx.ReadDataFloat(96UL, 0F);
            public float UpAccelCmd => ctx.ReadDataFloat(128UL, 0F);
            public float UiAccelCmd => ctx.ReadDataFloat(160UL, 0F);
            public float YActualDEPRECATED => ctx.ReadDataFloat(192UL, 0F);
            public float YDesDEPRECATED => ctx.ReadDataFloat(224UL, 0F);
            public float UpSteerDEPRECATED => ctx.ReadDataFloat(256UL, 0F);
            public float UiSteerDEPRECATED => ctx.ReadDataFloat(288UL, 0F);
            public float ATargetMinDEPRECATED => ctx.ReadDataFloat(320UL, 0F);
            public float ATargetMaxDEPRECATED => ctx.ReadDataFloat(352UL, 0F);
            public float JerkFactorDEPRECATED => ctx.ReadDataFloat(384UL, 0F);
            public float AngleSteersDEPRECATED => ctx.ReadDataFloat(416UL, 0F);
            public int HudLeadDEPRECATED => ctx.ReadDataInt(448UL, 0);
            public float CumLagMs => ctx.ReadDataFloat(480UL, 0F);
            public ulong CanMonoTimeDEPRECATED => ctx.ReadDataULong(512UL, 0UL);
            public ulong RadarStateMonoTimeDEPRECATED => ctx.ReadDataULong(576UL, 0UL);
            public ulong MdMonoTimeDEPRECATED => ctx.ReadDataULong(640UL, 0UL);
            public bool Enabled => ctx.ReadDataBool(704UL, false);
            public bool SteerOverrideDEPRECATED => ctx.ReadDataBool(705UL, false);
            public IReadOnlyList<ulong> CanMonoTimesDEPRECATED => ctx.ReadList(0).CastULong();
            public float VCruise => ctx.ReadDataFloat(736UL, 0F);
            public bool RearViewCamDEPRECATED => ctx.ReadDataBool(706UL, false);
            public string AlertText1 => ctx.ReadText(1, null);
            public string AlertText2 => ctx.ReadText(2, null);
            public float AwarenessStatusDEPRECATED => ctx.ReadDataFloat(768UL, 0F);
            public float AngleModelBiasDEPRECATED => ctx.ReadDataFloat(800UL, 0F);
            public ulong LongitudinalPlanMonoTime => ctx.ReadDataULong(832UL, 0UL);
            public float SteeringAngleDesiredDegDEPRECATED => ctx.ReadDataFloat(896UL, 0F);
            public Cereal.CarControl.Actuators.LongControlState LongControlState => (Cereal.CarControl.Actuators.LongControlState)ctx.ReadDataUShort(720UL, (ushort)0);
            public Cereal.ControlsState.OpenpilotState State => (Cereal.ControlsState.OpenpilotState)ctx.ReadDataUShort(928UL, (ushort)0);
            public float VEgoRawDEPRECATED => ctx.ReadDataFloat(960UL, 0F);
            public float UfAccelCmd => ctx.ReadDataFloat(992UL, 0F);
            public float UfSteerDEPRECATED => ctx.ReadDataFloat(1024UL, 0F);
            public float ATarget => ctx.ReadDataFloat(1056UL, 0F);
            public bool Active => ctx.ReadDataBool(707UL, false);
            public float Curvature => ctx.ReadDataFloat(1088UL, 0F);
            public Cereal.ControlsState.AlertStatus TheAlertStatus => (Cereal.ControlsState.AlertStatus)ctx.ReadDataUShort(944UL, (ushort)0);
            public Cereal.ControlsState.AlertSize TheAlertSize => (Cereal.ControlsState.AlertSize)ctx.ReadDataUShort(1120UL, (ushort)0);
            public bool GpsPlannerActiveDEPRECATED => ctx.ReadDataBool(708UL, false);
            public bool Engageable => ctx.ReadDataBool(709UL, false);
            public float AlertBlinkingRate => ctx.ReadDataFloat(1152UL, 0F);
            public bool DriverMonitoringOnDEPRECATED => ctx.ReadDataBool(710UL, false);
            public string AlertType => ctx.ReadText(3, null);
            public string AlertSoundDEPRECATED => ctx.ReadText(4, null);
            public float VCurvatureDEPRECATED => ctx.ReadDataFloat(1184UL, 0F);
            public bool DecelForTurnDEPRECATED => ctx.ReadDataBool(711UL, false);
            public ulong StartMonoTime => ctx.ReadDataULong(1216UL, 0UL);
            public bool MapValidDEPRECATED => ctx.ReadDataBool(712UL, false);
            public ulong LateralPlanMonoTime => ctx.ReadDataULong(1280UL, 0UL);
            public bool ForceDecel => ctx.ReadDataBool(713UL, false);
            public lateralControlState.READER LateralControlState => new lateralControlState.READER(ctx);
            public bool DecelForModelDEPRECATED => ctx.ReadDataBool(714UL, false);
            public Cereal.CarControl.HUDControl.AudibleAlert AlertSound => (Cereal.CarControl.HUDControl.AudibleAlert)ctx.ReadDataUShort(1344UL, (ushort)0);
            public uint CanErrorCounter => ctx.ReadDataUInt(1376UL, 0U);
            public float DesiredCurvature => ctx.ReadDataFloat(1408UL, 0F);
            public float DesiredCurvatureRateDEPRECATED => ctx.ReadDataFloat(1440UL, 0F);
            public float VCruiseCluster => ctx.ReadDataFloat(1472UL, 0F);
            public bool ExperimentalMode => ctx.ReadDataBool(715UL, false);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(24, 6);
            }

            public float VEgoDEPRECATED
            {
                get => this.ReadDataFloat(0UL, 0F);
                set => this.WriteData(0UL, value, 0F);
            }

            public float AEgoDEPRECATED
            {
                get => this.ReadDataFloat(32UL, 0F);
                set => this.WriteData(32UL, value, 0F);
            }

            public float VPid
            {
                get => this.ReadDataFloat(64UL, 0F);
                set => this.WriteData(64UL, value, 0F);
            }

            public float VTargetLead
            {
                get => this.ReadDataFloat(96UL, 0F);
                set => this.WriteData(96UL, value, 0F);
            }

            public float UpAccelCmd
            {
                get => this.ReadDataFloat(128UL, 0F);
                set => this.WriteData(128UL, value, 0F);
            }

            public float UiAccelCmd
            {
                get => this.ReadDataFloat(160UL, 0F);
                set => this.WriteData(160UL, value, 0F);
            }

            public float YActualDEPRECATED
            {
                get => this.ReadDataFloat(192UL, 0F);
                set => this.WriteData(192UL, value, 0F);
            }

            public float YDesDEPRECATED
            {
                get => this.ReadDataFloat(224UL, 0F);
                set => this.WriteData(224UL, value, 0F);
            }

            public float UpSteerDEPRECATED
            {
                get => this.ReadDataFloat(256UL, 0F);
                set => this.WriteData(256UL, value, 0F);
            }

            public float UiSteerDEPRECATED
            {
                get => this.ReadDataFloat(288UL, 0F);
                set => this.WriteData(288UL, value, 0F);
            }

            public float ATargetMinDEPRECATED
            {
                get => this.ReadDataFloat(320UL, 0F);
                set => this.WriteData(320UL, value, 0F);
            }

            public float ATargetMaxDEPRECATED
            {
                get => this.ReadDataFloat(352UL, 0F);
                set => this.WriteData(352UL, value, 0F);
            }

            public float JerkFactorDEPRECATED
            {
                get => this.ReadDataFloat(384UL, 0F);
                set => this.WriteData(384UL, value, 0F);
            }

            public float AngleSteersDEPRECATED
            {
                get => this.ReadDataFloat(416UL, 0F);
                set => this.WriteData(416UL, value, 0F);
            }

            public int HudLeadDEPRECATED
            {
                get => this.ReadDataInt(448UL, 0);
                set => this.WriteData(448UL, value, 0);
            }

            public float CumLagMs
            {
                get => this.ReadDataFloat(480UL, 0F);
                set => this.WriteData(480UL, value, 0F);
            }

            public ulong CanMonoTimeDEPRECATED
            {
                get => this.ReadDataULong(512UL, 0UL);
                set => this.WriteData(512UL, value, 0UL);
            }

            public ulong RadarStateMonoTimeDEPRECATED
            {
                get => this.ReadDataULong(576UL, 0UL);
                set => this.WriteData(576UL, value, 0UL);
            }

            public ulong MdMonoTimeDEPRECATED
            {
                get => this.ReadDataULong(640UL, 0UL);
                set => this.WriteData(640UL, value, 0UL);
            }

            public bool Enabled
            {
                get => this.ReadDataBool(704UL, false);
                set => this.WriteData(704UL, value, false);
            }

            public bool SteerOverrideDEPRECATED
            {
                get => this.ReadDataBool(705UL, false);
                set => this.WriteData(705UL, value, false);
            }

            public ListOfPrimitivesSerializer<ulong> CanMonoTimesDEPRECATED
            {
                get => BuildPointer<ListOfPrimitivesSerializer<ulong>>(0);
                set => Link(0, value);
            }

            public float VCruise
            {
                get => this.ReadDataFloat(736UL, 0F);
                set => this.WriteData(736UL, value, 0F);
            }

            public bool RearViewCamDEPRECATED
            {
                get => this.ReadDataBool(706UL, false);
                set => this.WriteData(706UL, value, false);
            }

            public string AlertText1
            {
                get => this.ReadText(1, null);
                set => this.WriteText(1, value, null);
            }

            public string AlertText2
            {
                get => this.ReadText(2, null);
                set => this.WriteText(2, value, null);
            }

            public float AwarenessStatusDEPRECATED
            {
                get => this.ReadDataFloat(768UL, 0F);
                set => this.WriteData(768UL, value, 0F);
            }

            public float AngleModelBiasDEPRECATED
            {
                get => this.ReadDataFloat(800UL, 0F);
                set => this.WriteData(800UL, value, 0F);
            }

            public ulong LongitudinalPlanMonoTime
            {
                get => this.ReadDataULong(832UL, 0UL);
                set => this.WriteData(832UL, value, 0UL);
            }

            public float SteeringAngleDesiredDegDEPRECATED
            {
                get => this.ReadDataFloat(896UL, 0F);
                set => this.WriteData(896UL, value, 0F);
            }

            public Cereal.CarControl.Actuators.LongControlState LongControlState
            {
                get => (Cereal.CarControl.Actuators.LongControlState)this.ReadDataUShort(720UL, (ushort)0);
                set => this.WriteData(720UL, (ushort)value, (ushort)0);
            }

            public Cereal.ControlsState.OpenpilotState State
            {
                get => (Cereal.ControlsState.OpenpilotState)this.ReadDataUShort(928UL, (ushort)0);
                set => this.WriteData(928UL, (ushort)value, (ushort)0);
            }

            public float VEgoRawDEPRECATED
            {
                get => this.ReadDataFloat(960UL, 0F);
                set => this.WriteData(960UL, value, 0F);
            }

            public float UfAccelCmd
            {
                get => this.ReadDataFloat(992UL, 0F);
                set => this.WriteData(992UL, value, 0F);
            }

            public float UfSteerDEPRECATED
            {
                get => this.ReadDataFloat(1024UL, 0F);
                set => this.WriteData(1024UL, value, 0F);
            }

            public float ATarget
            {
                get => this.ReadDataFloat(1056UL, 0F);
                set => this.WriteData(1056UL, value, 0F);
            }

            public bool Active
            {
                get => this.ReadDataBool(707UL, false);
                set => this.WriteData(707UL, value, false);
            }

            public float Curvature
            {
                get => this.ReadDataFloat(1088UL, 0F);
                set => this.WriteData(1088UL, value, 0F);
            }

            public Cereal.ControlsState.AlertStatus TheAlertStatus
            {
                get => (Cereal.ControlsState.AlertStatus)this.ReadDataUShort(944UL, (ushort)0);
                set => this.WriteData(944UL, (ushort)value, (ushort)0);
            }

            public Cereal.ControlsState.AlertSize TheAlertSize
            {
                get => (Cereal.ControlsState.AlertSize)this.ReadDataUShort(1120UL, (ushort)0);
                set => this.WriteData(1120UL, (ushort)value, (ushort)0);
            }

            public bool GpsPlannerActiveDEPRECATED
            {
                get => this.ReadDataBool(708UL, false);
                set => this.WriteData(708UL, value, false);
            }

            public bool Engageable
            {
                get => this.ReadDataBool(709UL, false);
                set => this.WriteData(709UL, value, false);
            }

            public float AlertBlinkingRate
            {
                get => this.ReadDataFloat(1152UL, 0F);
                set => this.WriteData(1152UL, value, 0F);
            }

            public bool DriverMonitoringOnDEPRECATED
            {
                get => this.ReadDataBool(710UL, false);
                set => this.WriteData(710UL, value, false);
            }

            public string AlertType
            {
                get => this.ReadText(3, null);
                set => this.WriteText(3, value, null);
            }

            public string AlertSoundDEPRECATED
            {
                get => this.ReadText(4, null);
                set => this.WriteText(4, value, null);
            }

            public float VCurvatureDEPRECATED
            {
                get => this.ReadDataFloat(1184UL, 0F);
                set => this.WriteData(1184UL, value, 0F);
            }

            public bool DecelForTurnDEPRECATED
            {
                get => this.ReadDataBool(711UL, false);
                set => this.WriteData(711UL, value, false);
            }

            public ulong StartMonoTime
            {
                get => this.ReadDataULong(1216UL, 0UL);
                set => this.WriteData(1216UL, value, 0UL);
            }

            public bool MapValidDEPRECATED
            {
                get => this.ReadDataBool(712UL, false);
                set => this.WriteData(712UL, value, false);
            }

            public ulong LateralPlanMonoTime
            {
                get => this.ReadDataULong(1280UL, 0UL);
                set => this.WriteData(1280UL, value, 0UL);
            }

            public bool ForceDecel
            {
                get => this.ReadDataBool(713UL, false);
                set => this.WriteData(713UL, value, false);
            }

            public lateralControlState.WRITER LateralControlState
            {
                get => Rewrap<lateralControlState.WRITER>();
            }

            public bool DecelForModelDEPRECATED
            {
                get => this.ReadDataBool(714UL, false);
                set => this.WriteData(714UL, value, false);
            }

            public Cereal.CarControl.HUDControl.AudibleAlert AlertSound
            {
                get => (Cereal.CarControl.HUDControl.AudibleAlert)this.ReadDataUShort(1344UL, (ushort)0);
                set => this.WriteData(1344UL, (ushort)value, (ushort)0);
            }

            public uint CanErrorCounter
            {
                get => this.ReadDataUInt(1376UL, 0U);
                set => this.WriteData(1376UL, value, 0U);
            }

            public float DesiredCurvature
            {
                get => this.ReadDataFloat(1408UL, 0F);
                set => this.WriteData(1408UL, value, 0F);
            }

            public float DesiredCurvatureRateDEPRECATED
            {
                get => this.ReadDataFloat(1440UL, 0F);
                set => this.WriteData(1440UL, value, 0F);
            }

            public float VCruiseCluster
            {
                get => this.ReadDataFloat(1472UL, 0F);
                set => this.WriteData(1472UL, value, 0F);
            }

            public bool ExperimentalMode
            {
                get => this.ReadDataBool(715UL, false);
                set => this.WriteData(715UL, value, false);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xfd5b914d6b444695UL)]
        public class lateralControlState : ICapnpSerializable
        {
            public const UInt64 typeId = 0xfd5b914d6b444695UL;
            public enum WHICH : ushort
            {
                IndiState = 0,
                PidState = 1,
                LqrStateDEPRECATED = 2,
                AngleState = 3,
                DebugState = 4,
                TorqueState = 5,
                CurvatureStateDEPRECATED = 6,
                undefined = 65535
            }

            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                switch (reader.which)
                {
                    case WHICH.IndiState:
                        IndiState = CapnpSerializable.Create<Cereal.ControlsState.LateralINDIState>(reader.IndiState);
                        break;
                    case WHICH.PidState:
                        PidState = CapnpSerializable.Create<Cereal.ControlsState.LateralPIDState>(reader.PidState);
                        break;
                    case WHICH.LqrStateDEPRECATED:
                        LqrStateDEPRECATED = CapnpSerializable.Create<Cereal.ControlsState.LateralLQRState>(reader.LqrStateDEPRECATED);
                        break;
                    case WHICH.AngleState:
                        AngleState = CapnpSerializable.Create<Cereal.ControlsState.LateralAngleState>(reader.AngleState);
                        break;
                    case WHICH.DebugState:
                        DebugState = CapnpSerializable.Create<Cereal.ControlsState.LateralDebugState>(reader.DebugState);
                        break;
                    case WHICH.TorqueState:
                        TorqueState = CapnpSerializable.Create<Cereal.ControlsState.LateralTorqueState>(reader.TorqueState);
                        break;
                    case WHICH.CurvatureStateDEPRECATED:
                        CurvatureStateDEPRECATED = CapnpSerializable.Create<Cereal.ControlsState.LateralCurvatureState>(reader.CurvatureStateDEPRECATED);
                        break;
                }

                applyDefaults();
            }

            private WHICH _which = WHICH.undefined;
            private object _content;
            public WHICH which
            {
                get => _which;
                set
                {
                    if (value == _which)
                        return;
                    _which = value;
                    switch (value)
                    {
                        case WHICH.IndiState:
                            _content = null;
                            break;
                        case WHICH.PidState:
                            _content = null;
                            break;
                        case WHICH.LqrStateDEPRECATED:
                            _content = null;
                            break;
                        case WHICH.AngleState:
                            _content = null;
                            break;
                        case WHICH.DebugState:
                            _content = null;
                            break;
                        case WHICH.TorqueState:
                            _content = null;
                            break;
                        case WHICH.CurvatureStateDEPRECATED:
                            _content = null;
                            break;
                    }
                }
            }

            public void serialize(WRITER writer)
            {
                writer.which = which;
                switch (which)
                {
                    case WHICH.IndiState:
                        IndiState?.serialize(writer.IndiState);
                        break;
                    case WHICH.PidState:
                        PidState?.serialize(writer.PidState);
                        break;
                    case WHICH.LqrStateDEPRECATED:
                        LqrStateDEPRECATED?.serialize(writer.LqrStateDEPRECATED);
                        break;
                    case WHICH.AngleState:
                        AngleState?.serialize(writer.AngleState);
                        break;
                    case WHICH.DebugState:
                        DebugState?.serialize(writer.DebugState);
                        break;
                    case WHICH.TorqueState:
                        TorqueState?.serialize(writer.TorqueState);
                        break;
                    case WHICH.CurvatureStateDEPRECATED:
                        CurvatureStateDEPRECATED?.serialize(writer.CurvatureStateDEPRECATED);
                        break;
                }
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public Cereal.ControlsState.LateralINDIState IndiState
            {
                get => _which == WHICH.IndiState ? (Cereal.ControlsState.LateralINDIState)_content : null;
                set
                {
                    _which = WHICH.IndiState;
                    _content = value;
                }
            }

            public Cereal.ControlsState.LateralPIDState PidState
            {
                get => _which == WHICH.PidState ? (Cereal.ControlsState.LateralPIDState)_content : null;
                set
                {
                    _which = WHICH.PidState;
                    _content = value;
                }
            }

            public Cereal.ControlsState.LateralLQRState LqrStateDEPRECATED
            {
                get => _which == WHICH.LqrStateDEPRECATED ? (Cereal.ControlsState.LateralLQRState)_content : null;
                set
                {
                    _which = WHICH.LqrStateDEPRECATED;
                    _content = value;
                }
            }

            public Cereal.ControlsState.LateralAngleState AngleState
            {
                get => _which == WHICH.AngleState ? (Cereal.ControlsState.LateralAngleState)_content : null;
                set
                {
                    _which = WHICH.AngleState;
                    _content = value;
                }
            }

            public Cereal.ControlsState.LateralDebugState DebugState
            {
                get => _which == WHICH.DebugState ? (Cereal.ControlsState.LateralDebugState)_content : null;
                set
                {
                    _which = WHICH.DebugState;
                    _content = value;
                }
            }

            public Cereal.ControlsState.LateralTorqueState TorqueState
            {
                get => _which == WHICH.TorqueState ? (Cereal.ControlsState.LateralTorqueState)_content : null;
                set
                {
                    _which = WHICH.TorqueState;
                    _content = value;
                }
            }

            public Cereal.ControlsState.LateralCurvatureState CurvatureStateDEPRECATED
            {
                get => _which == WHICH.CurvatureStateDEPRECATED ? (Cereal.ControlsState.LateralCurvatureState)_content : null;
                set
                {
                    _which = WHICH.CurvatureStateDEPRECATED;
                    _content = value;
                }
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public WHICH which => (WHICH)ctx.ReadDataUShort(1136U, (ushort)0);
                public Cereal.ControlsState.LateralINDIState.READER IndiState => which == WHICH.IndiState ? ctx.ReadStruct(5, Cereal.ControlsState.LateralINDIState.READER.create) : default;
                public Cereal.ControlsState.LateralPIDState.READER PidState => which == WHICH.PidState ? ctx.ReadStruct(5, Cereal.ControlsState.LateralPIDState.READER.create) : default;
                public Cereal.ControlsState.LateralLQRState.READER LqrStateDEPRECATED => which == WHICH.LqrStateDEPRECATED ? ctx.ReadStruct(5, Cereal.ControlsState.LateralLQRState.READER.create) : default;
                public Cereal.ControlsState.LateralAngleState.READER AngleState => which == WHICH.AngleState ? ctx.ReadStruct(5, Cereal.ControlsState.LateralAngleState.READER.create) : default;
                public Cereal.ControlsState.LateralDebugState.READER DebugState => which == WHICH.DebugState ? ctx.ReadStruct(5, Cereal.ControlsState.LateralDebugState.READER.create) : default;
                public Cereal.ControlsState.LateralTorqueState.READER TorqueState => which == WHICH.TorqueState ? ctx.ReadStruct(5, Cereal.ControlsState.LateralTorqueState.READER.create) : default;
                public Cereal.ControlsState.LateralCurvatureState.READER CurvatureStateDEPRECATED => which == WHICH.CurvatureStateDEPRECATED ? ctx.ReadStruct(5, Cereal.ControlsState.LateralCurvatureState.READER.create) : default;
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                }

                public WHICH which
                {
                    get => (WHICH)this.ReadDataUShort(1136U, (ushort)0);
                    set => this.WriteData(1136U, (ushort)value, (ushort)0);
                }

                public Cereal.ControlsState.LateralINDIState.WRITER IndiState
                {
                    get => which == WHICH.IndiState ? BuildPointer<Cereal.ControlsState.LateralINDIState.WRITER>(5) : default;
                    set => Link(5, value);
                }

                public Cereal.ControlsState.LateralPIDState.WRITER PidState
                {
                    get => which == WHICH.PidState ? BuildPointer<Cereal.ControlsState.LateralPIDState.WRITER>(5) : default;
                    set => Link(5, value);
                }

                public Cereal.ControlsState.LateralLQRState.WRITER LqrStateDEPRECATED
                {
                    get => which == WHICH.LqrStateDEPRECATED ? BuildPointer<Cereal.ControlsState.LateralLQRState.WRITER>(5) : default;
                    set => Link(5, value);
                }

                public Cereal.ControlsState.LateralAngleState.WRITER AngleState
                {
                    get => which == WHICH.AngleState ? BuildPointer<Cereal.ControlsState.LateralAngleState.WRITER>(5) : default;
                    set => Link(5, value);
                }

                public Cereal.ControlsState.LateralDebugState.WRITER DebugState
                {
                    get => which == WHICH.DebugState ? BuildPointer<Cereal.ControlsState.LateralDebugState.WRITER>(5) : default;
                    set => Link(5, value);
                }

                public Cereal.ControlsState.LateralTorqueState.WRITER TorqueState
                {
                    get => which == WHICH.TorqueState ? BuildPointer<Cereal.ControlsState.LateralTorqueState.WRITER>(5) : default;
                    set => Link(5, value);
                }

                public Cereal.ControlsState.LateralCurvatureState.WRITER CurvatureStateDEPRECATED
                {
                    get => which == WHICH.CurvatureStateDEPRECATED ? BuildPointer<Cereal.ControlsState.LateralCurvatureState.WRITER>(5) : default;
                    set => Link(5, value);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xdbe58b96d2d1ac61UL)]
        public enum OpenpilotState : ushort
        {
            disabled,
            preEnabled,
            enabled,
            softDisabling,
            overriding
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xa0d0dcd113193c62UL)]
        public enum AlertStatus : ushort
        {
            normal,
            userPrompt,
            critical
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xe98bb99d6e985f64UL)]
        public enum AlertSize : ushort
        {
            none,
            small,
            mid,
            full
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x939463348632375eUL)]
        public class LateralINDIState : ICapnpSerializable
        {
            public const UInt64 typeId = 0x939463348632375eUL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Active = reader.Active;
                SteeringAngleDeg = reader.SteeringAngleDeg;
                SteeringRateDeg = reader.SteeringRateDeg;
                SteeringAccelDeg = reader.SteeringAccelDeg;
                RateSetPoint = reader.RateSetPoint;
                AccelSetPoint = reader.AccelSetPoint;
                AccelError = reader.AccelError;
                DelayedOutput = reader.DelayedOutput;
                Delta = reader.Delta;
                Output = reader.Output;
                Saturated = reader.Saturated;
                SteeringAngleDesiredDeg = reader.SteeringAngleDesiredDeg;
                SteeringRateDesiredDeg = reader.SteeringRateDesiredDeg;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Active = Active;
                writer.SteeringAngleDeg = SteeringAngleDeg;
                writer.SteeringRateDeg = SteeringRateDeg;
                writer.SteeringAccelDeg = SteeringAccelDeg;
                writer.RateSetPoint = RateSetPoint;
                writer.AccelSetPoint = AccelSetPoint;
                writer.AccelError = AccelError;
                writer.DelayedOutput = DelayedOutput;
                writer.Delta = Delta;
                writer.Output = Output;
                writer.Saturated = Saturated;
                writer.SteeringAngleDesiredDeg = SteeringAngleDesiredDeg;
                writer.SteeringRateDesiredDeg = SteeringRateDesiredDeg;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public bool Active
            {
                get;
                set;
            }

            public float SteeringAngleDeg
            {
                get;
                set;
            }

            public float SteeringRateDeg
            {
                get;
                set;
            }

            public float SteeringAccelDeg
            {
                get;
                set;
            }

            public float RateSetPoint
            {
                get;
                set;
            }

            public float AccelSetPoint
            {
                get;
                set;
            }

            public float AccelError
            {
                get;
                set;
            }

            public float DelayedOutput
            {
                get;
                set;
            }

            public float Delta
            {
                get;
                set;
            }

            public float Output
            {
                get;
                set;
            }

            public bool Saturated
            {
                get;
                set;
            }

            public float SteeringAngleDesiredDeg
            {
                get;
                set;
            }

            public float SteeringRateDesiredDeg
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public bool Active => ctx.ReadDataBool(0UL, false);
                public float SteeringAngleDeg => ctx.ReadDataFloat(32UL, 0F);
                public float SteeringRateDeg => ctx.ReadDataFloat(64UL, 0F);
                public float SteeringAccelDeg => ctx.ReadDataFloat(96UL, 0F);
                public float RateSetPoint => ctx.ReadDataFloat(128UL, 0F);
                public float AccelSetPoint => ctx.ReadDataFloat(160UL, 0F);
                public float AccelError => ctx.ReadDataFloat(192UL, 0F);
                public float DelayedOutput => ctx.ReadDataFloat(224UL, 0F);
                public float Delta => ctx.ReadDataFloat(256UL, 0F);
                public float Output => ctx.ReadDataFloat(288UL, 0F);
                public bool Saturated => ctx.ReadDataBool(1UL, false);
                public float SteeringAngleDesiredDeg => ctx.ReadDataFloat(320UL, 0F);
                public float SteeringRateDesiredDeg => ctx.ReadDataFloat(352UL, 0F);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(6, 0);
                }

                public bool Active
                {
                    get => this.ReadDataBool(0UL, false);
                    set => this.WriteData(0UL, value, false);
                }

                public float SteeringAngleDeg
                {
                    get => this.ReadDataFloat(32UL, 0F);
                    set => this.WriteData(32UL, value, 0F);
                }

                public float SteeringRateDeg
                {
                    get => this.ReadDataFloat(64UL, 0F);
                    set => this.WriteData(64UL, value, 0F);
                }

                public float SteeringAccelDeg
                {
                    get => this.ReadDataFloat(96UL, 0F);
                    set => this.WriteData(96UL, value, 0F);
                }

                public float RateSetPoint
                {
                    get => this.ReadDataFloat(128UL, 0F);
                    set => this.WriteData(128UL, value, 0F);
                }

                public float AccelSetPoint
                {
                    get => this.ReadDataFloat(160UL, 0F);
                    set => this.WriteData(160UL, value, 0F);
                }

                public float AccelError
                {
                    get => this.ReadDataFloat(192UL, 0F);
                    set => this.WriteData(192UL, value, 0F);
                }

                public float DelayedOutput
                {
                    get => this.ReadDataFloat(224UL, 0F);
                    set => this.WriteData(224UL, value, 0F);
                }

                public float Delta
                {
                    get => this.ReadDataFloat(256UL, 0F);
                    set => this.WriteData(256UL, value, 0F);
                }

                public float Output
                {
                    get => this.ReadDataFloat(288UL, 0F);
                    set => this.WriteData(288UL, value, 0F);
                }

                public bool Saturated
                {
                    get => this.ReadDataBool(1UL, false);
                    set => this.WriteData(1UL, value, false);
                }

                public float SteeringAngleDesiredDeg
                {
                    get => this.ReadDataFloat(320UL, 0F);
                    set => this.WriteData(320UL, value, 0F);
                }

                public float SteeringRateDesiredDeg
                {
                    get => this.ReadDataFloat(352UL, 0F);
                    set => this.WriteData(352UL, value, 0F);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xf28c5dc9e09375e3UL)]
        public class LateralPIDState : ICapnpSerializable
        {
            public const UInt64 typeId = 0xf28c5dc9e09375e3UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Active = reader.Active;
                SteeringAngleDeg = reader.SteeringAngleDeg;
                SteeringRateDeg = reader.SteeringRateDeg;
                AngleError = reader.AngleError;
                P = reader.P;
                I = reader.I;
                F = reader.F;
                Output = reader.Output;
                Saturated = reader.Saturated;
                SteeringAngleDesiredDeg = reader.SteeringAngleDesiredDeg;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Active = Active;
                writer.SteeringAngleDeg = SteeringAngleDeg;
                writer.SteeringRateDeg = SteeringRateDeg;
                writer.AngleError = AngleError;
                writer.P = P;
                writer.I = I;
                writer.F = F;
                writer.Output = Output;
                writer.Saturated = Saturated;
                writer.SteeringAngleDesiredDeg = SteeringAngleDesiredDeg;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public bool Active
            {
                get;
                set;
            }

            public float SteeringAngleDeg
            {
                get;
                set;
            }

            public float SteeringRateDeg
            {
                get;
                set;
            }

            public float AngleError
            {
                get;
                set;
            }

            public float P
            {
                get;
                set;
            }

            public float I
            {
                get;
                set;
            }

            public float F
            {
                get;
                set;
            }

            public float Output
            {
                get;
                set;
            }

            public bool Saturated
            {
                get;
                set;
            }

            public float SteeringAngleDesiredDeg
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public bool Active => ctx.ReadDataBool(0UL, false);
                public float SteeringAngleDeg => ctx.ReadDataFloat(32UL, 0F);
                public float SteeringRateDeg => ctx.ReadDataFloat(64UL, 0F);
                public float AngleError => ctx.ReadDataFloat(96UL, 0F);
                public float P => ctx.ReadDataFloat(128UL, 0F);
                public float I => ctx.ReadDataFloat(160UL, 0F);
                public float F => ctx.ReadDataFloat(192UL, 0F);
                public float Output => ctx.ReadDataFloat(224UL, 0F);
                public bool Saturated => ctx.ReadDataBool(1UL, false);
                public float SteeringAngleDesiredDeg => ctx.ReadDataFloat(256UL, 0F);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(5, 0);
                }

                public bool Active
                {
                    get => this.ReadDataBool(0UL, false);
                    set => this.WriteData(0UL, value, false);
                }

                public float SteeringAngleDeg
                {
                    get => this.ReadDataFloat(32UL, 0F);
                    set => this.WriteData(32UL, value, 0F);
                }

                public float SteeringRateDeg
                {
                    get => this.ReadDataFloat(64UL, 0F);
                    set => this.WriteData(64UL, value, 0F);
                }

                public float AngleError
                {
                    get => this.ReadDataFloat(96UL, 0F);
                    set => this.WriteData(96UL, value, 0F);
                }

                public float P
                {
                    get => this.ReadDataFloat(128UL, 0F);
                    set => this.WriteData(128UL, value, 0F);
                }

                public float I
                {
                    get => this.ReadDataFloat(160UL, 0F);
                    set => this.WriteData(160UL, value, 0F);
                }

                public float F
                {
                    get => this.ReadDataFloat(192UL, 0F);
                    set => this.WriteData(192UL, value, 0F);
                }

                public float Output
                {
                    get => this.ReadDataFloat(224UL, 0F);
                    set => this.WriteData(224UL, value, 0F);
                }

                public bool Saturated
                {
                    get => this.ReadDataBool(1UL, false);
                    set => this.WriteData(1UL, value, false);
                }

                public float SteeringAngleDesiredDeg
                {
                    get => this.ReadDataFloat(256UL, 0F);
                    set => this.WriteData(256UL, value, 0F);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xe774a050cbf689a4UL)]
        public class LateralTorqueState : ICapnpSerializable
        {
            public const UInt64 typeId = 0xe774a050cbf689a4UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Active = reader.Active;
                Error = reader.Error;
                P = reader.P;
                I = reader.I;
                D = reader.D;
                F = reader.F;
                Output = reader.Output;
                Saturated = reader.Saturated;
                ErrorRate = reader.ErrorRate;
                ActualLateralAccel = reader.ActualLateralAccel;
                DesiredLateralAccel = reader.DesiredLateralAccel;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Active = Active;
                writer.Error = Error;
                writer.P = P;
                writer.I = I;
                writer.D = D;
                writer.F = F;
                writer.Output = Output;
                writer.Saturated = Saturated;
                writer.ErrorRate = ErrorRate;
                writer.ActualLateralAccel = ActualLateralAccel;
                writer.DesiredLateralAccel = DesiredLateralAccel;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public bool Active
            {
                get;
                set;
            }

            public float Error
            {
                get;
                set;
            }

            public float P
            {
                get;
                set;
            }

            public float I
            {
                get;
                set;
            }

            public float D
            {
                get;
                set;
            }

            public float F
            {
                get;
                set;
            }

            public float Output
            {
                get;
                set;
            }

            public bool Saturated
            {
                get;
                set;
            }

            public float ErrorRate
            {
                get;
                set;
            }

            public float ActualLateralAccel
            {
                get;
                set;
            }

            public float DesiredLateralAccel
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public bool Active => ctx.ReadDataBool(0UL, false);
                public float Error => ctx.ReadDataFloat(32UL, 0F);
                public float P => ctx.ReadDataFloat(64UL, 0F);
                public float I => ctx.ReadDataFloat(96UL, 0F);
                public float D => ctx.ReadDataFloat(128UL, 0F);
                public float F => ctx.ReadDataFloat(160UL, 0F);
                public float Output => ctx.ReadDataFloat(192UL, 0F);
                public bool Saturated => ctx.ReadDataBool(1UL, false);
                public float ErrorRate => ctx.ReadDataFloat(224UL, 0F);
                public float ActualLateralAccel => ctx.ReadDataFloat(256UL, 0F);
                public float DesiredLateralAccel => ctx.ReadDataFloat(288UL, 0F);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(5, 0);
                }

                public bool Active
                {
                    get => this.ReadDataBool(0UL, false);
                    set => this.WriteData(0UL, value, false);
                }

                public float Error
                {
                    get => this.ReadDataFloat(32UL, 0F);
                    set => this.WriteData(32UL, value, 0F);
                }

                public float P
                {
                    get => this.ReadDataFloat(64UL, 0F);
                    set => this.WriteData(64UL, value, 0F);
                }

                public float I
                {
                    get => this.ReadDataFloat(96UL, 0F);
                    set => this.WriteData(96UL, value, 0F);
                }

                public float D
                {
                    get => this.ReadDataFloat(128UL, 0F);
                    set => this.WriteData(128UL, value, 0F);
                }

                public float F
                {
                    get => this.ReadDataFloat(160UL, 0F);
                    set => this.WriteData(160UL, value, 0F);
                }

                public float Output
                {
                    get => this.ReadDataFloat(192UL, 0F);
                    set => this.WriteData(192UL, value, 0F);
                }

                public bool Saturated
                {
                    get => this.ReadDataBool(1UL, false);
                    set => this.WriteData(1UL, value, false);
                }

                public float ErrorRate
                {
                    get => this.ReadDataFloat(224UL, 0F);
                    set => this.WriteData(224UL, value, 0F);
                }

                public float ActualLateralAccel
                {
                    get => this.ReadDataFloat(256UL, 0F);
                    set => this.WriteData(256UL, value, 0F);
                }

                public float DesiredLateralAccel
                {
                    get => this.ReadDataFloat(288UL, 0F);
                    set => this.WriteData(288UL, value, 0F);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x9024e2d790c82adeUL)]
        public class LateralLQRState : ICapnpSerializable
        {
            public const UInt64 typeId = 0x9024e2d790c82adeUL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Active = reader.Active;
                SteeringAngleDeg = reader.SteeringAngleDeg;
                I = reader.I;
                Output = reader.Output;
                LqrOutput = reader.LqrOutput;
                Saturated = reader.Saturated;
                SteeringAngleDesiredDeg = reader.SteeringAngleDesiredDeg;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Active = Active;
                writer.SteeringAngleDeg = SteeringAngleDeg;
                writer.I = I;
                writer.Output = Output;
                writer.LqrOutput = LqrOutput;
                writer.Saturated = Saturated;
                writer.SteeringAngleDesiredDeg = SteeringAngleDesiredDeg;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public bool Active
            {
                get;
                set;
            }

            public float SteeringAngleDeg
            {
                get;
                set;
            }

            public float I
            {
                get;
                set;
            }

            public float Output
            {
                get;
                set;
            }

            public float LqrOutput
            {
                get;
                set;
            }

            public bool Saturated
            {
                get;
                set;
            }

            public float SteeringAngleDesiredDeg
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public bool Active => ctx.ReadDataBool(0UL, false);
                public float SteeringAngleDeg => ctx.ReadDataFloat(32UL, 0F);
                public float I => ctx.ReadDataFloat(64UL, 0F);
                public float Output => ctx.ReadDataFloat(96UL, 0F);
                public float LqrOutput => ctx.ReadDataFloat(128UL, 0F);
                public bool Saturated => ctx.ReadDataBool(1UL, false);
                public float SteeringAngleDesiredDeg => ctx.ReadDataFloat(160UL, 0F);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(3, 0);
                }

                public bool Active
                {
                    get => this.ReadDataBool(0UL, false);
                    set => this.WriteData(0UL, value, false);
                }

                public float SteeringAngleDeg
                {
                    get => this.ReadDataFloat(32UL, 0F);
                    set => this.WriteData(32UL, value, 0F);
                }

                public float I
                {
                    get => this.ReadDataFloat(64UL, 0F);
                    set => this.WriteData(64UL, value, 0F);
                }

                public float Output
                {
                    get => this.ReadDataFloat(96UL, 0F);
                    set => this.WriteData(96UL, value, 0F);
                }

                public float LqrOutput
                {
                    get => this.ReadDataFloat(128UL, 0F);
                    set => this.WriteData(128UL, value, 0F);
                }

                public bool Saturated
                {
                    get => this.ReadDataBool(1UL, false);
                    set => this.WriteData(1UL, value, false);
                }

                public float SteeringAngleDesiredDeg
                {
                    get => this.ReadDataFloat(160UL, 0F);
                    set => this.WriteData(160UL, value, 0F);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xa2e4ea88ac9980f1UL)]
        public class LateralAngleState : ICapnpSerializable
        {
            public const UInt64 typeId = 0xa2e4ea88ac9980f1UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Active = reader.Active;
                SteeringAngleDeg = reader.SteeringAngleDeg;
                Output = reader.Output;
                Saturated = reader.Saturated;
                SteeringAngleDesiredDeg = reader.SteeringAngleDesiredDeg;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Active = Active;
                writer.SteeringAngleDeg = SteeringAngleDeg;
                writer.Output = Output;
                writer.Saturated = Saturated;
                writer.SteeringAngleDesiredDeg = SteeringAngleDesiredDeg;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public bool Active
            {
                get;
                set;
            }

            public float SteeringAngleDeg
            {
                get;
                set;
            }

            public float Output
            {
                get;
                set;
            }

            public bool Saturated
            {
                get;
                set;
            }

            public float SteeringAngleDesiredDeg
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public bool Active => ctx.ReadDataBool(0UL, false);
                public float SteeringAngleDeg => ctx.ReadDataFloat(32UL, 0F);
                public float Output => ctx.ReadDataFloat(64UL, 0F);
                public bool Saturated => ctx.ReadDataBool(1UL, false);
                public float SteeringAngleDesiredDeg => ctx.ReadDataFloat(96UL, 0F);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(2, 0);
                }

                public bool Active
                {
                    get => this.ReadDataBool(0UL, false);
                    set => this.WriteData(0UL, value, false);
                }

                public float SteeringAngleDeg
                {
                    get => this.ReadDataFloat(32UL, 0F);
                    set => this.WriteData(32UL, value, 0F);
                }

                public float Output
                {
                    get => this.ReadDataFloat(64UL, 0F);
                    set => this.WriteData(64UL, value, 0F);
                }

                public bool Saturated
                {
                    get => this.ReadDataBool(1UL, false);
                    set => this.WriteData(1UL, value, false);
                }

                public float SteeringAngleDesiredDeg
                {
                    get => this.ReadDataFloat(96UL, 0F);
                    set => this.WriteData(96UL, value, 0F);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xad9d8095c06f7c61UL)]
        public class LateralCurvatureState : ICapnpSerializable
        {
            public const UInt64 typeId = 0xad9d8095c06f7c61UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Active = reader.Active;
                ActualCurvature = reader.ActualCurvature;
                DesiredCurvature = reader.DesiredCurvature;
                Error = reader.Error;
                P = reader.P;
                I = reader.I;
                F = reader.F;
                Output = reader.Output;
                Saturated = reader.Saturated;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Active = Active;
                writer.ActualCurvature = ActualCurvature;
                writer.DesiredCurvature = DesiredCurvature;
                writer.Error = Error;
                writer.P = P;
                writer.I = I;
                writer.F = F;
                writer.Output = Output;
                writer.Saturated = Saturated;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public bool Active
            {
                get;
                set;
            }

            public float ActualCurvature
            {
                get;
                set;
            }

            public float DesiredCurvature
            {
                get;
                set;
            }

            public float Error
            {
                get;
                set;
            }

            public float P
            {
                get;
                set;
            }

            public float I
            {
                get;
                set;
            }

            public float F
            {
                get;
                set;
            }

            public float Output
            {
                get;
                set;
            }

            public bool Saturated
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public bool Active => ctx.ReadDataBool(0UL, false);
                public float ActualCurvature => ctx.ReadDataFloat(32UL, 0F);
                public float DesiredCurvature => ctx.ReadDataFloat(64UL, 0F);
                public float Error => ctx.ReadDataFloat(96UL, 0F);
                public float P => ctx.ReadDataFloat(128UL, 0F);
                public float I => ctx.ReadDataFloat(160UL, 0F);
                public float F => ctx.ReadDataFloat(192UL, 0F);
                public float Output => ctx.ReadDataFloat(224UL, 0F);
                public bool Saturated => ctx.ReadDataBool(1UL, false);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(4, 0);
                }

                public bool Active
                {
                    get => this.ReadDataBool(0UL, false);
                    set => this.WriteData(0UL, value, false);
                }

                public float ActualCurvature
                {
                    get => this.ReadDataFloat(32UL, 0F);
                    set => this.WriteData(32UL, value, 0F);
                }

                public float DesiredCurvature
                {
                    get => this.ReadDataFloat(64UL, 0F);
                    set => this.WriteData(64UL, value, 0F);
                }

                public float Error
                {
                    get => this.ReadDataFloat(96UL, 0F);
                    set => this.WriteData(96UL, value, 0F);
                }

                public float P
                {
                    get => this.ReadDataFloat(128UL, 0F);
                    set => this.WriteData(128UL, value, 0F);
                }

                public float I
                {
                    get => this.ReadDataFloat(160UL, 0F);
                    set => this.WriteData(160UL, value, 0F);
                }

                public float F
                {
                    get => this.ReadDataFloat(192UL, 0F);
                    set => this.WriteData(192UL, value, 0F);
                }

                public float Output
                {
                    get => this.ReadDataFloat(224UL, 0F);
                    set => this.WriteData(224UL, value, 0F);
                }

                public bool Saturated
                {
                    get => this.ReadDataBool(1UL, false);
                    set => this.WriteData(1UL, value, false);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xa63a46f0f2889b2dUL)]
        public class LateralDebugState : ICapnpSerializable
        {
            public const UInt64 typeId = 0xa63a46f0f2889b2dUL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Active = reader.Active;
                SteeringAngleDeg = reader.SteeringAngleDeg;
                Output = reader.Output;
                Saturated = reader.Saturated;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Active = Active;
                writer.SteeringAngleDeg = SteeringAngleDeg;
                writer.Output = Output;
                writer.Saturated = Saturated;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public bool Active
            {
                get;
                set;
            }

            public float SteeringAngleDeg
            {
                get;
                set;
            }

            public float Output
            {
                get;
                set;
            }

            public bool Saturated
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public bool Active => ctx.ReadDataBool(0UL, false);
                public float SteeringAngleDeg => ctx.ReadDataFloat(32UL, 0F);
                public float Output => ctx.ReadDataFloat(64UL, 0F);
                public bool Saturated => ctx.ReadDataBool(1UL, false);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(2, 0);
                }

                public bool Active
                {
                    get => this.ReadDataBool(0UL, false);
                    set => this.WriteData(0UL, value, false);
                }

                public float SteeringAngleDeg
                {
                    get => this.ReadDataFloat(32UL, 0F);
                    set => this.WriteData(32UL, value, 0F);
                }

                public float Output
                {
                    get => this.ReadDataFloat(64UL, 0F);
                    set => this.WriteData(64UL, value, 0F);
                }

                public bool Saturated
                {
                    get => this.ReadDataBool(1UL, false);
                    set => this.WriteData(1UL, value, false);
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xc3cbae1fd505ae80UL)]
    public class XYZTData : ICapnpSerializable
    {
        public const UInt64 typeId = 0xc3cbae1fd505ae80UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            X = reader.X;
            Y = reader.Y;
            Z = reader.Z;
            T = reader.T;
            XStd = reader.XStd;
            YStd = reader.YStd;
            ZStd = reader.ZStd;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.X.Init(X);
            writer.Y.Init(Y);
            writer.Z.Init(Z);
            writer.T.Init(T);
            writer.XStd.Init(XStd);
            writer.YStd.Init(YStd);
            writer.ZStd.Init(ZStd);
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public IReadOnlyList<float> X
        {
            get;
            set;
        }

        public IReadOnlyList<float> Y
        {
            get;
            set;
        }

        public IReadOnlyList<float> Z
        {
            get;
            set;
        }

        public IReadOnlyList<float> T
        {
            get;
            set;
        }

        public IReadOnlyList<float> XStd
        {
            get;
            set;
        }

        public IReadOnlyList<float> YStd
        {
            get;
            set;
        }

        public IReadOnlyList<float> ZStd
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public IReadOnlyList<float> X => ctx.ReadList(0).CastFloat();
            public IReadOnlyList<float> Y => ctx.ReadList(1).CastFloat();
            public IReadOnlyList<float> Z => ctx.ReadList(2).CastFloat();
            public IReadOnlyList<float> T => ctx.ReadList(3).CastFloat();
            public IReadOnlyList<float> XStd => ctx.ReadList(4).CastFloat();
            public IReadOnlyList<float> YStd => ctx.ReadList(5).CastFloat();
            public IReadOnlyList<float> ZStd => ctx.ReadList(6).CastFloat();
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(0, 7);
            }

            public ListOfPrimitivesSerializer<float> X
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(0);
                set => Link(0, value);
            }

            public ListOfPrimitivesSerializer<float> Y
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(1);
                set => Link(1, value);
            }

            public ListOfPrimitivesSerializer<float> Z
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(2);
                set => Link(2, value);
            }

            public ListOfPrimitivesSerializer<float> T
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(3);
                set => Link(3, value);
            }

            public ListOfPrimitivesSerializer<float> XStd
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(4);
                set => Link(4, value);
            }

            public ListOfPrimitivesSerializer<float> YStd
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(5);
                set => Link(5, value);
            }

            public ListOfPrimitivesSerializer<float> ZStd
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(6);
                set => Link(6, value);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xc4713f6b0d36abe9UL)]
    public class ModelDataV2 : ICapnpSerializable
    {
        public const UInt64 typeId = 0xc4713f6b0d36abe9UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            FrameId = reader.FrameId;
            FrameAge = reader.FrameAge;
            FrameDropPerc = reader.FrameDropPerc;
            TimestampEof = reader.TimestampEof;
            Position = CapnpSerializable.Create<Cereal.XYZTData>(reader.Position);
            Orientation = CapnpSerializable.Create<Cereal.XYZTData>(reader.Orientation);
            Velocity = CapnpSerializable.Create<Cereal.XYZTData>(reader.Velocity);
            OrientationRate = CapnpSerializable.Create<Cereal.XYZTData>(reader.OrientationRate);
            LaneLines = reader.LaneLines?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.XYZTData>(_));
            LaneLineProbs = reader.LaneLineProbs;
            RoadEdges = reader.RoadEdges?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.XYZTData>(_));
            Leads = reader.Leads?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.ModelDataV2.LeadDataV2>(_));
            Meta = CapnpSerializable.Create<Cereal.ModelDataV2.MetaData>(reader.Meta);
            LaneLineStds = reader.LaneLineStds;
            RoadEdgeStds = reader.RoadEdgeStds;
            ModelExecutionTime = reader.ModelExecutionTime;
            RawPredictions = reader.RawPredictions;
            GpuExecutionTime = reader.GpuExecutionTime;
            LeadsV3 = reader.LeadsV3?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.ModelDataV2.LeadDataV3>(_));
            Acceleration = CapnpSerializable.Create<Cereal.XYZTData>(reader.Acceleration);
            FrameIdExtra = reader.FrameIdExtra;
            TemporalPose = CapnpSerializable.Create<Cereal.ModelDataV2.Pose>(reader.TemporalPose);
            NavEnabled = reader.NavEnabled;
            Confidence = reader.Confidence;
            LocationMonoTime = reader.LocationMonoTime;
            LateralPlannerSolutionDEPRECATED = CapnpSerializable.Create<Cereal.ModelDataV2.LateralPlannerSolution>(reader.LateralPlannerSolutionDEPRECATED);
            TheAction = CapnpSerializable.Create<Cereal.ModelDataV2.Action>(reader.TheAction);
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.FrameId = FrameId;
            writer.FrameAge = FrameAge;
            writer.FrameDropPerc = FrameDropPerc;
            writer.TimestampEof = TimestampEof;
            Position?.serialize(writer.Position);
            Orientation?.serialize(writer.Orientation);
            Velocity?.serialize(writer.Velocity);
            OrientationRate?.serialize(writer.OrientationRate);
            writer.LaneLines.Init(LaneLines, (_s1, _v1) => _v1?.serialize(_s1));
            writer.LaneLineProbs.Init(LaneLineProbs);
            writer.RoadEdges.Init(RoadEdges, (_s1, _v1) => _v1?.serialize(_s1));
            writer.Leads.Init(Leads, (_s1, _v1) => _v1?.serialize(_s1));
            Meta?.serialize(writer.Meta);
            writer.LaneLineStds.Init(LaneLineStds);
            writer.RoadEdgeStds.Init(RoadEdgeStds);
            writer.ModelExecutionTime = ModelExecutionTime;
            writer.RawPredictions.Init(RawPredictions);
            writer.GpuExecutionTime = GpuExecutionTime;
            writer.LeadsV3.Init(LeadsV3, (_s1, _v1) => _v1?.serialize(_s1));
            Acceleration?.serialize(writer.Acceleration);
            writer.FrameIdExtra = FrameIdExtra;
            TemporalPose?.serialize(writer.TemporalPose);
            writer.NavEnabled = NavEnabled;
            writer.Confidence = Confidence;
            writer.LocationMonoTime = LocationMonoTime;
            LateralPlannerSolutionDEPRECATED?.serialize(writer.LateralPlannerSolutionDEPRECATED);
            TheAction?.serialize(writer.TheAction);
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public uint FrameId
        {
            get;
            set;
        }

        public uint FrameAge
        {
            get;
            set;
        }

        public float FrameDropPerc
        {
            get;
            set;
        }

        public ulong TimestampEof
        {
            get;
            set;
        }

        public Cereal.XYZTData Position
        {
            get;
            set;
        }

        public Cereal.XYZTData Orientation
        {
            get;
            set;
        }

        public Cereal.XYZTData Velocity
        {
            get;
            set;
        }

        public Cereal.XYZTData OrientationRate
        {
            get;
            set;
        }

        public IReadOnlyList<Cereal.XYZTData> LaneLines
        {
            get;
            set;
        }

        public IReadOnlyList<float> LaneLineProbs
        {
            get;
            set;
        }

        public IReadOnlyList<Cereal.XYZTData> RoadEdges
        {
            get;
            set;
        }

        public IReadOnlyList<Cereal.ModelDataV2.LeadDataV2> Leads
        {
            get;
            set;
        }

        public Cereal.ModelDataV2.MetaData Meta
        {
            get;
            set;
        }

        public IReadOnlyList<float> LaneLineStds
        {
            get;
            set;
        }

        public IReadOnlyList<float> RoadEdgeStds
        {
            get;
            set;
        }

        public float ModelExecutionTime
        {
            get;
            set;
        }

        public IReadOnlyList<byte> RawPredictions
        {
            get;
            set;
        }

        public float GpuExecutionTime
        {
            get;
            set;
        }

        public IReadOnlyList<Cereal.ModelDataV2.LeadDataV3> LeadsV3
        {
            get;
            set;
        }

        public Cereal.XYZTData Acceleration
        {
            get;
            set;
        }

        public uint FrameIdExtra
        {
            get;
            set;
        }

        public Cereal.ModelDataV2.Pose TemporalPose
        {
            get;
            set;
        }

        public bool NavEnabled
        {
            get;
            set;
        }

        public Cereal.ModelDataV2.ConfidenceClass Confidence
        {
            get;
            set;
        }

        public ulong LocationMonoTime
        {
            get;
            set;
        }

        public Cereal.ModelDataV2.LateralPlannerSolution LateralPlannerSolutionDEPRECATED
        {
            get;
            set;
        }

        public Cereal.ModelDataV2.Action TheAction
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public uint FrameId => ctx.ReadDataUInt(0UL, 0U);
            public uint FrameAge => ctx.ReadDataUInt(32UL, 0U);
            public float FrameDropPerc => ctx.ReadDataFloat(64UL, 0F);
            public ulong TimestampEof => ctx.ReadDataULong(128UL, 0UL);
            public Cereal.XYZTData.READER Position => ctx.ReadStruct(0, Cereal.XYZTData.READER.create);
            public Cereal.XYZTData.READER Orientation => ctx.ReadStruct(1, Cereal.XYZTData.READER.create);
            public Cereal.XYZTData.READER Velocity => ctx.ReadStruct(2, Cereal.XYZTData.READER.create);
            public Cereal.XYZTData.READER OrientationRate => ctx.ReadStruct(3, Cereal.XYZTData.READER.create);
            public IReadOnlyList<Cereal.XYZTData.READER> LaneLines => ctx.ReadList(4).Cast(Cereal.XYZTData.READER.create);
            public IReadOnlyList<float> LaneLineProbs => ctx.ReadList(5).CastFloat();
            public IReadOnlyList<Cereal.XYZTData.READER> RoadEdges => ctx.ReadList(6).Cast(Cereal.XYZTData.READER.create);
            public IReadOnlyList<Cereal.ModelDataV2.LeadDataV2.READER> Leads => ctx.ReadList(7).Cast(Cereal.ModelDataV2.LeadDataV2.READER.create);
            public Cereal.ModelDataV2.MetaData.READER Meta => ctx.ReadStruct(8, Cereal.ModelDataV2.MetaData.READER.create);
            public IReadOnlyList<float> LaneLineStds => ctx.ReadList(9).CastFloat();
            public IReadOnlyList<float> RoadEdgeStds => ctx.ReadList(10).CastFloat();
            public float ModelExecutionTime => ctx.ReadDataFloat(96UL, 0F);
            public IReadOnlyList<byte> RawPredictions => ctx.ReadList(11).CastByte();
            public float GpuExecutionTime => ctx.ReadDataFloat(192UL, 0F);
            public IReadOnlyList<Cereal.ModelDataV2.LeadDataV3.READER> LeadsV3 => ctx.ReadList(12).Cast(Cereal.ModelDataV2.LeadDataV3.READER.create);
            public Cereal.XYZTData.READER Acceleration => ctx.ReadStruct(13, Cereal.XYZTData.READER.create);
            public uint FrameIdExtra => ctx.ReadDataUInt(224UL, 0U);
            public Cereal.ModelDataV2.Pose.READER TemporalPose => ctx.ReadStruct(14, Cereal.ModelDataV2.Pose.READER.create);
            public bool NavEnabled => ctx.ReadDataBool(256UL, false);
            public Cereal.ModelDataV2.ConfidenceClass Confidence => (Cereal.ModelDataV2.ConfidenceClass)ctx.ReadDataUShort(272UL, (ushort)0);
            public ulong LocationMonoTime => ctx.ReadDataULong(320UL, 0UL);
            public Cereal.ModelDataV2.LateralPlannerSolution.READER LateralPlannerSolutionDEPRECATED => ctx.ReadStruct(15, Cereal.ModelDataV2.LateralPlannerSolution.READER.create);
            public Cereal.ModelDataV2.Action.READER TheAction => ctx.ReadStruct(16, Cereal.ModelDataV2.Action.READER.create);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(6, 17);
            }

            public uint FrameId
            {
                get => this.ReadDataUInt(0UL, 0U);
                set => this.WriteData(0UL, value, 0U);
            }

            public uint FrameAge
            {
                get => this.ReadDataUInt(32UL, 0U);
                set => this.WriteData(32UL, value, 0U);
            }

            public float FrameDropPerc
            {
                get => this.ReadDataFloat(64UL, 0F);
                set => this.WriteData(64UL, value, 0F);
            }

            public ulong TimestampEof
            {
                get => this.ReadDataULong(128UL, 0UL);
                set => this.WriteData(128UL, value, 0UL);
            }

            public Cereal.XYZTData.WRITER Position
            {
                get => BuildPointer<Cereal.XYZTData.WRITER>(0);
                set => Link(0, value);
            }

            public Cereal.XYZTData.WRITER Orientation
            {
                get => BuildPointer<Cereal.XYZTData.WRITER>(1);
                set => Link(1, value);
            }

            public Cereal.XYZTData.WRITER Velocity
            {
                get => BuildPointer<Cereal.XYZTData.WRITER>(2);
                set => Link(2, value);
            }

            public Cereal.XYZTData.WRITER OrientationRate
            {
                get => BuildPointer<Cereal.XYZTData.WRITER>(3);
                set => Link(3, value);
            }

            public ListOfStructsSerializer<Cereal.XYZTData.WRITER> LaneLines
            {
                get => BuildPointer<ListOfStructsSerializer<Cereal.XYZTData.WRITER>>(4);
                set => Link(4, value);
            }

            public ListOfPrimitivesSerializer<float> LaneLineProbs
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(5);
                set => Link(5, value);
            }

            public ListOfStructsSerializer<Cereal.XYZTData.WRITER> RoadEdges
            {
                get => BuildPointer<ListOfStructsSerializer<Cereal.XYZTData.WRITER>>(6);
                set => Link(6, value);
            }

            public ListOfStructsSerializer<Cereal.ModelDataV2.LeadDataV2.WRITER> Leads
            {
                get => BuildPointer<ListOfStructsSerializer<Cereal.ModelDataV2.LeadDataV2.WRITER>>(7);
                set => Link(7, value);
            }

            public Cereal.ModelDataV2.MetaData.WRITER Meta
            {
                get => BuildPointer<Cereal.ModelDataV2.MetaData.WRITER>(8);
                set => Link(8, value);
            }

            public ListOfPrimitivesSerializer<float> LaneLineStds
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(9);
                set => Link(9, value);
            }

            public ListOfPrimitivesSerializer<float> RoadEdgeStds
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(10);
                set => Link(10, value);
            }

            public float ModelExecutionTime
            {
                get => this.ReadDataFloat(96UL, 0F);
                set => this.WriteData(96UL, value, 0F);
            }

            public ListOfPrimitivesSerializer<byte> RawPredictions
            {
                get => BuildPointer<ListOfPrimitivesSerializer<byte>>(11);
                set => Link(11, value);
            }

            public float GpuExecutionTime
            {
                get => this.ReadDataFloat(192UL, 0F);
                set => this.WriteData(192UL, value, 0F);
            }

            public ListOfStructsSerializer<Cereal.ModelDataV2.LeadDataV3.WRITER> LeadsV3
            {
                get => BuildPointer<ListOfStructsSerializer<Cereal.ModelDataV2.LeadDataV3.WRITER>>(12);
                set => Link(12, value);
            }

            public Cereal.XYZTData.WRITER Acceleration
            {
                get => BuildPointer<Cereal.XYZTData.WRITER>(13);
                set => Link(13, value);
            }

            public uint FrameIdExtra
            {
                get => this.ReadDataUInt(224UL, 0U);
                set => this.WriteData(224UL, value, 0U);
            }

            public Cereal.ModelDataV2.Pose.WRITER TemporalPose
            {
                get => BuildPointer<Cereal.ModelDataV2.Pose.WRITER>(14);
                set => Link(14, value);
            }

            public bool NavEnabled
            {
                get => this.ReadDataBool(256UL, false);
                set => this.WriteData(256UL, value, false);
            }

            public Cereal.ModelDataV2.ConfidenceClass Confidence
            {
                get => (Cereal.ModelDataV2.ConfidenceClass)this.ReadDataUShort(272UL, (ushort)0);
                set => this.WriteData(272UL, (ushort)value, (ushort)0);
            }

            public ulong LocationMonoTime
            {
                get => this.ReadDataULong(320UL, 0UL);
                set => this.WriteData(320UL, value, 0UL);
            }

            public Cereal.ModelDataV2.LateralPlannerSolution.WRITER LateralPlannerSolutionDEPRECATED
            {
                get => BuildPointer<Cereal.ModelDataV2.LateralPlannerSolution.WRITER>(15);
                set => Link(15, value);
            }

            public Cereal.ModelDataV2.Action.WRITER TheAction
            {
                get => BuildPointer<Cereal.ModelDataV2.Action.WRITER>(16);
                set => Link(16, value);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xa444ed2b2187af28UL)]
        public class LeadDataV2 : ICapnpSerializable
        {
            public const UInt64 typeId = 0xa444ed2b2187af28UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Prob = reader.Prob;
                T = reader.T;
                Xyva = reader.Xyva;
                XyvaStd = reader.XyvaStd;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Prob = Prob;
                writer.T = T;
                writer.Xyva.Init(Xyva);
                writer.XyvaStd.Init(XyvaStd);
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public float Prob
            {
                get;
                set;
            }

            public float T
            {
                get;
                set;
            }

            public IReadOnlyList<float> Xyva
            {
                get;
                set;
            }

            public IReadOnlyList<float> XyvaStd
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public float Prob => ctx.ReadDataFloat(0UL, 0F);
                public float T => ctx.ReadDataFloat(32UL, 0F);
                public IReadOnlyList<float> Xyva => ctx.ReadList(0).CastFloat();
                public IReadOnlyList<float> XyvaStd => ctx.ReadList(1).CastFloat();
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(1, 2);
                }

                public float Prob
                {
                    get => this.ReadDataFloat(0UL, 0F);
                    set => this.WriteData(0UL, value, 0F);
                }

                public float T
                {
                    get => this.ReadDataFloat(32UL, 0F);
                    set => this.WriteData(32UL, value, 0F);
                }

                public ListOfPrimitivesSerializer<float> Xyva
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(0);
                    set => Link(0, value);
                }

                public ListOfPrimitivesSerializer<float> XyvaStd
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(1);
                    set => Link(1, value);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xd698881ad0ce7febUL)]
        public class LeadDataV3 : ICapnpSerializable
        {
            public const UInt64 typeId = 0xd698881ad0ce7febUL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Prob = reader.Prob;
                ProbTime = reader.ProbTime;
                T = reader.T;
                X = reader.X;
                XStd = reader.XStd;
                Y = reader.Y;
                YStd = reader.YStd;
                V = reader.V;
                VStd = reader.VStd;
                A = reader.A;
                AStd = reader.AStd;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Prob = Prob;
                writer.ProbTime = ProbTime;
                writer.T.Init(T);
                writer.X.Init(X);
                writer.XStd.Init(XStd);
                writer.Y.Init(Y);
                writer.YStd.Init(YStd);
                writer.V.Init(V);
                writer.VStd.Init(VStd);
                writer.A.Init(A);
                writer.AStd.Init(AStd);
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public float Prob
            {
                get;
                set;
            }

            public float ProbTime
            {
                get;
                set;
            }

            public IReadOnlyList<float> T
            {
                get;
                set;
            }

            public IReadOnlyList<float> X
            {
                get;
                set;
            }

            public IReadOnlyList<float> XStd
            {
                get;
                set;
            }

            public IReadOnlyList<float> Y
            {
                get;
                set;
            }

            public IReadOnlyList<float> YStd
            {
                get;
                set;
            }

            public IReadOnlyList<float> V
            {
                get;
                set;
            }

            public IReadOnlyList<float> VStd
            {
                get;
                set;
            }

            public IReadOnlyList<float> A
            {
                get;
                set;
            }

            public IReadOnlyList<float> AStd
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public float Prob => ctx.ReadDataFloat(0UL, 0F);
                public float ProbTime => ctx.ReadDataFloat(32UL, 0F);
                public IReadOnlyList<float> T => ctx.ReadList(0).CastFloat();
                public IReadOnlyList<float> X => ctx.ReadList(1).CastFloat();
                public IReadOnlyList<float> XStd => ctx.ReadList(2).CastFloat();
                public IReadOnlyList<float> Y => ctx.ReadList(3).CastFloat();
                public IReadOnlyList<float> YStd => ctx.ReadList(4).CastFloat();
                public IReadOnlyList<float> V => ctx.ReadList(5).CastFloat();
                public IReadOnlyList<float> VStd => ctx.ReadList(6).CastFloat();
                public IReadOnlyList<float> A => ctx.ReadList(7).CastFloat();
                public IReadOnlyList<float> AStd => ctx.ReadList(8).CastFloat();
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(1, 9);
                }

                public float Prob
                {
                    get => this.ReadDataFloat(0UL, 0F);
                    set => this.WriteData(0UL, value, 0F);
                }

                public float ProbTime
                {
                    get => this.ReadDataFloat(32UL, 0F);
                    set => this.WriteData(32UL, value, 0F);
                }

                public ListOfPrimitivesSerializer<float> T
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(0);
                    set => Link(0, value);
                }

                public ListOfPrimitivesSerializer<float> X
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(1);
                    set => Link(1, value);
                }

                public ListOfPrimitivesSerializer<float> XStd
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(2);
                    set => Link(2, value);
                }

                public ListOfPrimitivesSerializer<float> Y
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(3);
                    set => Link(3, value);
                }

                public ListOfPrimitivesSerializer<float> YStd
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(4);
                    set => Link(4, value);
                }

                public ListOfPrimitivesSerializer<float> V
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(5);
                    set => Link(5, value);
                }

                public ListOfPrimitivesSerializer<float> VStd
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(6);
                    set => Link(6, value);
                }

                public ListOfPrimitivesSerializer<float> A
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(7);
                    set => Link(7, value);
                }

                public ListOfPrimitivesSerializer<float> AStd
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(8);
                    set => Link(8, value);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xd1646ab3b45cfabdUL)]
        public class MetaData : ICapnpSerializable
        {
            public const UInt64 typeId = 0xd1646ab3b45cfabdUL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                EngagedProb = reader.EngagedProb;
                DesirePrediction = reader.DesirePrediction;
                BrakeDisengageProbDEPRECATED = reader.BrakeDisengageProbDEPRECATED;
                GasDisengageProbDEPRECATED = reader.GasDisengageProbDEPRECATED;
                SteerOverrideProbDEPRECATED = reader.SteerOverrideProbDEPRECATED;
                DesireState = reader.DesireState;
                DisengagePredictions = CapnpSerializable.Create<Cereal.ModelDataV2.DisengagePredictions>(reader.DisengagePredictions);
                HardBrakePredicted = reader.HardBrakePredicted;
                LaneChangeState = reader.LaneChangeState;
                LaneChangeDirection = reader.LaneChangeDirection;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.EngagedProb = EngagedProb;
                writer.DesirePrediction.Init(DesirePrediction);
                writer.BrakeDisengageProbDEPRECATED = BrakeDisengageProbDEPRECATED;
                writer.GasDisengageProbDEPRECATED = GasDisengageProbDEPRECATED;
                writer.SteerOverrideProbDEPRECATED = SteerOverrideProbDEPRECATED;
                writer.DesireState.Init(DesireState);
                DisengagePredictions?.serialize(writer.DisengagePredictions);
                writer.HardBrakePredicted = HardBrakePredicted;
                writer.LaneChangeState = LaneChangeState;
                writer.LaneChangeDirection = LaneChangeDirection;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public float EngagedProb
            {
                get;
                set;
            }

            public IReadOnlyList<float> DesirePrediction
            {
                get;
                set;
            }

            public float BrakeDisengageProbDEPRECATED
            {
                get;
                set;
            }

            public float GasDisengageProbDEPRECATED
            {
                get;
                set;
            }

            public float SteerOverrideProbDEPRECATED
            {
                get;
                set;
            }

            public IReadOnlyList<float> DesireState
            {
                get;
                set;
            }

            public Cereal.ModelDataV2.DisengagePredictions DisengagePredictions
            {
                get;
                set;
            }

            public bool HardBrakePredicted
            {
                get;
                set;
            }

            public Cereal.LaneChangeState LaneChangeState
            {
                get;
                set;
            }

            public Cereal.LaneChangeDirection LaneChangeDirection
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public float EngagedProb => ctx.ReadDataFloat(0UL, 0F);
                public IReadOnlyList<float> DesirePrediction => ctx.ReadList(0).CastFloat();
                public float BrakeDisengageProbDEPRECATED => ctx.ReadDataFloat(32UL, 0F);
                public float GasDisengageProbDEPRECATED => ctx.ReadDataFloat(64UL, 0F);
                public float SteerOverrideProbDEPRECATED => ctx.ReadDataFloat(96UL, 0F);
                public IReadOnlyList<float> DesireState => ctx.ReadList(1).CastFloat();
                public Cereal.ModelDataV2.DisengagePredictions.READER DisengagePredictions => ctx.ReadStruct(2, Cereal.ModelDataV2.DisengagePredictions.READER.create);
                public bool HardBrakePredicted => ctx.ReadDataBool(128UL, false);
                public Cereal.LaneChangeState LaneChangeState => (Cereal.LaneChangeState)ctx.ReadDataUShort(144UL, (ushort)0);
                public Cereal.LaneChangeDirection LaneChangeDirection => (Cereal.LaneChangeDirection)ctx.ReadDataUShort(160UL, (ushort)0);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(3, 3);
                }

                public float EngagedProb
                {
                    get => this.ReadDataFloat(0UL, 0F);
                    set => this.WriteData(0UL, value, 0F);
                }

                public ListOfPrimitivesSerializer<float> DesirePrediction
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(0);
                    set => Link(0, value);
                }

                public float BrakeDisengageProbDEPRECATED
                {
                    get => this.ReadDataFloat(32UL, 0F);
                    set => this.WriteData(32UL, value, 0F);
                }

                public float GasDisengageProbDEPRECATED
                {
                    get => this.ReadDataFloat(64UL, 0F);
                    set => this.WriteData(64UL, value, 0F);
                }

                public float SteerOverrideProbDEPRECATED
                {
                    get => this.ReadDataFloat(96UL, 0F);
                    set => this.WriteData(96UL, value, 0F);
                }

                public ListOfPrimitivesSerializer<float> DesireState
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(1);
                    set => Link(1, value);
                }

                public Cereal.ModelDataV2.DisengagePredictions.WRITER DisengagePredictions
                {
                    get => BuildPointer<Cereal.ModelDataV2.DisengagePredictions.WRITER>(2);
                    set => Link(2, value);
                }

                public bool HardBrakePredicted
                {
                    get => this.ReadDataBool(128UL, false);
                    set => this.WriteData(128UL, value, false);
                }

                public Cereal.LaneChangeState LaneChangeState
                {
                    get => (Cereal.LaneChangeState)this.ReadDataUShort(144UL, (ushort)0);
                    set => this.WriteData(144UL, (ushort)value, (ushort)0);
                }

                public Cereal.LaneChangeDirection LaneChangeDirection
                {
                    get => (Cereal.LaneChangeDirection)this.ReadDataUShort(160UL, (ushort)0);
                    set => this.WriteData(160UL, (ushort)value, (ushort)0);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xaa3247d9d2a61cd4UL)]
        public enum ConfidenceClass : ushort
        {
            red,
            yellow,
            green
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x860aa5ddbcdc8d25UL)]
        public class DisengagePredictions : ICapnpSerializable
        {
            public const UInt64 typeId = 0x860aa5ddbcdc8d25UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                T = reader.T;
                BrakeDisengageProbs = reader.BrakeDisengageProbs;
                GasDisengageProbs = reader.GasDisengageProbs;
                SteerOverrideProbs = reader.SteerOverrideProbs;
                Brake3MetersPerSecondSquaredProbs = reader.Brake3MetersPerSecondSquaredProbs;
                Brake4MetersPerSecondSquaredProbs = reader.Brake4MetersPerSecondSquaredProbs;
                Brake5MetersPerSecondSquaredProbs = reader.Brake5MetersPerSecondSquaredProbs;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.T.Init(T);
                writer.BrakeDisengageProbs.Init(BrakeDisengageProbs);
                writer.GasDisengageProbs.Init(GasDisengageProbs);
                writer.SteerOverrideProbs.Init(SteerOverrideProbs);
                writer.Brake3MetersPerSecondSquaredProbs.Init(Brake3MetersPerSecondSquaredProbs);
                writer.Brake4MetersPerSecondSquaredProbs.Init(Brake4MetersPerSecondSquaredProbs);
                writer.Brake5MetersPerSecondSquaredProbs.Init(Brake5MetersPerSecondSquaredProbs);
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public IReadOnlyList<float> T
            {
                get;
                set;
            }

            public IReadOnlyList<float> BrakeDisengageProbs
            {
                get;
                set;
            }

            public IReadOnlyList<float> GasDisengageProbs
            {
                get;
                set;
            }

            public IReadOnlyList<float> SteerOverrideProbs
            {
                get;
                set;
            }

            public IReadOnlyList<float> Brake3MetersPerSecondSquaredProbs
            {
                get;
                set;
            }

            public IReadOnlyList<float> Brake4MetersPerSecondSquaredProbs
            {
                get;
                set;
            }

            public IReadOnlyList<float> Brake5MetersPerSecondSquaredProbs
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public IReadOnlyList<float> T => ctx.ReadList(0).CastFloat();
                public IReadOnlyList<float> BrakeDisengageProbs => ctx.ReadList(1).CastFloat();
                public IReadOnlyList<float> GasDisengageProbs => ctx.ReadList(2).CastFloat();
                public IReadOnlyList<float> SteerOverrideProbs => ctx.ReadList(3).CastFloat();
                public IReadOnlyList<float> Brake3MetersPerSecondSquaredProbs => ctx.ReadList(4).CastFloat();
                public IReadOnlyList<float> Brake4MetersPerSecondSquaredProbs => ctx.ReadList(5).CastFloat();
                public IReadOnlyList<float> Brake5MetersPerSecondSquaredProbs => ctx.ReadList(6).CastFloat();
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 7);
                }

                public ListOfPrimitivesSerializer<float> T
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(0);
                    set => Link(0, value);
                }

                public ListOfPrimitivesSerializer<float> BrakeDisengageProbs
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(1);
                    set => Link(1, value);
                }

                public ListOfPrimitivesSerializer<float> GasDisengageProbs
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(2);
                    set => Link(2, value);
                }

                public ListOfPrimitivesSerializer<float> SteerOverrideProbs
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(3);
                    set => Link(3, value);
                }

                public ListOfPrimitivesSerializer<float> Brake3MetersPerSecondSquaredProbs
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(4);
                    set => Link(4, value);
                }

                public ListOfPrimitivesSerializer<float> Brake4MetersPerSecondSquaredProbs
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(5);
                    set => Link(5, value);
                }

                public ListOfPrimitivesSerializer<float> Brake5MetersPerSecondSquaredProbs
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(6);
                    set => Link(6, value);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xfb3ec0702e67884fUL)]
        public class Pose : ICapnpSerializable
        {
            public const UInt64 typeId = 0xfb3ec0702e67884fUL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Trans = reader.Trans;
                Rot = reader.Rot;
                TransStd = reader.TransStd;
                RotStd = reader.RotStd;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Trans.Init(Trans);
                writer.Rot.Init(Rot);
                writer.TransStd.Init(TransStd);
                writer.RotStd.Init(RotStd);
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public IReadOnlyList<float> Trans
            {
                get;
                set;
            }

            public IReadOnlyList<float> Rot
            {
                get;
                set;
            }

            public IReadOnlyList<float> TransStd
            {
                get;
                set;
            }

            public IReadOnlyList<float> RotStd
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public IReadOnlyList<float> Trans => ctx.ReadList(0).CastFloat();
                public IReadOnlyList<float> Rot => ctx.ReadList(1).CastFloat();
                public IReadOnlyList<float> TransStd => ctx.ReadList(2).CastFloat();
                public IReadOnlyList<float> RotStd => ctx.ReadList(3).CastFloat();
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 4);
                }

                public ListOfPrimitivesSerializer<float> Trans
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(0);
                    set => Link(0, value);
                }

                public ListOfPrimitivesSerializer<float> Rot
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(1);
                    set => Link(1, value);
                }

                public ListOfPrimitivesSerializer<float> TransStd
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(2);
                    set => Link(2, value);
                }

                public ListOfPrimitivesSerializer<float> RotStd
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(3);
                    set => Link(3, value);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x84caeca5a6b4acfeUL)]
        public class LateralPlannerSolution : ICapnpSerializable
        {
            public const UInt64 typeId = 0x84caeca5a6b4acfeUL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                X = reader.X;
                Y = reader.Y;
                Yaw = reader.Yaw;
                YawRate = reader.YawRate;
                XStd = reader.XStd;
                YStd = reader.YStd;
                YawStd = reader.YawStd;
                YawRateStd = reader.YawRateStd;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.X.Init(X);
                writer.Y.Init(Y);
                writer.Yaw.Init(Yaw);
                writer.YawRate.Init(YawRate);
                writer.XStd.Init(XStd);
                writer.YStd.Init(YStd);
                writer.YawStd.Init(YawStd);
                writer.YawRateStd.Init(YawRateStd);
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public IReadOnlyList<float> X
            {
                get;
                set;
            }

            public IReadOnlyList<float> Y
            {
                get;
                set;
            }

            public IReadOnlyList<float> Yaw
            {
                get;
                set;
            }

            public IReadOnlyList<float> YawRate
            {
                get;
                set;
            }

            public IReadOnlyList<float> XStd
            {
                get;
                set;
            }

            public IReadOnlyList<float> YStd
            {
                get;
                set;
            }

            public IReadOnlyList<float> YawStd
            {
                get;
                set;
            }

            public IReadOnlyList<float> YawRateStd
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public IReadOnlyList<float> X => ctx.ReadList(0).CastFloat();
                public IReadOnlyList<float> Y => ctx.ReadList(1).CastFloat();
                public IReadOnlyList<float> Yaw => ctx.ReadList(2).CastFloat();
                public IReadOnlyList<float> YawRate => ctx.ReadList(3).CastFloat();
                public IReadOnlyList<float> XStd => ctx.ReadList(4).CastFloat();
                public IReadOnlyList<float> YStd => ctx.ReadList(5).CastFloat();
                public IReadOnlyList<float> YawStd => ctx.ReadList(6).CastFloat();
                public IReadOnlyList<float> YawRateStd => ctx.ReadList(7).CastFloat();
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 8);
                }

                public ListOfPrimitivesSerializer<float> X
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(0);
                    set => Link(0, value);
                }

                public ListOfPrimitivesSerializer<float> Y
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(1);
                    set => Link(1, value);
                }

                public ListOfPrimitivesSerializer<float> Yaw
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(2);
                    set => Link(2, value);
                }

                public ListOfPrimitivesSerializer<float> YawRate
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(3);
                    set => Link(3, value);
                }

                public ListOfPrimitivesSerializer<float> XStd
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(4);
                    set => Link(4, value);
                }

                public ListOfPrimitivesSerializer<float> YStd
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(5);
                    set => Link(5, value);
                }

                public ListOfPrimitivesSerializer<float> YawStd
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(6);
                    set => Link(6, value);
                }

                public ListOfPrimitivesSerializer<float> YawRateStd
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(7);
                    set => Link(7, value);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x94d0bcb35a764584UL)]
        public class Action : ICapnpSerializable
        {
            public const UInt64 typeId = 0x94d0bcb35a764584UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                DesiredCurvature = reader.DesiredCurvature;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.DesiredCurvature = DesiredCurvature;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public float DesiredCurvature
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public float DesiredCurvature => ctx.ReadDataFloat(0UL, 0F);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(1, 0);
                }

                public float DesiredCurvature
                {
                    get => this.ReadDataFloat(0UL, 0F);
                    set => this.WriteData(0UL, value, 0F);
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x89d394e3541735fcUL)]
    public class EncodeIndex : ICapnpSerializable
    {
        public const UInt64 typeId = 0x89d394e3541735fcUL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            FrameId = reader.FrameId;
            TheType = reader.TheType;
            EncodeId = reader.EncodeId;
            SegmentNum = reader.SegmentNum;
            SegmentId = reader.SegmentId;
            SegmentIdEncode = reader.SegmentIdEncode;
            TimestampSof = reader.TimestampSof;
            TimestampEof = reader.TimestampEof;
            Flags = reader.Flags;
            Len = reader.Len;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.FrameId = FrameId;
            writer.TheType = TheType;
            writer.EncodeId = EncodeId;
            writer.SegmentNum = SegmentNum;
            writer.SegmentId = SegmentId;
            writer.SegmentIdEncode = SegmentIdEncode;
            writer.TimestampSof = TimestampSof;
            writer.TimestampEof = TimestampEof;
            writer.Flags = Flags;
            writer.Len = Len;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public uint FrameId
        {
            get;
            set;
        }

        public Cereal.EncodeIndex.Type TheType
        {
            get;
            set;
        }

        public uint EncodeId
        {
            get;
            set;
        }

        public int SegmentNum
        {
            get;
            set;
        }

        public uint SegmentId
        {
            get;
            set;
        }

        public uint SegmentIdEncode
        {
            get;
            set;
        }

        public ulong TimestampSof
        {
            get;
            set;
        }

        public ulong TimestampEof
        {
            get;
            set;
        }

        public uint Flags
        {
            get;
            set;
        }

        public uint Len
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public uint FrameId => ctx.ReadDataUInt(0UL, 0U);
            public Cereal.EncodeIndex.Type TheType => (Cereal.EncodeIndex.Type)ctx.ReadDataUShort(32UL, (ushort)0);
            public uint EncodeId => ctx.ReadDataUInt(64UL, 0U);
            public int SegmentNum => ctx.ReadDataInt(96UL, 0);
            public uint SegmentId => ctx.ReadDataUInt(128UL, 0U);
            public uint SegmentIdEncode => ctx.ReadDataUInt(160UL, 0U);
            public ulong TimestampSof => ctx.ReadDataULong(192UL, 0UL);
            public ulong TimestampEof => ctx.ReadDataULong(256UL, 0UL);
            public uint Flags => ctx.ReadDataUInt(320UL, 0U);
            public uint Len => ctx.ReadDataUInt(352UL, 0U);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(6, 0);
            }

            public uint FrameId
            {
                get => this.ReadDataUInt(0UL, 0U);
                set => this.WriteData(0UL, value, 0U);
            }

            public Cereal.EncodeIndex.Type TheType
            {
                get => (Cereal.EncodeIndex.Type)this.ReadDataUShort(32UL, (ushort)0);
                set => this.WriteData(32UL, (ushort)value, (ushort)0);
            }

            public uint EncodeId
            {
                get => this.ReadDataUInt(64UL, 0U);
                set => this.WriteData(64UL, value, 0U);
            }

            public int SegmentNum
            {
                get => this.ReadDataInt(96UL, 0);
                set => this.WriteData(96UL, value, 0);
            }

            public uint SegmentId
            {
                get => this.ReadDataUInt(128UL, 0U);
                set => this.WriteData(128UL, value, 0U);
            }

            public uint SegmentIdEncode
            {
                get => this.ReadDataUInt(160UL, 0U);
                set => this.WriteData(160UL, value, 0U);
            }

            public ulong TimestampSof
            {
                get => this.ReadDataULong(192UL, 0UL);
                set => this.WriteData(192UL, value, 0UL);
            }

            public ulong TimestampEof
            {
                get => this.ReadDataULong(256UL, 0UL);
                set => this.WriteData(256UL, value, 0UL);
            }

            public uint Flags
            {
                get => this.ReadDataUInt(320UL, 0U);
                set => this.WriteData(320UL, value, 0U);
            }

            public uint Len
            {
                get => this.ReadDataUInt(352UL, 0U);
                set => this.WriteData(352UL, value, 0U);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xc0ad259ec157ccd3UL)]
        public enum Type : ushort
        {
            bigBoxLossless,
            fullHEVC,
            qcameraH264,
            livestreamH264,
            bigBoxHEVCDEPRECATED,
            chffrAndroidH264DEPRECATED,
            fullLosslessClipDEPRECATED,
            frontDEPRECATED
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xea095da1894f7d85UL)]
    public class AndroidLogEntry : ICapnpSerializable
    {
        public const UInt64 typeId = 0xea095da1894f7d85UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            Id = reader.Id;
            Ts = reader.Ts;
            Priority = reader.Priority;
            Pid = reader.Pid;
            Tid = reader.Tid;
            Tag = reader.Tag;
            Message = reader.Message;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.Id = Id;
            writer.Ts = Ts;
            writer.Priority = Priority;
            writer.Pid = Pid;
            writer.Tid = Tid;
            writer.Tag = Tag;
            writer.Message = Message;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public byte Id
        {
            get;
            set;
        }

        public ulong Ts
        {
            get;
            set;
        }

        public byte Priority
        {
            get;
            set;
        }

        public int Pid
        {
            get;
            set;
        }

        public int Tid
        {
            get;
            set;
        }

        public string Tag
        {
            get;
            set;
        }

        public string Message
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public byte Id => ctx.ReadDataByte(0UL, (byte)0);
            public ulong Ts => ctx.ReadDataULong(64UL, 0UL);
            public byte Priority => ctx.ReadDataByte(8UL, (byte)0);
            public int Pid => ctx.ReadDataInt(32UL, 0);
            public int Tid => ctx.ReadDataInt(128UL, 0);
            public string Tag => ctx.ReadText(0, null);
            public string Message => ctx.ReadText(1, null);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(3, 2);
            }

            public byte Id
            {
                get => this.ReadDataByte(0UL, (byte)0);
                set => this.WriteData(0UL, value, (byte)0);
            }

            public ulong Ts
            {
                get => this.ReadDataULong(64UL, 0UL);
                set => this.WriteData(64UL, value, 0UL);
            }

            public byte Priority
            {
                get => this.ReadDataByte(8UL, (byte)0);
                set => this.WriteData(8UL, value, (byte)0);
            }

            public int Pid
            {
                get => this.ReadDataInt(32UL, 0);
                set => this.WriteData(32UL, value, 0);
            }

            public int Tid
            {
                get => this.ReadDataInt(128UL, 0);
                set => this.WriteData(128UL, value, 0);
            }

            public string Tag
            {
                get => this.ReadText(0, null);
                set => this.WriteText(0, value, null);
            }

            public string Message
            {
                get => this.ReadText(1, null);
                set => this.WriteText(1, value, null);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xe00b5b3eba12876cUL)]
    public class LongitudinalPlan : ICapnpSerializable
    {
        public const UInt64 typeId = 0xe00b5b3eba12876cUL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            LateralValidDEPRECATED = reader.LateralValidDEPRECATED;
            DPolyDEPRECATED = reader.DPolyDEPRECATED;
            LongitudinalValidDEPRECATED = reader.LongitudinalValidDEPRECATED;
            VTargetDEPRECATED = reader.VTargetDEPRECATED;
            ATargetMinDEPRECATED = reader.ATargetMinDEPRECATED;
            ATargetMaxDEPRECATED = reader.ATargetMaxDEPRECATED;
            JerkFactorDEPRECATED = reader.JerkFactorDEPRECATED;
            HasLead = reader.HasLead;
            Fcw = reader.Fcw;
            ModelMonoTime = reader.ModelMonoTime;
            RadarStateMonoTimeDEPRECATED = reader.RadarStateMonoTimeDEPRECATED;
            LaneWidthDEPRECATED = reader.LaneWidthDEPRECATED;
            GpsTrajectoryDEPRECATED = CapnpSerializable.Create<Cereal.LongitudinalPlan.GpsTrajectory>(reader.GpsTrajectoryDEPRECATED);
            EventsDEPRECATED = reader.EventsDEPRECATED?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.CarEvent>(_));
            VTargetFutureDEPRECATED = reader.VTargetFutureDEPRECATED;
            TheLongitudinalPlanSource = reader.TheLongitudinalPlanSource;
            VCruiseDEPRECATED = reader.VCruiseDEPRECATED;
            ACruiseDEPRECATED = reader.ACruiseDEPRECATED;
            ATargetDEPRECATED = reader.ATargetDEPRECATED;
            GpsPlannerActiveDEPRECATED = reader.GpsPlannerActiveDEPRECATED;
            VMaxDEPRECATED = reader.VMaxDEPRECATED;
            VCurvatureDEPRECATED = reader.VCurvatureDEPRECATED;
            DecelForTurnDEPRECATED = reader.DecelForTurnDEPRECATED;
            HasLeftLaneDEPRECATED = reader.HasLeftLaneDEPRECATED;
            HasRightLaneDEPRECATED = reader.HasRightLaneDEPRECATED;
            MapValidDEPRECATED = reader.MapValidDEPRECATED;
            VStartDEPRECATED = reader.VStartDEPRECATED;
            AStartDEPRECATED = reader.AStartDEPRECATED;
            RadarValidDEPRECATED = reader.RadarValidDEPRECATED;
            ProcessingDelay = reader.ProcessingDelay;
            RadarCanErrorDEPRECATED = reader.RadarCanErrorDEPRECATED;
            CommIssueDEPRECATED = reader.CommIssueDEPRECATED;
            Accels = reader.Accels;
            Speeds = reader.Speeds;
            Jerks = reader.Jerks;
            SolverExecutionTime = reader.SolverExecutionTime;
            Personality = reader.Personality;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.LateralValidDEPRECATED = LateralValidDEPRECATED;
            writer.DPolyDEPRECATED.Init(DPolyDEPRECATED);
            writer.LongitudinalValidDEPRECATED = LongitudinalValidDEPRECATED;
            writer.VTargetDEPRECATED = VTargetDEPRECATED;
            writer.ATargetMinDEPRECATED = ATargetMinDEPRECATED;
            writer.ATargetMaxDEPRECATED = ATargetMaxDEPRECATED;
            writer.JerkFactorDEPRECATED = JerkFactorDEPRECATED;
            writer.HasLead = HasLead;
            writer.Fcw = Fcw;
            writer.ModelMonoTime = ModelMonoTime;
            writer.RadarStateMonoTimeDEPRECATED = RadarStateMonoTimeDEPRECATED;
            writer.LaneWidthDEPRECATED = LaneWidthDEPRECATED;
            GpsTrajectoryDEPRECATED?.serialize(writer.GpsTrajectoryDEPRECATED);
            writer.EventsDEPRECATED.Init(EventsDEPRECATED, (_s1, _v1) => _v1?.serialize(_s1));
            writer.VTargetFutureDEPRECATED = VTargetFutureDEPRECATED;
            writer.TheLongitudinalPlanSource = TheLongitudinalPlanSource;
            writer.VCruiseDEPRECATED = VCruiseDEPRECATED;
            writer.ACruiseDEPRECATED = ACruiseDEPRECATED;
            writer.ATargetDEPRECATED = ATargetDEPRECATED;
            writer.GpsPlannerActiveDEPRECATED = GpsPlannerActiveDEPRECATED;
            writer.VMaxDEPRECATED = VMaxDEPRECATED;
            writer.VCurvatureDEPRECATED = VCurvatureDEPRECATED;
            writer.DecelForTurnDEPRECATED = DecelForTurnDEPRECATED;
            writer.HasLeftLaneDEPRECATED = HasLeftLaneDEPRECATED;
            writer.HasRightLaneDEPRECATED = HasRightLaneDEPRECATED;
            writer.MapValidDEPRECATED = MapValidDEPRECATED;
            writer.VStartDEPRECATED = VStartDEPRECATED;
            writer.AStartDEPRECATED = AStartDEPRECATED;
            writer.RadarValidDEPRECATED = RadarValidDEPRECATED;
            writer.ProcessingDelay = ProcessingDelay;
            writer.RadarCanErrorDEPRECATED = RadarCanErrorDEPRECATED;
            writer.CommIssueDEPRECATED = CommIssueDEPRECATED;
            writer.Accels.Init(Accels);
            writer.Speeds.Init(Speeds);
            writer.Jerks.Init(Jerks);
            writer.SolverExecutionTime = SolverExecutionTime;
            writer.Personality = Personality;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public bool LateralValidDEPRECATED
        {
            get;
            set;
        }

        public IReadOnlyList<float> DPolyDEPRECATED
        {
            get;
            set;
        }

        public bool LongitudinalValidDEPRECATED
        {
            get;
            set;
        }

        public float VTargetDEPRECATED
        {
            get;
            set;
        }

        public float ATargetMinDEPRECATED
        {
            get;
            set;
        }

        public float ATargetMaxDEPRECATED
        {
            get;
            set;
        }

        public float JerkFactorDEPRECATED
        {
            get;
            set;
        }

        public bool HasLead
        {
            get;
            set;
        }

        public bool Fcw
        {
            get;
            set;
        }

        public ulong ModelMonoTime
        {
            get;
            set;
        }

        public ulong RadarStateMonoTimeDEPRECATED
        {
            get;
            set;
        }

        public float LaneWidthDEPRECATED
        {
            get;
            set;
        }

        public Cereal.LongitudinalPlan.GpsTrajectory GpsTrajectoryDEPRECATED
        {
            get;
            set;
        }

        public IReadOnlyList<Cereal.CarEvent> EventsDEPRECATED
        {
            get;
            set;
        }

        public float VTargetFutureDEPRECATED
        {
            get;
            set;
        }

        public Cereal.LongitudinalPlan.LongitudinalPlanSource TheLongitudinalPlanSource
        {
            get;
            set;
        }

        public float VCruiseDEPRECATED
        {
            get;
            set;
        }

        public float ACruiseDEPRECATED
        {
            get;
            set;
        }

        public float ATargetDEPRECATED
        {
            get;
            set;
        }

        public bool GpsPlannerActiveDEPRECATED
        {
            get;
            set;
        }

        public float VMaxDEPRECATED
        {
            get;
            set;
        }

        public float VCurvatureDEPRECATED
        {
            get;
            set;
        }

        public bool DecelForTurnDEPRECATED
        {
            get;
            set;
        }

        public bool HasLeftLaneDEPRECATED
        {
            get;
            set;
        }

        public bool HasRightLaneDEPRECATED
        {
            get;
            set;
        }

        public bool MapValidDEPRECATED
        {
            get;
            set;
        }

        public float VStartDEPRECATED
        {
            get;
            set;
        }

        public float AStartDEPRECATED
        {
            get;
            set;
        }

        public bool RadarValidDEPRECATED
        {
            get;
            set;
        }

        public float ProcessingDelay
        {
            get;
            set;
        }

        public bool RadarCanErrorDEPRECATED
        {
            get;
            set;
        }

        public bool CommIssueDEPRECATED
        {
            get;
            set;
        }

        public IReadOnlyList<float> Accels
        {
            get;
            set;
        }

        public IReadOnlyList<float> Speeds
        {
            get;
            set;
        }

        public IReadOnlyList<float> Jerks
        {
            get;
            set;
        }

        public float SolverExecutionTime
        {
            get;
            set;
        }

        public Cereal.LongitudinalPersonality Personality
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public bool LateralValidDEPRECATED => ctx.ReadDataBool(0UL, false);
            public IReadOnlyList<float> DPolyDEPRECATED => ctx.ReadList(0).CastFloat();
            public bool LongitudinalValidDEPRECATED => ctx.ReadDataBool(1UL, false);
            public float VTargetDEPRECATED => ctx.ReadDataFloat(32UL, 0F);
            public float ATargetMinDEPRECATED => ctx.ReadDataFloat(64UL, 0F);
            public float ATargetMaxDEPRECATED => ctx.ReadDataFloat(96UL, 0F);
            public float JerkFactorDEPRECATED => ctx.ReadDataFloat(128UL, 0F);
            public bool HasLead => ctx.ReadDataBool(2UL, false);
            public bool Fcw => ctx.ReadDataBool(3UL, false);
            public ulong ModelMonoTime => ctx.ReadDataULong(192UL, 0UL);
            public ulong RadarStateMonoTimeDEPRECATED => ctx.ReadDataULong(256UL, 0UL);
            public float LaneWidthDEPRECATED => ctx.ReadDataFloat(160UL, 0F);
            public Cereal.LongitudinalPlan.GpsTrajectory.READER GpsTrajectoryDEPRECATED => ctx.ReadStruct(1, Cereal.LongitudinalPlan.GpsTrajectory.READER.create);
            public IReadOnlyList<Cereal.CarEvent.READER> EventsDEPRECATED => ctx.ReadList(2).Cast(Cereal.CarEvent.READER.create);
            public float VTargetFutureDEPRECATED => ctx.ReadDataFloat(320UL, 0F);
            public Cereal.LongitudinalPlan.LongitudinalPlanSource TheLongitudinalPlanSource => (Cereal.LongitudinalPlan.LongitudinalPlanSource)ctx.ReadDataUShort(16UL, (ushort)0);
            public float VCruiseDEPRECATED => ctx.ReadDataFloat(352UL, 0F);
            public float ACruiseDEPRECATED => ctx.ReadDataFloat(384UL, 0F);
            public float ATargetDEPRECATED => ctx.ReadDataFloat(416UL, 0F);
            public bool GpsPlannerActiveDEPRECATED => ctx.ReadDataBool(4UL, false);
            public float VMaxDEPRECATED => ctx.ReadDataFloat(448UL, 0F);
            public float VCurvatureDEPRECATED => ctx.ReadDataFloat(480UL, 0F);
            public bool DecelForTurnDEPRECATED => ctx.ReadDataBool(5UL, false);
            public bool HasLeftLaneDEPRECATED => ctx.ReadDataBool(6UL, false);
            public bool HasRightLaneDEPRECATED => ctx.ReadDataBool(7UL, false);
            public bool MapValidDEPRECATED => ctx.ReadDataBool(8UL, false);
            public float VStartDEPRECATED => ctx.ReadDataFloat(512UL, 0F);
            public float AStartDEPRECATED => ctx.ReadDataFloat(544UL, 0F);
            public bool RadarValidDEPRECATED => ctx.ReadDataBool(9UL, false);
            public float ProcessingDelay => ctx.ReadDataFloat(576UL, 0F);
            public bool RadarCanErrorDEPRECATED => ctx.ReadDataBool(10UL, false);
            public bool CommIssueDEPRECATED => ctx.ReadDataBool(11UL, false);
            public IReadOnlyList<float> Accels => ctx.ReadList(3).CastFloat();
            public IReadOnlyList<float> Speeds => ctx.ReadList(4).CastFloat();
            public IReadOnlyList<float> Jerks => ctx.ReadList(5).CastFloat();
            public float SolverExecutionTime => ctx.ReadDataFloat(608UL, 0F);
            public Cereal.LongitudinalPersonality Personality => (Cereal.LongitudinalPersonality)ctx.ReadDataUShort(640UL, (ushort)0);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(11, 6);
            }

            public bool LateralValidDEPRECATED
            {
                get => this.ReadDataBool(0UL, false);
                set => this.WriteData(0UL, value, false);
            }

            public ListOfPrimitivesSerializer<float> DPolyDEPRECATED
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(0);
                set => Link(0, value);
            }

            public bool LongitudinalValidDEPRECATED
            {
                get => this.ReadDataBool(1UL, false);
                set => this.WriteData(1UL, value, false);
            }

            public float VTargetDEPRECATED
            {
                get => this.ReadDataFloat(32UL, 0F);
                set => this.WriteData(32UL, value, 0F);
            }

            public float ATargetMinDEPRECATED
            {
                get => this.ReadDataFloat(64UL, 0F);
                set => this.WriteData(64UL, value, 0F);
            }

            public float ATargetMaxDEPRECATED
            {
                get => this.ReadDataFloat(96UL, 0F);
                set => this.WriteData(96UL, value, 0F);
            }

            public float JerkFactorDEPRECATED
            {
                get => this.ReadDataFloat(128UL, 0F);
                set => this.WriteData(128UL, value, 0F);
            }

            public bool HasLead
            {
                get => this.ReadDataBool(2UL, false);
                set => this.WriteData(2UL, value, false);
            }

            public bool Fcw
            {
                get => this.ReadDataBool(3UL, false);
                set => this.WriteData(3UL, value, false);
            }

            public ulong ModelMonoTime
            {
                get => this.ReadDataULong(192UL, 0UL);
                set => this.WriteData(192UL, value, 0UL);
            }

            public ulong RadarStateMonoTimeDEPRECATED
            {
                get => this.ReadDataULong(256UL, 0UL);
                set => this.WriteData(256UL, value, 0UL);
            }

            public float LaneWidthDEPRECATED
            {
                get => this.ReadDataFloat(160UL, 0F);
                set => this.WriteData(160UL, value, 0F);
            }

            public Cereal.LongitudinalPlan.GpsTrajectory.WRITER GpsTrajectoryDEPRECATED
            {
                get => BuildPointer<Cereal.LongitudinalPlan.GpsTrajectory.WRITER>(1);
                set => Link(1, value);
            }

            public ListOfStructsSerializer<Cereal.CarEvent.WRITER> EventsDEPRECATED
            {
                get => BuildPointer<ListOfStructsSerializer<Cereal.CarEvent.WRITER>>(2);
                set => Link(2, value);
            }

            public float VTargetFutureDEPRECATED
            {
                get => this.ReadDataFloat(320UL, 0F);
                set => this.WriteData(320UL, value, 0F);
            }

            public Cereal.LongitudinalPlan.LongitudinalPlanSource TheLongitudinalPlanSource
            {
                get => (Cereal.LongitudinalPlan.LongitudinalPlanSource)this.ReadDataUShort(16UL, (ushort)0);
                set => this.WriteData(16UL, (ushort)value, (ushort)0);
            }

            public float VCruiseDEPRECATED
            {
                get => this.ReadDataFloat(352UL, 0F);
                set => this.WriteData(352UL, value, 0F);
            }

            public float ACruiseDEPRECATED
            {
                get => this.ReadDataFloat(384UL, 0F);
                set => this.WriteData(384UL, value, 0F);
            }

            public float ATargetDEPRECATED
            {
                get => this.ReadDataFloat(416UL, 0F);
                set => this.WriteData(416UL, value, 0F);
            }

            public bool GpsPlannerActiveDEPRECATED
            {
                get => this.ReadDataBool(4UL, false);
                set => this.WriteData(4UL, value, false);
            }

            public float VMaxDEPRECATED
            {
                get => this.ReadDataFloat(448UL, 0F);
                set => this.WriteData(448UL, value, 0F);
            }

            public float VCurvatureDEPRECATED
            {
                get => this.ReadDataFloat(480UL, 0F);
                set => this.WriteData(480UL, value, 0F);
            }

            public bool DecelForTurnDEPRECATED
            {
                get => this.ReadDataBool(5UL, false);
                set => this.WriteData(5UL, value, false);
            }

            public bool HasLeftLaneDEPRECATED
            {
                get => this.ReadDataBool(6UL, false);
                set => this.WriteData(6UL, value, false);
            }

            public bool HasRightLaneDEPRECATED
            {
                get => this.ReadDataBool(7UL, false);
                set => this.WriteData(7UL, value, false);
            }

            public bool MapValidDEPRECATED
            {
                get => this.ReadDataBool(8UL, false);
                set => this.WriteData(8UL, value, false);
            }

            public float VStartDEPRECATED
            {
                get => this.ReadDataFloat(512UL, 0F);
                set => this.WriteData(512UL, value, 0F);
            }

            public float AStartDEPRECATED
            {
                get => this.ReadDataFloat(544UL, 0F);
                set => this.WriteData(544UL, value, 0F);
            }

            public bool RadarValidDEPRECATED
            {
                get => this.ReadDataBool(9UL, false);
                set => this.WriteData(9UL, value, false);
            }

            public float ProcessingDelay
            {
                get => this.ReadDataFloat(576UL, 0F);
                set => this.WriteData(576UL, value, 0F);
            }

            public bool RadarCanErrorDEPRECATED
            {
                get => this.ReadDataBool(10UL, false);
                set => this.WriteData(10UL, value, false);
            }

            public bool CommIssueDEPRECATED
            {
                get => this.ReadDataBool(11UL, false);
                set => this.WriteData(11UL, value, false);
            }

            public ListOfPrimitivesSerializer<float> Accels
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(3);
                set => Link(3, value);
            }

            public ListOfPrimitivesSerializer<float> Speeds
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(4);
                set => Link(4, value);
            }

            public ListOfPrimitivesSerializer<float> Jerks
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(5);
                set => Link(5, value);
            }

            public float SolverExecutionTime
            {
                get => this.ReadDataFloat(608UL, 0F);
                set => this.WriteData(608UL, value, 0F);
            }

            public Cereal.LongitudinalPersonality Personality
            {
                get => (Cereal.LongitudinalPersonality)this.ReadDataUShort(640UL, (ushort)0);
                set => this.WriteData(640UL, (ushort)value, (ushort)0);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xb231a753cc079120UL)]
        public enum LongitudinalPlanSource : ushort
        {
            cruise,
            lead0,
            lead1,
            lead2,
            e2e
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x8cfeb072f5301000UL)]
        public class GpsTrajectory : ICapnpSerializable
        {
            public const UInt64 typeId = 0x8cfeb072f5301000UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                X = reader.X;
                Y = reader.Y;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.X.Init(X);
                writer.Y.Init(Y);
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public IReadOnlyList<float> X
            {
                get;
                set;
            }

            public IReadOnlyList<float> Y
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public IReadOnlyList<float> X => ctx.ReadList(0).CastFloat();
                public IReadOnlyList<float> Y => ctx.ReadList(1).CastFloat();
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 2);
                }

                public ListOfPrimitivesSerializer<float> X
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(0);
                    set => Link(0, value);
                }

                public ListOfPrimitivesSerializer<float> Y
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(1);
                    set => Link(1, value);
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xfc0c9bb05e3927c1UL)]
    public class UiPlan : ICapnpSerializable
    {
        public const UInt64 typeId = 0xfc0c9bb05e3927c1UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            Position = CapnpSerializable.Create<Cereal.XYZTData>(reader.Position);
            Accel = reader.Accel;
            FrameId = reader.FrameId;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            Position?.serialize(writer.Position);
            writer.Accel.Init(Accel);
            writer.FrameId = FrameId;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public Cereal.XYZTData Position
        {
            get;
            set;
        }

        public IReadOnlyList<float> Accel
        {
            get;
            set;
        }

        public uint FrameId
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public Cereal.XYZTData.READER Position => ctx.ReadStruct(0, Cereal.XYZTData.READER.create);
            public IReadOnlyList<float> Accel => ctx.ReadList(1).CastFloat();
            public uint FrameId => ctx.ReadDataUInt(0UL, 0U);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(1, 2);
            }

            public Cereal.XYZTData.WRITER Position
            {
                get => BuildPointer<Cereal.XYZTData.WRITER>(0);
                set => Link(0, value);
            }

            public ListOfPrimitivesSerializer<float> Accel
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(1);
                set => Link(1, value);
            }

            public uint FrameId
            {
                get => this.ReadDataUInt(0UL, 0U);
                set => this.WriteData(0UL, value, 0U);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xe1e9318e2ae8b51eUL)]
    public class LateralPlan : ICapnpSerializable
    {
        public const UInt64 typeId = 0xe1e9318e2ae8b51eUL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            LaneWidthDEPRECATED = reader.LaneWidthDEPRECATED;
            DPolyDEPRECATED = reader.DPolyDEPRECATED;
            CPolyDEPRECATED = reader.CPolyDEPRECATED;
            CProbDEPRECATED = reader.CProbDEPRECATED;
            LPolyDEPRECATED = reader.LPolyDEPRECATED;
            LProbDEPRECATED = reader.LProbDEPRECATED;
            RPolyDEPRECATED = reader.RPolyDEPRECATED;
            RProbDEPRECATED = reader.RProbDEPRECATED;
            SteeringAngleDegDEPRECATED = reader.SteeringAngleDegDEPRECATED;
            MpcSolutionValid = reader.MpcSolutionValid;
            ParamsValidDEPRECATED = reader.ParamsValidDEPRECATED;
            AngleOffsetDegDEPRECATED = reader.AngleOffsetDegDEPRECATED;
            ModelValidDEPRECATED = reader.ModelValidDEPRECATED;
            SteeringRateDegDEPRECATED = reader.SteeringRateDegDEPRECATED;
            SensorValidDEPRECATED = reader.SensorValidDEPRECATED;
            CommIssueDEPRECATED = reader.CommIssueDEPRECATED;
            PosenetValidDEPRECATED = reader.PosenetValidDEPRECATED;
            TheDesire = reader.TheDesire;
            TheLaneChangeState = reader.TheLaneChangeState;
            TheLaneChangeDirection = reader.TheLaneChangeDirection;
            DPathPoints = reader.DPathPoints;
            DProbDEPRECATED = reader.DProbDEPRECATED;
            CurvatureDEPRECATED = reader.CurvatureDEPRECATED;
            CurvatureRateDEPRECATED = reader.CurvatureRateDEPRECATED;
            RawCurvatureDEPRECATED = reader.RawCurvatureDEPRECATED;
            RawCurvatureRateDEPRECATED = reader.RawCurvatureRateDEPRECATED;
            Psis = reader.Psis;
            Curvatures = reader.Curvatures;
            CurvatureRates = reader.CurvatureRates;
            UseLaneLines = reader.UseLaneLines;
            SolverExecutionTime = reader.SolverExecutionTime;
            ModelMonoTime = reader.ModelMonoTime;
            SolverCost = reader.SolverCost;
            TheSolverState = CapnpSerializable.Create<Cereal.LateralPlan.SolverState>(reader.TheSolverState);
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.LaneWidthDEPRECATED = LaneWidthDEPRECATED;
            writer.DPolyDEPRECATED.Init(DPolyDEPRECATED);
            writer.CPolyDEPRECATED.Init(CPolyDEPRECATED);
            writer.CProbDEPRECATED = CProbDEPRECATED;
            writer.LPolyDEPRECATED.Init(LPolyDEPRECATED);
            writer.LProbDEPRECATED = LProbDEPRECATED;
            writer.RPolyDEPRECATED.Init(RPolyDEPRECATED);
            writer.RProbDEPRECATED = RProbDEPRECATED;
            writer.SteeringAngleDegDEPRECATED = SteeringAngleDegDEPRECATED;
            writer.MpcSolutionValid = MpcSolutionValid;
            writer.ParamsValidDEPRECATED = ParamsValidDEPRECATED;
            writer.AngleOffsetDegDEPRECATED = AngleOffsetDegDEPRECATED;
            writer.ModelValidDEPRECATED = ModelValidDEPRECATED;
            writer.SteeringRateDegDEPRECATED = SteeringRateDegDEPRECATED;
            writer.SensorValidDEPRECATED = SensorValidDEPRECATED;
            writer.CommIssueDEPRECATED = CommIssueDEPRECATED;
            writer.PosenetValidDEPRECATED = PosenetValidDEPRECATED;
            writer.TheDesire = TheDesire;
            writer.TheLaneChangeState = TheLaneChangeState;
            writer.TheLaneChangeDirection = TheLaneChangeDirection;
            writer.DPathPoints.Init(DPathPoints);
            writer.DProbDEPRECATED = DProbDEPRECATED;
            writer.CurvatureDEPRECATED = CurvatureDEPRECATED;
            writer.CurvatureRateDEPRECATED = CurvatureRateDEPRECATED;
            writer.RawCurvatureDEPRECATED = RawCurvatureDEPRECATED;
            writer.RawCurvatureRateDEPRECATED = RawCurvatureRateDEPRECATED;
            writer.Psis.Init(Psis);
            writer.Curvatures.Init(Curvatures);
            writer.CurvatureRates.Init(CurvatureRates);
            writer.UseLaneLines = UseLaneLines;
            writer.SolverExecutionTime = SolverExecutionTime;
            writer.ModelMonoTime = ModelMonoTime;
            writer.SolverCost = SolverCost;
            TheSolverState?.serialize(writer.TheSolverState);
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public float LaneWidthDEPRECATED
        {
            get;
            set;
        }

        public IReadOnlyList<float> DPolyDEPRECATED
        {
            get;
            set;
        }

        public IReadOnlyList<float> CPolyDEPRECATED
        {
            get;
            set;
        }

        public float CProbDEPRECATED
        {
            get;
            set;
        }

        public IReadOnlyList<float> LPolyDEPRECATED
        {
            get;
            set;
        }

        public float LProbDEPRECATED
        {
            get;
            set;
        }

        public IReadOnlyList<float> RPolyDEPRECATED
        {
            get;
            set;
        }

        public float RProbDEPRECATED
        {
            get;
            set;
        }

        public float SteeringAngleDegDEPRECATED
        {
            get;
            set;
        }

        public bool MpcSolutionValid
        {
            get;
            set;
        }

        public bool ParamsValidDEPRECATED
        {
            get;
            set;
        }

        public float AngleOffsetDegDEPRECATED
        {
            get;
            set;
        }

        public bool ModelValidDEPRECATED
        {
            get;
            set;
        }

        public float SteeringRateDegDEPRECATED
        {
            get;
            set;
        }

        public bool SensorValidDEPRECATED
        {
            get;
            set;
        }

        public bool CommIssueDEPRECATED
        {
            get;
            set;
        }

        public bool PosenetValidDEPRECATED
        {
            get;
            set;
        }

        public Cereal.LateralPlan.Desire TheDesire
        {
            get;
            set;
        }

        public Cereal.LateralPlan.LaneChangeState TheLaneChangeState
        {
            get;
            set;
        }

        public Cereal.LateralPlan.LaneChangeDirection TheLaneChangeDirection
        {
            get;
            set;
        }

        public IReadOnlyList<float> DPathPoints
        {
            get;
            set;
        }

        public float DProbDEPRECATED
        {
            get;
            set;
        }

        public float CurvatureDEPRECATED
        {
            get;
            set;
        }

        public float CurvatureRateDEPRECATED
        {
            get;
            set;
        }

        public float RawCurvatureDEPRECATED
        {
            get;
            set;
        }

        public float RawCurvatureRateDEPRECATED
        {
            get;
            set;
        }

        public IReadOnlyList<float> Psis
        {
            get;
            set;
        }

        public IReadOnlyList<float> Curvatures
        {
            get;
            set;
        }

        public IReadOnlyList<float> CurvatureRates
        {
            get;
            set;
        }

        public bool UseLaneLines
        {
            get;
            set;
        }

        public float SolverExecutionTime
        {
            get;
            set;
        }

        public ulong ModelMonoTime
        {
            get;
            set;
        }

        public float SolverCost
        {
            get;
            set;
        }

        public Cereal.LateralPlan.SolverState TheSolverState
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public float LaneWidthDEPRECATED => ctx.ReadDataFloat(0UL, 0F);
            public IReadOnlyList<float> DPolyDEPRECATED => ctx.ReadList(0).CastFloat();
            public IReadOnlyList<float> CPolyDEPRECATED => ctx.ReadList(1).CastFloat();
            public float CProbDEPRECATED => ctx.ReadDataFloat(32UL, 0F);
            public IReadOnlyList<float> LPolyDEPRECATED => ctx.ReadList(2).CastFloat();
            public float LProbDEPRECATED => ctx.ReadDataFloat(64UL, 0F);
            public IReadOnlyList<float> RPolyDEPRECATED => ctx.ReadList(3).CastFloat();
            public float RProbDEPRECATED => ctx.ReadDataFloat(96UL, 0F);
            public float SteeringAngleDegDEPRECATED => ctx.ReadDataFloat(128UL, 0F);
            public bool MpcSolutionValid => ctx.ReadDataBool(160UL, false);
            public bool ParamsValidDEPRECATED => ctx.ReadDataBool(161UL, false);
            public float AngleOffsetDegDEPRECATED => ctx.ReadDataFloat(192UL, 0F);
            public bool ModelValidDEPRECATED => ctx.ReadDataBool(162UL, false);
            public float SteeringRateDegDEPRECATED => ctx.ReadDataFloat(224UL, 0F);
            public bool SensorValidDEPRECATED => ctx.ReadDataBool(163UL, false);
            public bool CommIssueDEPRECATED => ctx.ReadDataBool(164UL, false);
            public bool PosenetValidDEPRECATED => ctx.ReadDataBool(165UL, false);
            public Cereal.LateralPlan.Desire TheDesire => (Cereal.LateralPlan.Desire)ctx.ReadDataUShort(176UL, (ushort)0);
            public Cereal.LateralPlan.LaneChangeState TheLaneChangeState => (Cereal.LateralPlan.LaneChangeState)ctx.ReadDataUShort(256UL, (ushort)0);
            public Cereal.LateralPlan.LaneChangeDirection TheLaneChangeDirection => (Cereal.LateralPlan.LaneChangeDirection)ctx.ReadDataUShort(272UL, (ushort)0);
            public IReadOnlyList<float> DPathPoints => ctx.ReadList(4).CastFloat();
            public float DProbDEPRECATED => ctx.ReadDataFloat(288UL, 0F);
            public float CurvatureDEPRECATED => ctx.ReadDataFloat(320UL, 0F);
            public float CurvatureRateDEPRECATED => ctx.ReadDataFloat(352UL, 0F);
            public float RawCurvatureDEPRECATED => ctx.ReadDataFloat(384UL, 0F);
            public float RawCurvatureRateDEPRECATED => ctx.ReadDataFloat(416UL, 0F);
            public IReadOnlyList<float> Psis => ctx.ReadList(5).CastFloat();
            public IReadOnlyList<float> Curvatures => ctx.ReadList(6).CastFloat();
            public IReadOnlyList<float> CurvatureRates => ctx.ReadList(7).CastFloat();
            public bool UseLaneLines => ctx.ReadDataBool(166UL, false);
            public float SolverExecutionTime => ctx.ReadDataFloat(448UL, 0F);
            public ulong ModelMonoTime => ctx.ReadDataULong(512UL, 0UL);
            public float SolverCost => ctx.ReadDataFloat(480UL, 0F);
            public Cereal.LateralPlan.SolverState.READER TheSolverState => ctx.ReadStruct(8, Cereal.LateralPlan.SolverState.READER.create);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(9, 9);
            }

            public float LaneWidthDEPRECATED
            {
                get => this.ReadDataFloat(0UL, 0F);
                set => this.WriteData(0UL, value, 0F);
            }

            public ListOfPrimitivesSerializer<float> DPolyDEPRECATED
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(0);
                set => Link(0, value);
            }

            public ListOfPrimitivesSerializer<float> CPolyDEPRECATED
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(1);
                set => Link(1, value);
            }

            public float CProbDEPRECATED
            {
                get => this.ReadDataFloat(32UL, 0F);
                set => this.WriteData(32UL, value, 0F);
            }

            public ListOfPrimitivesSerializer<float> LPolyDEPRECATED
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(2);
                set => Link(2, value);
            }

            public float LProbDEPRECATED
            {
                get => this.ReadDataFloat(64UL, 0F);
                set => this.WriteData(64UL, value, 0F);
            }

            public ListOfPrimitivesSerializer<float> RPolyDEPRECATED
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(3);
                set => Link(3, value);
            }

            public float RProbDEPRECATED
            {
                get => this.ReadDataFloat(96UL, 0F);
                set => this.WriteData(96UL, value, 0F);
            }

            public float SteeringAngleDegDEPRECATED
            {
                get => this.ReadDataFloat(128UL, 0F);
                set => this.WriteData(128UL, value, 0F);
            }

            public bool MpcSolutionValid
            {
                get => this.ReadDataBool(160UL, false);
                set => this.WriteData(160UL, value, false);
            }

            public bool ParamsValidDEPRECATED
            {
                get => this.ReadDataBool(161UL, false);
                set => this.WriteData(161UL, value, false);
            }

            public float AngleOffsetDegDEPRECATED
            {
                get => this.ReadDataFloat(192UL, 0F);
                set => this.WriteData(192UL, value, 0F);
            }

            public bool ModelValidDEPRECATED
            {
                get => this.ReadDataBool(162UL, false);
                set => this.WriteData(162UL, value, false);
            }

            public float SteeringRateDegDEPRECATED
            {
                get => this.ReadDataFloat(224UL, 0F);
                set => this.WriteData(224UL, value, 0F);
            }

            public bool SensorValidDEPRECATED
            {
                get => this.ReadDataBool(163UL, false);
                set => this.WriteData(163UL, value, false);
            }

            public bool CommIssueDEPRECATED
            {
                get => this.ReadDataBool(164UL, false);
                set => this.WriteData(164UL, value, false);
            }

            public bool PosenetValidDEPRECATED
            {
                get => this.ReadDataBool(165UL, false);
                set => this.WriteData(165UL, value, false);
            }

            public Cereal.LateralPlan.Desire TheDesire
            {
                get => (Cereal.LateralPlan.Desire)this.ReadDataUShort(176UL, (ushort)0);
                set => this.WriteData(176UL, (ushort)value, (ushort)0);
            }

            public Cereal.LateralPlan.LaneChangeState TheLaneChangeState
            {
                get => (Cereal.LateralPlan.LaneChangeState)this.ReadDataUShort(256UL, (ushort)0);
                set => this.WriteData(256UL, (ushort)value, (ushort)0);
            }

            public Cereal.LateralPlan.LaneChangeDirection TheLaneChangeDirection
            {
                get => (Cereal.LateralPlan.LaneChangeDirection)this.ReadDataUShort(272UL, (ushort)0);
                set => this.WriteData(272UL, (ushort)value, (ushort)0);
            }

            public ListOfPrimitivesSerializer<float> DPathPoints
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(4);
                set => Link(4, value);
            }

            public float DProbDEPRECATED
            {
                get => this.ReadDataFloat(288UL, 0F);
                set => this.WriteData(288UL, value, 0F);
            }

            public float CurvatureDEPRECATED
            {
                get => this.ReadDataFloat(320UL, 0F);
                set => this.WriteData(320UL, value, 0F);
            }

            public float CurvatureRateDEPRECATED
            {
                get => this.ReadDataFloat(352UL, 0F);
                set => this.WriteData(352UL, value, 0F);
            }

            public float RawCurvatureDEPRECATED
            {
                get => this.ReadDataFloat(384UL, 0F);
                set => this.WriteData(384UL, value, 0F);
            }

            public float RawCurvatureRateDEPRECATED
            {
                get => this.ReadDataFloat(416UL, 0F);
                set => this.WriteData(416UL, value, 0F);
            }

            public ListOfPrimitivesSerializer<float> Psis
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(5);
                set => Link(5, value);
            }

            public ListOfPrimitivesSerializer<float> Curvatures
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(6);
                set => Link(6, value);
            }

            public ListOfPrimitivesSerializer<float> CurvatureRates
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(7);
                set => Link(7, value);
            }

            public bool UseLaneLines
            {
                get => this.ReadDataBool(166UL, false);
                set => this.WriteData(166UL, value, false);
            }

            public float SolverExecutionTime
            {
                get => this.ReadDataFloat(448UL, 0F);
                set => this.WriteData(448UL, value, 0F);
            }

            public ulong ModelMonoTime
            {
                get => this.ReadDataULong(512UL, 0UL);
                set => this.WriteData(512UL, value, 0UL);
            }

            public float SolverCost
            {
                get => this.ReadDataFloat(480UL, 0F);
                set => this.WriteData(480UL, value, 0F);
            }

            public Cereal.LateralPlan.SolverState.WRITER TheSolverState
            {
                get => BuildPointer<Cereal.LateralPlan.SolverState.WRITER>(8);
                set => Link(8, value);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xfdca7c675b7021c6UL)]
        public class SolverState : ICapnpSerializable
        {
            public const UInt64 typeId = 0xfdca7c675b7021c6UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                X = reader.X;
                U = reader.U;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.X.Init(X, (_s2, _v2) => _s2.Init(_v2));
                writer.U.Init(U);
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public IReadOnlyList<IReadOnlyList<float>> X
            {
                get;
                set;
            }

            public IReadOnlyList<float> U
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public IReadOnlyList<IReadOnlyList<float>> X => ctx.ReadList(0).Cast(_0 => _0.RequireList().CastFloat());
                public IReadOnlyList<float> U => ctx.ReadList(1).CastFloat();
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 2);
                }

                public ListOfPointersSerializer<ListOfPrimitivesSerializer<float>> X
                {
                    get => BuildPointer<ListOfPointersSerializer<ListOfPrimitivesSerializer<float>>>(0);
                    set => Link(0, value);
                }

                public ListOfPrimitivesSerializer<float> U
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(1);
                    set => Link(1, value);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xbb53ef3fcf2a7f0dUL)]
        public enum Desire : ushort
        {
            none,
            turnLeft,
            turnRight,
            laneChangeLeft,
            laneChangeRight,
            keepLeft,
            keepRight
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xfac297f195ce56d2UL)]
        public enum LaneChangeState : ushort
        {
            off,
            preLaneChange,
            laneChangeStarting,
            laneChangeFinishing
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xf7396311bcbad303UL)]
        public enum LaneChangeDirection : ushort
        {
            none,
            left,
            right
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xebc5703d1ee7c129UL)]
    public class LiveLocationKalman : ICapnpSerializable
    {
        public const UInt64 typeId = 0xebc5703d1ee7c129UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            PositionECEF = CapnpSerializable.Create<Cereal.LiveLocationKalman.Measurement>(reader.PositionECEF);
            PositionGeodetic = CapnpSerializable.Create<Cereal.LiveLocationKalman.Measurement>(reader.PositionGeodetic);
            VelocityECEF = CapnpSerializable.Create<Cereal.LiveLocationKalman.Measurement>(reader.VelocityECEF);
            VelocityNED = CapnpSerializable.Create<Cereal.LiveLocationKalman.Measurement>(reader.VelocityNED);
            VelocityDevice = CapnpSerializable.Create<Cereal.LiveLocationKalman.Measurement>(reader.VelocityDevice);
            AccelerationDevice = CapnpSerializable.Create<Cereal.LiveLocationKalman.Measurement>(reader.AccelerationDevice);
            OrientationECEF = CapnpSerializable.Create<Cereal.LiveLocationKalman.Measurement>(reader.OrientationECEF);
            OrientationNED = CapnpSerializable.Create<Cereal.LiveLocationKalman.Measurement>(reader.OrientationNED);
            AngularVelocityDevice = CapnpSerializable.Create<Cereal.LiveLocationKalman.Measurement>(reader.AngularVelocityDevice);
            CalibratedOrientationNED = CapnpSerializable.Create<Cereal.LiveLocationKalman.Measurement>(reader.CalibratedOrientationNED);
            VelocityCalibrated = CapnpSerializable.Create<Cereal.LiveLocationKalman.Measurement>(reader.VelocityCalibrated);
            AccelerationCalibrated = CapnpSerializable.Create<Cereal.LiveLocationKalman.Measurement>(reader.AccelerationCalibrated);
            AngularVelocityCalibrated = CapnpSerializable.Create<Cereal.LiveLocationKalman.Measurement>(reader.AngularVelocityCalibrated);
            GpsWeek = reader.GpsWeek;
            GpsTimeOfWeek = reader.GpsTimeOfWeek;
            TheStatus = reader.TheStatus;
            UnixTimestampMillis = reader.UnixTimestampMillis;
            InputsOK = reader.InputsOK;
            PosenetOK = reader.PosenetOK;
            GpsOK = reader.GpsOK;
            CalibratedOrientationECEF = CapnpSerializable.Create<Cereal.LiveLocationKalman.Measurement>(reader.CalibratedOrientationECEF);
            SensorsOK = reader.SensorsOK;
            DeviceStable = reader.DeviceStable;
            TimeSinceReset = reader.TimeSinceReset;
            ExcessiveResets = reader.ExcessiveResets;
            TimeToFirstFix = reader.TimeToFirstFix;
            FilterState = CapnpSerializable.Create<Cereal.LiveLocationKalman.Measurement>(reader.FilterState);
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            PositionECEF?.serialize(writer.PositionECEF);
            PositionGeodetic?.serialize(writer.PositionGeodetic);
            VelocityECEF?.serialize(writer.VelocityECEF);
            VelocityNED?.serialize(writer.VelocityNED);
            VelocityDevice?.serialize(writer.VelocityDevice);
            AccelerationDevice?.serialize(writer.AccelerationDevice);
            OrientationECEF?.serialize(writer.OrientationECEF);
            OrientationNED?.serialize(writer.OrientationNED);
            AngularVelocityDevice?.serialize(writer.AngularVelocityDevice);
            CalibratedOrientationNED?.serialize(writer.CalibratedOrientationNED);
            VelocityCalibrated?.serialize(writer.VelocityCalibrated);
            AccelerationCalibrated?.serialize(writer.AccelerationCalibrated);
            AngularVelocityCalibrated?.serialize(writer.AngularVelocityCalibrated);
            writer.GpsWeek = GpsWeek;
            writer.GpsTimeOfWeek = GpsTimeOfWeek;
            writer.TheStatus = TheStatus;
            writer.UnixTimestampMillis = UnixTimestampMillis;
            writer.InputsOK = InputsOK;
            writer.PosenetOK = PosenetOK;
            writer.GpsOK = GpsOK;
            CalibratedOrientationECEF?.serialize(writer.CalibratedOrientationECEF);
            writer.SensorsOK = SensorsOK;
            writer.DeviceStable = DeviceStable;
            writer.TimeSinceReset = TimeSinceReset;
            writer.ExcessiveResets = ExcessiveResets;
            writer.TimeToFirstFix = TimeToFirstFix;
            FilterState?.serialize(writer.FilterState);
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public Cereal.LiveLocationKalman.Measurement PositionECEF
        {
            get;
            set;
        }

        public Cereal.LiveLocationKalman.Measurement PositionGeodetic
        {
            get;
            set;
        }

        public Cereal.LiveLocationKalman.Measurement VelocityECEF
        {
            get;
            set;
        }

        public Cereal.LiveLocationKalman.Measurement VelocityNED
        {
            get;
            set;
        }

        public Cereal.LiveLocationKalman.Measurement VelocityDevice
        {
            get;
            set;
        }

        public Cereal.LiveLocationKalman.Measurement AccelerationDevice
        {
            get;
            set;
        }

        public Cereal.LiveLocationKalman.Measurement OrientationECEF
        {
            get;
            set;
        }

        public Cereal.LiveLocationKalman.Measurement OrientationNED
        {
            get;
            set;
        }

        public Cereal.LiveLocationKalman.Measurement AngularVelocityDevice
        {
            get;
            set;
        }

        public Cereal.LiveLocationKalman.Measurement CalibratedOrientationNED
        {
            get;
            set;
        }

        public Cereal.LiveLocationKalman.Measurement VelocityCalibrated
        {
            get;
            set;
        }

        public Cereal.LiveLocationKalman.Measurement AccelerationCalibrated
        {
            get;
            set;
        }

        public Cereal.LiveLocationKalman.Measurement AngularVelocityCalibrated
        {
            get;
            set;
        }

        public int GpsWeek
        {
            get;
            set;
        }

        public double GpsTimeOfWeek
        {
            get;
            set;
        }

        public Cereal.LiveLocationKalman.Status TheStatus
        {
            get;
            set;
        }

        public long UnixTimestampMillis
        {
            get;
            set;
        }

        public bool InputsOK
        {
            get;
            set;
        }

        = true;
        public bool PosenetOK
        {
            get;
            set;
        }

        = true;
        public bool GpsOK
        {
            get;
            set;
        }

        = true;
        public Cereal.LiveLocationKalman.Measurement CalibratedOrientationECEF
        {
            get;
            set;
        }

        public bool SensorsOK
        {
            get;
            set;
        }

        = true;
        public bool DeviceStable
        {
            get;
            set;
        }

        = true;
        public double TimeSinceReset
        {
            get;
            set;
        }

        public bool ExcessiveResets
        {
            get;
            set;
        }

        public float TimeToFirstFix
        {
            get;
            set;
        }

        public Cereal.LiveLocationKalman.Measurement FilterState
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public Cereal.LiveLocationKalman.Measurement.READER PositionECEF => ctx.ReadStruct(0, Cereal.LiveLocationKalman.Measurement.READER.create);
            public Cereal.LiveLocationKalman.Measurement.READER PositionGeodetic => ctx.ReadStruct(1, Cereal.LiveLocationKalman.Measurement.READER.create);
            public Cereal.LiveLocationKalman.Measurement.READER VelocityECEF => ctx.ReadStruct(2, Cereal.LiveLocationKalman.Measurement.READER.create);
            public Cereal.LiveLocationKalman.Measurement.READER VelocityNED => ctx.ReadStruct(3, Cereal.LiveLocationKalman.Measurement.READER.create);
            public Cereal.LiveLocationKalman.Measurement.READER VelocityDevice => ctx.ReadStruct(4, Cereal.LiveLocationKalman.Measurement.READER.create);
            public Cereal.LiveLocationKalman.Measurement.READER AccelerationDevice => ctx.ReadStruct(5, Cereal.LiveLocationKalman.Measurement.READER.create);
            public Cereal.LiveLocationKalman.Measurement.READER OrientationECEF => ctx.ReadStruct(6, Cereal.LiveLocationKalman.Measurement.READER.create);
            public Cereal.LiveLocationKalman.Measurement.READER OrientationNED => ctx.ReadStruct(7, Cereal.LiveLocationKalman.Measurement.READER.create);
            public Cereal.LiveLocationKalman.Measurement.READER AngularVelocityDevice => ctx.ReadStruct(8, Cereal.LiveLocationKalman.Measurement.READER.create);
            public Cereal.LiveLocationKalman.Measurement.READER CalibratedOrientationNED => ctx.ReadStruct(9, Cereal.LiveLocationKalman.Measurement.READER.create);
            public Cereal.LiveLocationKalman.Measurement.READER VelocityCalibrated => ctx.ReadStruct(10, Cereal.LiveLocationKalman.Measurement.READER.create);
            public Cereal.LiveLocationKalman.Measurement.READER AccelerationCalibrated => ctx.ReadStruct(11, Cereal.LiveLocationKalman.Measurement.READER.create);
            public Cereal.LiveLocationKalman.Measurement.READER AngularVelocityCalibrated => ctx.ReadStruct(12, Cereal.LiveLocationKalman.Measurement.READER.create);
            public int GpsWeek => ctx.ReadDataInt(0UL, 0);
            public double GpsTimeOfWeek => ctx.ReadDataDouble(64UL, 0);
            public Cereal.LiveLocationKalman.Status TheStatus => (Cereal.LiveLocationKalman.Status)ctx.ReadDataUShort(32UL, (ushort)0);
            public long UnixTimestampMillis => ctx.ReadDataLong(128UL, 0L);
            public bool InputsOK => ctx.ReadDataBool(48UL, true);
            public bool PosenetOK => ctx.ReadDataBool(49UL, true);
            public bool GpsOK => ctx.ReadDataBool(50UL, true);
            public Cereal.LiveLocationKalman.Measurement.READER CalibratedOrientationECEF => ctx.ReadStruct(13, Cereal.LiveLocationKalman.Measurement.READER.create);
            public bool SensorsOK => ctx.ReadDataBool(51UL, true);
            public bool DeviceStable => ctx.ReadDataBool(52UL, true);
            public double TimeSinceReset => ctx.ReadDataDouble(192UL, 0);
            public bool ExcessiveResets => ctx.ReadDataBool(53UL, false);
            public float TimeToFirstFix => ctx.ReadDataFloat(256UL, 0F);
            public Cereal.LiveLocationKalman.Measurement.READER FilterState => ctx.ReadStruct(14, Cereal.LiveLocationKalman.Measurement.READER.create);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(5, 15);
            }

            public Cereal.LiveLocationKalman.Measurement.WRITER PositionECEF
            {
                get => BuildPointer<Cereal.LiveLocationKalman.Measurement.WRITER>(0);
                set => Link(0, value);
            }

            public Cereal.LiveLocationKalman.Measurement.WRITER PositionGeodetic
            {
                get => BuildPointer<Cereal.LiveLocationKalman.Measurement.WRITER>(1);
                set => Link(1, value);
            }

            public Cereal.LiveLocationKalman.Measurement.WRITER VelocityECEF
            {
                get => BuildPointer<Cereal.LiveLocationKalman.Measurement.WRITER>(2);
                set => Link(2, value);
            }

            public Cereal.LiveLocationKalman.Measurement.WRITER VelocityNED
            {
                get => BuildPointer<Cereal.LiveLocationKalman.Measurement.WRITER>(3);
                set => Link(3, value);
            }

            public Cereal.LiveLocationKalman.Measurement.WRITER VelocityDevice
            {
                get => BuildPointer<Cereal.LiveLocationKalman.Measurement.WRITER>(4);
                set => Link(4, value);
            }

            public Cereal.LiveLocationKalman.Measurement.WRITER AccelerationDevice
            {
                get => BuildPointer<Cereal.LiveLocationKalman.Measurement.WRITER>(5);
                set => Link(5, value);
            }

            public Cereal.LiveLocationKalman.Measurement.WRITER OrientationECEF
            {
                get => BuildPointer<Cereal.LiveLocationKalman.Measurement.WRITER>(6);
                set => Link(6, value);
            }

            public Cereal.LiveLocationKalman.Measurement.WRITER OrientationNED
            {
                get => BuildPointer<Cereal.LiveLocationKalman.Measurement.WRITER>(7);
                set => Link(7, value);
            }

            public Cereal.LiveLocationKalman.Measurement.WRITER AngularVelocityDevice
            {
                get => BuildPointer<Cereal.LiveLocationKalman.Measurement.WRITER>(8);
                set => Link(8, value);
            }

            public Cereal.LiveLocationKalman.Measurement.WRITER CalibratedOrientationNED
            {
                get => BuildPointer<Cereal.LiveLocationKalman.Measurement.WRITER>(9);
                set => Link(9, value);
            }

            public Cereal.LiveLocationKalman.Measurement.WRITER VelocityCalibrated
            {
                get => BuildPointer<Cereal.LiveLocationKalman.Measurement.WRITER>(10);
                set => Link(10, value);
            }

            public Cereal.LiveLocationKalman.Measurement.WRITER AccelerationCalibrated
            {
                get => BuildPointer<Cereal.LiveLocationKalman.Measurement.WRITER>(11);
                set => Link(11, value);
            }

            public Cereal.LiveLocationKalman.Measurement.WRITER AngularVelocityCalibrated
            {
                get => BuildPointer<Cereal.LiveLocationKalman.Measurement.WRITER>(12);
                set => Link(12, value);
            }

            public int GpsWeek
            {
                get => this.ReadDataInt(0UL, 0);
                set => this.WriteData(0UL, value, 0);
            }

            public double GpsTimeOfWeek
            {
                get => this.ReadDataDouble(64UL, 0);
                set => this.WriteData(64UL, value, 0);
            }

            public Cereal.LiveLocationKalman.Status TheStatus
            {
                get => (Cereal.LiveLocationKalman.Status)this.ReadDataUShort(32UL, (ushort)0);
                set => this.WriteData(32UL, (ushort)value, (ushort)0);
            }

            public long UnixTimestampMillis
            {
                get => this.ReadDataLong(128UL, 0L);
                set => this.WriteData(128UL, value, 0L);
            }

            public bool InputsOK
            {
                get => this.ReadDataBool(48UL, true);
                set => this.WriteData(48UL, value, true);
            }

            public bool PosenetOK
            {
                get => this.ReadDataBool(49UL, true);
                set => this.WriteData(49UL, value, true);
            }

            public bool GpsOK
            {
                get => this.ReadDataBool(50UL, true);
                set => this.WriteData(50UL, value, true);
            }

            public Cereal.LiveLocationKalman.Measurement.WRITER CalibratedOrientationECEF
            {
                get => BuildPointer<Cereal.LiveLocationKalman.Measurement.WRITER>(13);
                set => Link(13, value);
            }

            public bool SensorsOK
            {
                get => this.ReadDataBool(51UL, true);
                set => this.WriteData(51UL, value, true);
            }

            public bool DeviceStable
            {
                get => this.ReadDataBool(52UL, true);
                set => this.WriteData(52UL, value, true);
            }

            public double TimeSinceReset
            {
                get => this.ReadDataDouble(192UL, 0);
                set => this.WriteData(192UL, value, 0);
            }

            public bool ExcessiveResets
            {
                get => this.ReadDataBool(53UL, false);
                set => this.WriteData(53UL, value, false);
            }

            public float TimeToFirstFix
            {
                get => this.ReadDataFloat(256UL, 0F);
                set => this.WriteData(256UL, value, 0F);
            }

            public Cereal.LiveLocationKalman.Measurement.WRITER FilterState
            {
                get => BuildPointer<Cereal.LiveLocationKalman.Measurement.WRITER>(14);
                set => Link(14, value);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x8e4dc8cc4b51fc01UL)]
        public enum Status : ushort
        {
            uninitialized,
            uncalibrated,
            valid
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xbf23f9ed66dace1cUL)]
        public class Measurement : ICapnpSerializable
        {
            public const UInt64 typeId = 0xbf23f9ed66dace1cUL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Value = reader.Value;
                Std = reader.Std;
                Valid = reader.Valid;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Value.Init(Value);
                writer.Std.Init(Std);
                writer.Valid = Valid;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public IReadOnlyList<double> Value
            {
                get;
                set;
            }

            public IReadOnlyList<double> Std
            {
                get;
                set;
            }

            public bool Valid
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public IReadOnlyList<double> Value => ctx.ReadList(0).CastDouble();
                public IReadOnlyList<double> Std => ctx.ReadList(1).CastDouble();
                public bool Valid => ctx.ReadDataBool(0UL, false);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(1, 2);
                }

                public ListOfPrimitivesSerializer<double> Value
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<double>>(0);
                    set => Link(0, value);
                }

                public ListOfPrimitivesSerializer<double> Std
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<double>>(1);
                    set => Link(1, value);
                }

                public bool Valid
                {
                    get => this.ReadDataBool(0UL, false);
                    set => this.WriteData(0UL, value, false);
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xaf85387b3f681406UL)]
    public class ProcLog : ICapnpSerializable
    {
        public const UInt64 typeId = 0xaf85387b3f681406UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            CpuTimes = reader.CpuTimes?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.ProcLog.CPUTimes>(_));
            TheMem = CapnpSerializable.Create<Cereal.ProcLog.Mem>(reader.TheMem);
            Procs = reader.Procs?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.ProcLog.Process>(_));
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.CpuTimes.Init(CpuTimes, (_s1, _v1) => _v1?.serialize(_s1));
            TheMem?.serialize(writer.TheMem);
            writer.Procs.Init(Procs, (_s1, _v1) => _v1?.serialize(_s1));
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public IReadOnlyList<Cereal.ProcLog.CPUTimes> CpuTimes
        {
            get;
            set;
        }

        public Cereal.ProcLog.Mem TheMem
        {
            get;
            set;
        }

        public IReadOnlyList<Cereal.ProcLog.Process> Procs
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public IReadOnlyList<Cereal.ProcLog.CPUTimes.READER> CpuTimes => ctx.ReadList(0).Cast(Cereal.ProcLog.CPUTimes.READER.create);
            public Cereal.ProcLog.Mem.READER TheMem => ctx.ReadStruct(1, Cereal.ProcLog.Mem.READER.create);
            public IReadOnlyList<Cereal.ProcLog.Process.READER> Procs => ctx.ReadList(2).Cast(Cereal.ProcLog.Process.READER.create);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(0, 3);
            }

            public ListOfStructsSerializer<Cereal.ProcLog.CPUTimes.WRITER> CpuTimes
            {
                get => BuildPointer<ListOfStructsSerializer<Cereal.ProcLog.CPUTimes.WRITER>>(0);
                set => Link(0, value);
            }

            public Cereal.ProcLog.Mem.WRITER TheMem
            {
                get => BuildPointer<Cereal.ProcLog.Mem.WRITER>(1);
                set => Link(1, value);
            }

            public ListOfStructsSerializer<Cereal.ProcLog.Process.WRITER> Procs
            {
                get => BuildPointer<ListOfStructsSerializer<Cereal.ProcLog.Process.WRITER>>(2);
                set => Link(2, value);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xb0b85613f19e6d28UL)]
        public class Process : ICapnpSerializable
        {
            public const UInt64 typeId = 0xb0b85613f19e6d28UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Pid = reader.Pid;
                Name = reader.Name;
                State = reader.State;
                Ppid = reader.Ppid;
                CpuUser = reader.CpuUser;
                CpuSystem = reader.CpuSystem;
                CpuChildrenUser = reader.CpuChildrenUser;
                CpuChildrenSystem = reader.CpuChildrenSystem;
                Priority = reader.Priority;
                Nice = reader.Nice;
                NumThreads = reader.NumThreads;
                StartTime = reader.StartTime;
                MemVms = reader.MemVms;
                MemRss = reader.MemRss;
                Processor = reader.Processor;
                Cmdline = reader.Cmdline;
                Exe = reader.Exe;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Pid = Pid;
                writer.Name = Name;
                writer.State = State;
                writer.Ppid = Ppid;
                writer.CpuUser = CpuUser;
                writer.CpuSystem = CpuSystem;
                writer.CpuChildrenUser = CpuChildrenUser;
                writer.CpuChildrenSystem = CpuChildrenSystem;
                writer.Priority = Priority;
                writer.Nice = Nice;
                writer.NumThreads = NumThreads;
                writer.StartTime = StartTime;
                writer.MemVms = MemVms;
                writer.MemRss = MemRss;
                writer.Processor = Processor;
                writer.Cmdline.Init(Cmdline);
                writer.Exe = Exe;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public int Pid
            {
                get;
                set;
            }

            public string Name
            {
                get;
                set;
            }

            public byte State
            {
                get;
                set;
            }

            public int Ppid
            {
                get;
                set;
            }

            public float CpuUser
            {
                get;
                set;
            }

            public float CpuSystem
            {
                get;
                set;
            }

            public float CpuChildrenUser
            {
                get;
                set;
            }

            public float CpuChildrenSystem
            {
                get;
                set;
            }

            public long Priority
            {
                get;
                set;
            }

            public int Nice
            {
                get;
                set;
            }

            public int NumThreads
            {
                get;
                set;
            }

            public double StartTime
            {
                get;
                set;
            }

            public ulong MemVms
            {
                get;
                set;
            }

            public ulong MemRss
            {
                get;
                set;
            }

            public int Processor
            {
                get;
                set;
            }

            public IReadOnlyList<string> Cmdline
            {
                get;
                set;
            }

            public string Exe
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public int Pid => ctx.ReadDataInt(0UL, 0);
                public string Name => ctx.ReadText(0, null);
                public byte State => ctx.ReadDataByte(32UL, (byte)0);
                public int Ppid => ctx.ReadDataInt(64UL, 0);
                public float CpuUser => ctx.ReadDataFloat(96UL, 0F);
                public float CpuSystem => ctx.ReadDataFloat(128UL, 0F);
                public float CpuChildrenUser => ctx.ReadDataFloat(160UL, 0F);
                public float CpuChildrenSystem => ctx.ReadDataFloat(192UL, 0F);
                public long Priority => ctx.ReadDataLong(256UL, 0L);
                public int Nice => ctx.ReadDataInt(224UL, 0);
                public int NumThreads => ctx.ReadDataInt(320UL, 0);
                public double StartTime => ctx.ReadDataDouble(384UL, 0);
                public ulong MemVms => ctx.ReadDataULong(448UL, 0UL);
                public ulong MemRss => ctx.ReadDataULong(512UL, 0UL);
                public int Processor => ctx.ReadDataInt(352UL, 0);
                public IReadOnlyList<string> Cmdline => ctx.ReadList(1).CastText2();
                public string Exe => ctx.ReadText(2, null);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(9, 3);
                }

                public int Pid
                {
                    get => this.ReadDataInt(0UL, 0);
                    set => this.WriteData(0UL, value, 0);
                }

                public string Name
                {
                    get => this.ReadText(0, null);
                    set => this.WriteText(0, value, null);
                }

                public byte State
                {
                    get => this.ReadDataByte(32UL, (byte)0);
                    set => this.WriteData(32UL, value, (byte)0);
                }

                public int Ppid
                {
                    get => this.ReadDataInt(64UL, 0);
                    set => this.WriteData(64UL, value, 0);
                }

                public float CpuUser
                {
                    get => this.ReadDataFloat(96UL, 0F);
                    set => this.WriteData(96UL, value, 0F);
                }

                public float CpuSystem
                {
                    get => this.ReadDataFloat(128UL, 0F);
                    set => this.WriteData(128UL, value, 0F);
                }

                public float CpuChildrenUser
                {
                    get => this.ReadDataFloat(160UL, 0F);
                    set => this.WriteData(160UL, value, 0F);
                }

                public float CpuChildrenSystem
                {
                    get => this.ReadDataFloat(192UL, 0F);
                    set => this.WriteData(192UL, value, 0F);
                }

                public long Priority
                {
                    get => this.ReadDataLong(256UL, 0L);
                    set => this.WriteData(256UL, value, 0L);
                }

                public int Nice
                {
                    get => this.ReadDataInt(224UL, 0);
                    set => this.WriteData(224UL, value, 0);
                }

                public int NumThreads
                {
                    get => this.ReadDataInt(320UL, 0);
                    set => this.WriteData(320UL, value, 0);
                }

                public double StartTime
                {
                    get => this.ReadDataDouble(384UL, 0);
                    set => this.WriteData(384UL, value, 0);
                }

                public ulong MemVms
                {
                    get => this.ReadDataULong(448UL, 0UL);
                    set => this.WriteData(448UL, value, 0UL);
                }

                public ulong MemRss
                {
                    get => this.ReadDataULong(512UL, 0UL);
                    set => this.WriteData(512UL, value, 0UL);
                }

                public int Processor
                {
                    get => this.ReadDataInt(352UL, 0);
                    set => this.WriteData(352UL, value, 0);
                }

                public ListOfTextSerializer Cmdline
                {
                    get => BuildPointer<ListOfTextSerializer>(1);
                    set => Link(1, value);
                }

                public string Exe
                {
                    get => this.ReadText(2, null);
                    set => this.WriteText(2, value, null);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xf189c8c5bf2ce087UL)]
        public class CPUTimes : ICapnpSerializable
        {
            public const UInt64 typeId = 0xf189c8c5bf2ce087UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                CpuNum = reader.CpuNum;
                User = reader.User;
                Nice = reader.Nice;
                System = reader.System;
                Idle = reader.Idle;
                Iowait = reader.Iowait;
                Irq = reader.Irq;
                Softirq = reader.Softirq;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.CpuNum = CpuNum;
                writer.User = User;
                writer.Nice = Nice;
                writer.System = System;
                writer.Idle = Idle;
                writer.Iowait = Iowait;
                writer.Irq = Irq;
                writer.Softirq = Softirq;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public long CpuNum
            {
                get;
                set;
            }

            public float User
            {
                get;
                set;
            }

            public float Nice
            {
                get;
                set;
            }

            public float System
            {
                get;
                set;
            }

            public float Idle
            {
                get;
                set;
            }

            public float Iowait
            {
                get;
                set;
            }

            public float Irq
            {
                get;
                set;
            }

            public float Softirq
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public long CpuNum => ctx.ReadDataLong(0UL, 0L);
                public float User => ctx.ReadDataFloat(64UL, 0F);
                public float Nice => ctx.ReadDataFloat(96UL, 0F);
                public float System => ctx.ReadDataFloat(128UL, 0F);
                public float Idle => ctx.ReadDataFloat(160UL, 0F);
                public float Iowait => ctx.ReadDataFloat(192UL, 0F);
                public float Irq => ctx.ReadDataFloat(224UL, 0F);
                public float Softirq => ctx.ReadDataFloat(256UL, 0F);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(5, 0);
                }

                public long CpuNum
                {
                    get => this.ReadDataLong(0UL, 0L);
                    set => this.WriteData(0UL, value, 0L);
                }

                public float User
                {
                    get => this.ReadDataFloat(64UL, 0F);
                    set => this.WriteData(64UL, value, 0F);
                }

                public float Nice
                {
                    get => this.ReadDataFloat(96UL, 0F);
                    set => this.WriteData(96UL, value, 0F);
                }

                public float System
                {
                    get => this.ReadDataFloat(128UL, 0F);
                    set => this.WriteData(128UL, value, 0F);
                }

                public float Idle
                {
                    get => this.ReadDataFloat(160UL, 0F);
                    set => this.WriteData(160UL, value, 0F);
                }

                public float Iowait
                {
                    get => this.ReadDataFloat(192UL, 0F);
                    set => this.WriteData(192UL, value, 0F);
                }

                public float Irq
                {
                    get => this.ReadDataFloat(224UL, 0F);
                    set => this.WriteData(224UL, value, 0F);
                }

                public float Softirq
                {
                    get => this.ReadDataFloat(256UL, 0F);
                    set => this.WriteData(256UL, value, 0F);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xfd095f94f08b3fd4UL)]
        public class Mem : ICapnpSerializable
        {
            public const UInt64 typeId = 0xfd095f94f08b3fd4UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Total = reader.Total;
                Free = reader.Free;
                Available = reader.Available;
                Buffers = reader.Buffers;
                Cached = reader.Cached;
                Active = reader.Active;
                Inactive = reader.Inactive;
                Shared = reader.Shared;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Total = Total;
                writer.Free = Free;
                writer.Available = Available;
                writer.Buffers = Buffers;
                writer.Cached = Cached;
                writer.Active = Active;
                writer.Inactive = Inactive;
                writer.Shared = Shared;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public ulong Total
            {
                get;
                set;
            }

            public ulong Free
            {
                get;
                set;
            }

            public ulong Available
            {
                get;
                set;
            }

            public ulong Buffers
            {
                get;
                set;
            }

            public ulong Cached
            {
                get;
                set;
            }

            public ulong Active
            {
                get;
                set;
            }

            public ulong Inactive
            {
                get;
                set;
            }

            public ulong Shared
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public ulong Total => ctx.ReadDataULong(0UL, 0UL);
                public ulong Free => ctx.ReadDataULong(64UL, 0UL);
                public ulong Available => ctx.ReadDataULong(128UL, 0UL);
                public ulong Buffers => ctx.ReadDataULong(192UL, 0UL);
                public ulong Cached => ctx.ReadDataULong(256UL, 0UL);
                public ulong Active => ctx.ReadDataULong(320UL, 0UL);
                public ulong Inactive => ctx.ReadDataULong(384UL, 0UL);
                public ulong Shared => ctx.ReadDataULong(448UL, 0UL);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(8, 0);
                }

                public ulong Total
                {
                    get => this.ReadDataULong(0UL, 0UL);
                    set => this.WriteData(0UL, value, 0UL);
                }

                public ulong Free
                {
                    get => this.ReadDataULong(64UL, 0UL);
                    set => this.WriteData(64UL, value, 0UL);
                }

                public ulong Available
                {
                    get => this.ReadDataULong(128UL, 0UL);
                    set => this.WriteData(128UL, value, 0UL);
                }

                public ulong Buffers
                {
                    get => this.ReadDataULong(192UL, 0UL);
                    set => this.WriteData(192UL, value, 0UL);
                }

                public ulong Cached
                {
                    get => this.ReadDataULong(256UL, 0UL);
                    set => this.WriteData(256UL, value, 0UL);
                }

                public ulong Active
                {
                    get => this.ReadDataULong(320UL, 0UL);
                    set => this.WriteData(320UL, value, 0UL);
                }

                public ulong Inactive
                {
                    get => this.ReadDataULong(384UL, 0UL);
                    set => this.WriteData(384UL, value, 0UL);
                }

                public ulong Shared
                {
                    get => this.ReadDataULong(448UL, 0UL);
                    set => this.WriteData(448UL, value, 0UL);
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xafd47016570e9d09UL)]
    public class GnssMeasurements : ICapnpSerializable
    {
        public const UInt64 typeId = 0xafd47016570e9d09UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            MeasTime = reader.MeasTime;
            GpsWeek = reader.GpsWeek;
            GpsTimeOfWeek = reader.GpsTimeOfWeek;
            CorrectedMeasurements = reader.CorrectedMeasurements?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.GnssMeasurements.CorrectedMeasurement>(_));
            KalmanPositionECEF = CapnpSerializable.Create<Cereal.LiveLocationKalman.Measurement>(reader.KalmanPositionECEF);
            KalmanVelocityECEF = CapnpSerializable.Create<Cereal.LiveLocationKalman.Measurement>(reader.KalmanVelocityECEF);
            PositionECEF = CapnpSerializable.Create<Cereal.LiveLocationKalman.Measurement>(reader.PositionECEF);
            VelocityECEF = CapnpSerializable.Create<Cereal.LiveLocationKalman.Measurement>(reader.VelocityECEF);
            TimeToFirstFix = reader.TimeToFirstFix;
            EphemerisStatuses = reader.EphemerisStatuses?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.GnssMeasurements.EphemerisStatus>(_));
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.MeasTime = MeasTime;
            writer.GpsWeek = GpsWeek;
            writer.GpsTimeOfWeek = GpsTimeOfWeek;
            writer.CorrectedMeasurements.Init(CorrectedMeasurements, (_s1, _v1) => _v1?.serialize(_s1));
            KalmanPositionECEF?.serialize(writer.KalmanPositionECEF);
            KalmanVelocityECEF?.serialize(writer.KalmanVelocityECEF);
            PositionECEF?.serialize(writer.PositionECEF);
            VelocityECEF?.serialize(writer.VelocityECEF);
            writer.TimeToFirstFix = TimeToFirstFix;
            writer.EphemerisStatuses.Init(EphemerisStatuses, (_s1, _v1) => _v1?.serialize(_s1));
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public ulong MeasTime
        {
            get;
            set;
        }

        public short GpsWeek
        {
            get;
            set;
        }

        public double GpsTimeOfWeek
        {
            get;
            set;
        }

        public IReadOnlyList<Cereal.GnssMeasurements.CorrectedMeasurement> CorrectedMeasurements
        {
            get;
            set;
        }

        public Cereal.LiveLocationKalman.Measurement KalmanPositionECEF
        {
            get;
            set;
        }

        public Cereal.LiveLocationKalman.Measurement KalmanVelocityECEF
        {
            get;
            set;
        }

        public Cereal.LiveLocationKalman.Measurement PositionECEF
        {
            get;
            set;
        }

        public Cereal.LiveLocationKalman.Measurement VelocityECEF
        {
            get;
            set;
        }

        public float TimeToFirstFix
        {
            get;
            set;
        }

        public IReadOnlyList<Cereal.GnssMeasurements.EphemerisStatus> EphemerisStatuses
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public ulong MeasTime => ctx.ReadDataULong(0UL, 0UL);
            public short GpsWeek => ctx.ReadDataShort(64UL, (short)0);
            public double GpsTimeOfWeek => ctx.ReadDataDouble(128UL, 0);
            public IReadOnlyList<Cereal.GnssMeasurements.CorrectedMeasurement.READER> CorrectedMeasurements => ctx.ReadList(0).Cast(Cereal.GnssMeasurements.CorrectedMeasurement.READER.create);
            public Cereal.LiveLocationKalman.Measurement.READER KalmanPositionECEF => ctx.ReadStruct(1, Cereal.LiveLocationKalman.Measurement.READER.create);
            public Cereal.LiveLocationKalman.Measurement.READER KalmanVelocityECEF => ctx.ReadStruct(2, Cereal.LiveLocationKalman.Measurement.READER.create);
            public Cereal.LiveLocationKalman.Measurement.READER PositionECEF => ctx.ReadStruct(3, Cereal.LiveLocationKalman.Measurement.READER.create);
            public Cereal.LiveLocationKalman.Measurement.READER VelocityECEF => ctx.ReadStruct(4, Cereal.LiveLocationKalman.Measurement.READER.create);
            public float TimeToFirstFix => ctx.ReadDataFloat(96UL, 0F);
            public IReadOnlyList<Cereal.GnssMeasurements.EphemerisStatus.READER> EphemerisStatuses => ctx.ReadList(5).Cast(Cereal.GnssMeasurements.EphemerisStatus.READER.create);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(3, 6);
            }

            public ulong MeasTime
            {
                get => this.ReadDataULong(0UL, 0UL);
                set => this.WriteData(0UL, value, 0UL);
            }

            public short GpsWeek
            {
                get => this.ReadDataShort(64UL, (short)0);
                set => this.WriteData(64UL, value, (short)0);
            }

            public double GpsTimeOfWeek
            {
                get => this.ReadDataDouble(128UL, 0);
                set => this.WriteData(128UL, value, 0);
            }

            public ListOfStructsSerializer<Cereal.GnssMeasurements.CorrectedMeasurement.WRITER> CorrectedMeasurements
            {
                get => BuildPointer<ListOfStructsSerializer<Cereal.GnssMeasurements.CorrectedMeasurement.WRITER>>(0);
                set => Link(0, value);
            }

            public Cereal.LiveLocationKalman.Measurement.WRITER KalmanPositionECEF
            {
                get => BuildPointer<Cereal.LiveLocationKalman.Measurement.WRITER>(1);
                set => Link(1, value);
            }

            public Cereal.LiveLocationKalman.Measurement.WRITER KalmanVelocityECEF
            {
                get => BuildPointer<Cereal.LiveLocationKalman.Measurement.WRITER>(2);
                set => Link(2, value);
            }

            public Cereal.LiveLocationKalman.Measurement.WRITER PositionECEF
            {
                get => BuildPointer<Cereal.LiveLocationKalman.Measurement.WRITER>(3);
                set => Link(3, value);
            }

            public Cereal.LiveLocationKalman.Measurement.WRITER VelocityECEF
            {
                get => BuildPointer<Cereal.LiveLocationKalman.Measurement.WRITER>(4);
                set => Link(4, value);
            }

            public float TimeToFirstFix
            {
                get => this.ReadDataFloat(96UL, 0F);
                set => this.WriteData(96UL, value, 0F);
            }

            public ListOfStructsSerializer<Cereal.GnssMeasurements.EphemerisStatus.WRITER> EphemerisStatuses
            {
                get => BuildPointer<ListOfStructsSerializer<Cereal.GnssMeasurements.EphemerisStatus.WRITER>>(5);
                set => Link(5, value);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xf3286be6a8bfb860UL)]
        public class EphemerisStatus : ICapnpSerializable
        {
            public const UInt64 typeId = 0xf3286be6a8bfb860UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                ConstellationId = reader.ConstellationId;
                SvId = reader.SvId;
                Type = reader.Type;
                Source = reader.Source;
                GpsWeek = reader.GpsWeek;
                Tow = reader.Tow;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.ConstellationId = ConstellationId;
                writer.SvId = SvId;
                writer.Type = Type;
                writer.Source = Source;
                writer.GpsWeek = GpsWeek;
                writer.Tow = Tow;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public Cereal.GnssMeasurements.ConstellationId ConstellationId
            {
                get;
                set;
            }

            public byte SvId
            {
                get;
                set;
            }

            public Cereal.GnssMeasurements.EphemerisType Type
            {
                get;
                set;
            }

            public Cereal.GnssMeasurements.EphemerisSource Source
            {
                get;
                set;
            }

            public ushort GpsWeek
            {
                get;
                set;
            }

            public double Tow
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public Cereal.GnssMeasurements.ConstellationId ConstellationId => (Cereal.GnssMeasurements.ConstellationId)ctx.ReadDataUShort(0UL, (ushort)0);
                public byte SvId => ctx.ReadDataByte(16UL, (byte)0);
                public Cereal.GnssMeasurements.EphemerisType Type => (Cereal.GnssMeasurements.EphemerisType)ctx.ReadDataUShort(32UL, (ushort)0);
                public Cereal.GnssMeasurements.EphemerisSource Source => (Cereal.GnssMeasurements.EphemerisSource)ctx.ReadDataUShort(48UL, (ushort)0);
                public ushort GpsWeek => ctx.ReadDataUShort(64UL, (ushort)0);
                public double Tow => ctx.ReadDataDouble(128UL, 0);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(3, 0);
                }

                public Cereal.GnssMeasurements.ConstellationId ConstellationId
                {
                    get => (Cereal.GnssMeasurements.ConstellationId)this.ReadDataUShort(0UL, (ushort)0);
                    set => this.WriteData(0UL, (ushort)value, (ushort)0);
                }

                public byte SvId
                {
                    get => this.ReadDataByte(16UL, (byte)0);
                    set => this.WriteData(16UL, value, (byte)0);
                }

                public Cereal.GnssMeasurements.EphemerisType Type
                {
                    get => (Cereal.GnssMeasurements.EphemerisType)this.ReadDataUShort(32UL, (ushort)0);
                    set => this.WriteData(32UL, (ushort)value, (ushort)0);
                }

                public Cereal.GnssMeasurements.EphemerisSource Source
                {
                    get => (Cereal.GnssMeasurements.EphemerisSource)this.ReadDataUShort(48UL, (ushort)0);
                    set => this.WriteData(48UL, (ushort)value, (ushort)0);
                }

                public ushort GpsWeek
                {
                    get => this.ReadDataUShort(64UL, (ushort)0);
                    set => this.WriteData(64UL, value, (ushort)0);
                }

                public double Tow
                {
                    get => this.ReadDataDouble(128UL, 0);
                    set => this.WriteData(128UL, value, 0);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xeaa4a17d86ac76b0UL)]
        public class CorrectedMeasurement : ICapnpSerializable
        {
            public const UInt64 typeId = 0xeaa4a17d86ac76b0UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                ConstellationId = reader.ConstellationId;
                SvId = reader.SvId;
                GlonassFrequency = reader.GlonassFrequency;
                Pseudorange = reader.Pseudorange;
                PseudorangeStd = reader.PseudorangeStd;
                PseudorangeRate = reader.PseudorangeRate;
                PseudorangeRateStd = reader.PseudorangeRateStd;
                SatPos = reader.SatPos;
                SatVel = reader.SatVel;
                EphemerisSourceDEPRECATED = CapnpSerializable.Create<Cereal.GnssMeasurements.EphemerisSourceDEPRECATED>(reader.EphemerisSourceDEPRECATED);
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.ConstellationId = ConstellationId;
                writer.SvId = SvId;
                writer.GlonassFrequency = GlonassFrequency;
                writer.Pseudorange = Pseudorange;
                writer.PseudorangeStd = PseudorangeStd;
                writer.PseudorangeRate = PseudorangeRate;
                writer.PseudorangeRateStd = PseudorangeRateStd;
                writer.SatPos.Init(SatPos);
                writer.SatVel.Init(SatVel);
                EphemerisSourceDEPRECATED?.serialize(writer.EphemerisSourceDEPRECATED);
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public Cereal.GnssMeasurements.ConstellationId ConstellationId
            {
                get;
                set;
            }

            public byte SvId
            {
                get;
                set;
            }

            public sbyte GlonassFrequency
            {
                get;
                set;
            }

            public double Pseudorange
            {
                get;
                set;
            }

            public double PseudorangeStd
            {
                get;
                set;
            }

            public double PseudorangeRate
            {
                get;
                set;
            }

            public double PseudorangeRateStd
            {
                get;
                set;
            }

            public IReadOnlyList<double> SatPos
            {
                get;
                set;
            }

            public IReadOnlyList<double> SatVel
            {
                get;
                set;
            }

            public Cereal.GnssMeasurements.EphemerisSourceDEPRECATED EphemerisSourceDEPRECATED
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public Cereal.GnssMeasurements.ConstellationId ConstellationId => (Cereal.GnssMeasurements.ConstellationId)ctx.ReadDataUShort(0UL, (ushort)0);
                public byte SvId => ctx.ReadDataByte(16UL, (byte)0);
                public sbyte GlonassFrequency => ctx.ReadDataSByte(24UL, (sbyte)0);
                public double Pseudorange => ctx.ReadDataDouble(64UL, 0);
                public double PseudorangeStd => ctx.ReadDataDouble(128UL, 0);
                public double PseudorangeRate => ctx.ReadDataDouble(192UL, 0);
                public double PseudorangeRateStd => ctx.ReadDataDouble(256UL, 0);
                public IReadOnlyList<double> SatPos => ctx.ReadList(0).CastDouble();
                public IReadOnlyList<double> SatVel => ctx.ReadList(1).CastDouble();
                public Cereal.GnssMeasurements.EphemerisSourceDEPRECATED.READER EphemerisSourceDEPRECATED => ctx.ReadStruct(2, Cereal.GnssMeasurements.EphemerisSourceDEPRECATED.READER.create);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(5, 3);
                }

                public Cereal.GnssMeasurements.ConstellationId ConstellationId
                {
                    get => (Cereal.GnssMeasurements.ConstellationId)this.ReadDataUShort(0UL, (ushort)0);
                    set => this.WriteData(0UL, (ushort)value, (ushort)0);
                }

                public byte SvId
                {
                    get => this.ReadDataByte(16UL, (byte)0);
                    set => this.WriteData(16UL, value, (byte)0);
                }

                public sbyte GlonassFrequency
                {
                    get => this.ReadDataSByte(24UL, (sbyte)0);
                    set => this.WriteData(24UL, value, (sbyte)0);
                }

                public double Pseudorange
                {
                    get => this.ReadDataDouble(64UL, 0);
                    set => this.WriteData(64UL, value, 0);
                }

                public double PseudorangeStd
                {
                    get => this.ReadDataDouble(128UL, 0);
                    set => this.WriteData(128UL, value, 0);
                }

                public double PseudorangeRate
                {
                    get => this.ReadDataDouble(192UL, 0);
                    set => this.WriteData(192UL, value, 0);
                }

                public double PseudorangeRateStd
                {
                    get => this.ReadDataDouble(256UL, 0);
                    set => this.WriteData(256UL, value, 0);
                }

                public ListOfPrimitivesSerializer<double> SatPos
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<double>>(0);
                    set => Link(0, value);
                }

                public ListOfPrimitivesSerializer<double> SatVel
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<double>>(1);
                    set => Link(1, value);
                }

                public Cereal.GnssMeasurements.EphemerisSourceDEPRECATED.WRITER EphemerisSourceDEPRECATED
                {
                    get => BuildPointer<Cereal.GnssMeasurements.EphemerisSourceDEPRECATED.WRITER>(2);
                    set => Link(2, value);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xbcc2ef5087c0ad85UL)]
        public class EphemerisSourceDEPRECATED : ICapnpSerializable
        {
            public const UInt64 typeId = 0xbcc2ef5087c0ad85UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Type = reader.Type;
                GpsWeek = reader.GpsWeek;
                GpsTimeOfWeek = reader.GpsTimeOfWeek;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Type = Type;
                writer.GpsWeek = GpsWeek;
                writer.GpsTimeOfWeek = GpsTimeOfWeek;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public Cereal.GnssMeasurements.EphemerisType Type
            {
                get;
                set;
            }

            public short GpsWeek
            {
                get;
                set;
            }

            public int GpsTimeOfWeek
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public Cereal.GnssMeasurements.EphemerisType Type => (Cereal.GnssMeasurements.EphemerisType)ctx.ReadDataUShort(0UL, (ushort)0);
                public short GpsWeek => ctx.ReadDataShort(16UL, (short)0);
                public int GpsTimeOfWeek => ctx.ReadDataInt(32UL, 0);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(1, 0);
                }

                public Cereal.GnssMeasurements.EphemerisType Type
                {
                    get => (Cereal.GnssMeasurements.EphemerisType)this.ReadDataUShort(0UL, (ushort)0);
                    set => this.WriteData(0UL, (ushort)value, (ushort)0);
                }

                public short GpsWeek
                {
                    get => this.ReadDataShort(16UL, (short)0);
                    set => this.WriteData(16UL, value, (short)0);
                }

                public int GpsTimeOfWeek
                {
                    get => this.ReadDataInt(32UL, 0);
                    set => this.WriteData(32UL, value, 0);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x82079c2ea8450877UL)]
        public enum ConstellationId : ushort
        {
            gps,
            sbas,
            galileo,
            beidou,
            imes,
            qznss,
            glonass
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xc299bc1804b08d93UL)]
        public enum EphemerisType : ushort
        {
            nav,
            nasaUltraRapid,
            glonassIacUltraRapid,
            qcom
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xf6e39b3396a699f6UL)]
        public enum EphemerisSource : ushort
        {
            gnssChip,
            internet,
            cache,
            unknown
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x85dddd7ce6cefa5dUL)]
    public class UbloxGnss : ICapnpSerializable
    {
        public const UInt64 typeId = 0x85dddd7ce6cefa5dUL;
        public enum WHICH : ushort
        {
            TheMeasurementReport = 0,
            TheEphemeris = 1,
            TheIonoData = 2,
            TheHwStatus = 3,
            TheHwStatus2 = 4,
            TheGlonassEphemeris = 5,
            TheSatReport = 6,
            undefined = 65535
        }

        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            switch (reader.which)
            {
                case WHICH.TheMeasurementReport:
                    TheMeasurementReport = CapnpSerializable.Create<Cereal.UbloxGnss.MeasurementReport>(reader.TheMeasurementReport);
                    break;
                case WHICH.TheEphemeris:
                    TheEphemeris = CapnpSerializable.Create<Cereal.UbloxGnss.Ephemeris>(reader.TheEphemeris);
                    break;
                case WHICH.TheIonoData:
                    TheIonoData = CapnpSerializable.Create<Cereal.UbloxGnss.IonoData>(reader.TheIonoData);
                    break;
                case WHICH.TheHwStatus:
                    TheHwStatus = CapnpSerializable.Create<Cereal.UbloxGnss.HwStatus>(reader.TheHwStatus);
                    break;
                case WHICH.TheHwStatus2:
                    TheHwStatus2 = CapnpSerializable.Create<Cereal.UbloxGnss.HwStatus2>(reader.TheHwStatus2);
                    break;
                case WHICH.TheGlonassEphemeris:
                    TheGlonassEphemeris = CapnpSerializable.Create<Cereal.UbloxGnss.GlonassEphemeris>(reader.TheGlonassEphemeris);
                    break;
                case WHICH.TheSatReport:
                    TheSatReport = CapnpSerializable.Create<Cereal.UbloxGnss.SatReport>(reader.TheSatReport);
                    break;
            }

            applyDefaults();
        }

        private WHICH _which = WHICH.undefined;
        private object _content;
        public WHICH which
        {
            get => _which;
            set
            {
                if (value == _which)
                    return;
                _which = value;
                switch (value)
                {
                    case WHICH.TheMeasurementReport:
                        _content = null;
                        break;
                    case WHICH.TheEphemeris:
                        _content = null;
                        break;
                    case WHICH.TheIonoData:
                        _content = null;
                        break;
                    case WHICH.TheHwStatus:
                        _content = null;
                        break;
                    case WHICH.TheHwStatus2:
                        _content = null;
                        break;
                    case WHICH.TheGlonassEphemeris:
                        _content = null;
                        break;
                    case WHICH.TheSatReport:
                        _content = null;
                        break;
                }
            }
        }

        public void serialize(WRITER writer)
        {
            writer.which = which;
            switch (which)
            {
                case WHICH.TheMeasurementReport:
                    TheMeasurementReport?.serialize(writer.TheMeasurementReport);
                    break;
                case WHICH.TheEphemeris:
                    TheEphemeris?.serialize(writer.TheEphemeris);
                    break;
                case WHICH.TheIonoData:
                    TheIonoData?.serialize(writer.TheIonoData);
                    break;
                case WHICH.TheHwStatus:
                    TheHwStatus?.serialize(writer.TheHwStatus);
                    break;
                case WHICH.TheHwStatus2:
                    TheHwStatus2?.serialize(writer.TheHwStatus2);
                    break;
                case WHICH.TheGlonassEphemeris:
                    TheGlonassEphemeris?.serialize(writer.TheGlonassEphemeris);
                    break;
                case WHICH.TheSatReport:
                    TheSatReport?.serialize(writer.TheSatReport);
                    break;
            }
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public Cereal.UbloxGnss.MeasurementReport TheMeasurementReport
        {
            get => _which == WHICH.TheMeasurementReport ? (Cereal.UbloxGnss.MeasurementReport)_content : null;
            set
            {
                _which = WHICH.TheMeasurementReport;
                _content = value;
            }
        }

        public Cereal.UbloxGnss.Ephemeris TheEphemeris
        {
            get => _which == WHICH.TheEphemeris ? (Cereal.UbloxGnss.Ephemeris)_content : null;
            set
            {
                _which = WHICH.TheEphemeris;
                _content = value;
            }
        }

        public Cereal.UbloxGnss.IonoData TheIonoData
        {
            get => _which == WHICH.TheIonoData ? (Cereal.UbloxGnss.IonoData)_content : null;
            set
            {
                _which = WHICH.TheIonoData;
                _content = value;
            }
        }

        public Cereal.UbloxGnss.HwStatus TheHwStatus
        {
            get => _which == WHICH.TheHwStatus ? (Cereal.UbloxGnss.HwStatus)_content : null;
            set
            {
                _which = WHICH.TheHwStatus;
                _content = value;
            }
        }

        public Cereal.UbloxGnss.HwStatus2 TheHwStatus2
        {
            get => _which == WHICH.TheHwStatus2 ? (Cereal.UbloxGnss.HwStatus2)_content : null;
            set
            {
                _which = WHICH.TheHwStatus2;
                _content = value;
            }
        }

        public Cereal.UbloxGnss.GlonassEphemeris TheGlonassEphemeris
        {
            get => _which == WHICH.TheGlonassEphemeris ? (Cereal.UbloxGnss.GlonassEphemeris)_content : null;
            set
            {
                _which = WHICH.TheGlonassEphemeris;
                _content = value;
            }
        }

        public Cereal.UbloxGnss.SatReport TheSatReport
        {
            get => _which == WHICH.TheSatReport ? (Cereal.UbloxGnss.SatReport)_content : null;
            set
            {
                _which = WHICH.TheSatReport;
                _content = value;
            }
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public WHICH which => (WHICH)ctx.ReadDataUShort(0U, (ushort)0);
            public Cereal.UbloxGnss.MeasurementReport.READER TheMeasurementReport => which == WHICH.TheMeasurementReport ? ctx.ReadStruct(0, Cereal.UbloxGnss.MeasurementReport.READER.create) : default;
            public Cereal.UbloxGnss.Ephemeris.READER TheEphemeris => which == WHICH.TheEphemeris ? ctx.ReadStruct(0, Cereal.UbloxGnss.Ephemeris.READER.create) : default;
            public Cereal.UbloxGnss.IonoData.READER TheIonoData => which == WHICH.TheIonoData ? ctx.ReadStruct(0, Cereal.UbloxGnss.IonoData.READER.create) : default;
            public Cereal.UbloxGnss.HwStatus.READER TheHwStatus => which == WHICH.TheHwStatus ? ctx.ReadStruct(0, Cereal.UbloxGnss.HwStatus.READER.create) : default;
            public Cereal.UbloxGnss.HwStatus2.READER TheHwStatus2 => which == WHICH.TheHwStatus2 ? ctx.ReadStruct(0, Cereal.UbloxGnss.HwStatus2.READER.create) : default;
            public Cereal.UbloxGnss.GlonassEphemeris.READER TheGlonassEphemeris => which == WHICH.TheGlonassEphemeris ? ctx.ReadStruct(0, Cereal.UbloxGnss.GlonassEphemeris.READER.create) : default;
            public Cereal.UbloxGnss.SatReport.READER TheSatReport => which == WHICH.TheSatReport ? ctx.ReadStruct(0, Cereal.UbloxGnss.SatReport.READER.create) : default;
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(1, 1);
            }

            public WHICH which
            {
                get => (WHICH)this.ReadDataUShort(0U, (ushort)0);
                set => this.WriteData(0U, (ushort)value, (ushort)0);
            }

            public Cereal.UbloxGnss.MeasurementReport.WRITER TheMeasurementReport
            {
                get => which == WHICH.TheMeasurementReport ? BuildPointer<Cereal.UbloxGnss.MeasurementReport.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.UbloxGnss.Ephemeris.WRITER TheEphemeris
            {
                get => which == WHICH.TheEphemeris ? BuildPointer<Cereal.UbloxGnss.Ephemeris.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.UbloxGnss.IonoData.WRITER TheIonoData
            {
                get => which == WHICH.TheIonoData ? BuildPointer<Cereal.UbloxGnss.IonoData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.UbloxGnss.HwStatus.WRITER TheHwStatus
            {
                get => which == WHICH.TheHwStatus ? BuildPointer<Cereal.UbloxGnss.HwStatus.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.UbloxGnss.HwStatus2.WRITER TheHwStatus2
            {
                get => which == WHICH.TheHwStatus2 ? BuildPointer<Cereal.UbloxGnss.HwStatus2.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.UbloxGnss.GlonassEphemeris.WRITER TheGlonassEphemeris
            {
                get => which == WHICH.TheGlonassEphemeris ? BuildPointer<Cereal.UbloxGnss.GlonassEphemeris.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.UbloxGnss.SatReport.WRITER TheSatReport
            {
                get => which == WHICH.TheSatReport ? BuildPointer<Cereal.UbloxGnss.SatReport.WRITER>(0) : default;
                set => Link(0, value);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xbb642aff76688f53UL)]
        public class SatReport : ICapnpSerializable
        {
            public const UInt64 typeId = 0xbb642aff76688f53UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                ITow = reader.ITow;
                Svs = reader.Svs?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.UbloxGnss.SatReport.SatInfo>(_));
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.ITow = ITow;
                writer.Svs.Init(Svs, (_s1, _v1) => _v1?.serialize(_s1));
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public uint ITow
            {
                get;
                set;
            }

            public IReadOnlyList<Cereal.UbloxGnss.SatReport.SatInfo> Svs
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public uint ITow => ctx.ReadDataUInt(0UL, 0U);
                public IReadOnlyList<Cereal.UbloxGnss.SatReport.SatInfo.READER> Svs => ctx.ReadList(0).Cast(Cereal.UbloxGnss.SatReport.SatInfo.READER.create);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(1, 1);
                }

                public uint ITow
                {
                    get => this.ReadDataUInt(0UL, 0U);
                    set => this.WriteData(0UL, value, 0U);
                }

                public ListOfStructsSerializer<Cereal.UbloxGnss.SatReport.SatInfo.WRITER> Svs
                {
                    get => BuildPointer<ListOfStructsSerializer<Cereal.UbloxGnss.SatReport.SatInfo.WRITER>>(0);
                    set => Link(0, value);
                }
            }

            [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xe89dce02ced79e43UL)]
            public class SatInfo : ICapnpSerializable
            {
                public const UInt64 typeId = 0xe89dce02ced79e43UL;
                void ICapnpSerializable.Deserialize(DeserializerState arg_)
                {
                    var reader = READER.create(arg_);
                    SvId = reader.SvId;
                    GnssId = reader.GnssId;
                    FlagsBitfield = reader.FlagsBitfield;
                    applyDefaults();
                }

                public void serialize(WRITER writer)
                {
                    writer.SvId = SvId;
                    writer.GnssId = GnssId;
                    writer.FlagsBitfield = FlagsBitfield;
                }

                void ICapnpSerializable.Serialize(SerializerState arg_)
                {
                    serialize(arg_.Rewrap<WRITER>());
                }

                public void applyDefaults()
                {
                }

                public byte SvId
                {
                    get;
                    set;
                }

                public byte GnssId
                {
                    get;
                    set;
                }

                public uint FlagsBitfield
                {
                    get;
                    set;
                }

                public struct READER
                {
                    readonly DeserializerState ctx;
                    public READER(DeserializerState ctx)
                    {
                        this.ctx = ctx;
                    }

                    public static READER create(DeserializerState ctx) => new READER(ctx);
                    public static implicit operator DeserializerState(READER reader) => reader.ctx;
                    public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                    public byte SvId => ctx.ReadDataByte(0UL, (byte)0);
                    public byte GnssId => ctx.ReadDataByte(8UL, (byte)0);
                    public uint FlagsBitfield => ctx.ReadDataUInt(32UL, 0U);
                }

                public class WRITER : SerializerState
                {
                    public WRITER()
                    {
                        this.SetStruct(1, 0);
                    }

                    public byte SvId
                    {
                        get => this.ReadDataByte(0UL, (byte)0);
                        set => this.WriteData(0UL, value, (byte)0);
                    }

                    public byte GnssId
                    {
                        get => this.ReadDataByte(8UL, (byte)0);
                        set => this.WriteData(8UL, value, (byte)0);
                    }

                    public uint FlagsBitfield
                    {
                        get => this.ReadDataUInt(32UL, 0U);
                        set => this.WriteData(32UL, value, 0U);
                    }
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xa73ba546a29820f4UL)]
        public class MeasurementReport : ICapnpSerializable
        {
            public const UInt64 typeId = 0xa73ba546a29820f4UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                RcvTow = reader.RcvTow;
                GpsWeek = reader.GpsWeek;
                LeapSeconds = reader.LeapSeconds;
                TheReceiverStatus = CapnpSerializable.Create<Cereal.UbloxGnss.MeasurementReport.ReceiverStatus>(reader.TheReceiverStatus);
                NumMeas = reader.NumMeas;
                Measurements = reader.Measurements?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.UbloxGnss.MeasurementReport.Measurement>(_));
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.RcvTow = RcvTow;
                writer.GpsWeek = GpsWeek;
                writer.LeapSeconds = LeapSeconds;
                TheReceiverStatus?.serialize(writer.TheReceiverStatus);
                writer.NumMeas = NumMeas;
                writer.Measurements.Init(Measurements, (_s1, _v1) => _v1?.serialize(_s1));
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public double RcvTow
            {
                get;
                set;
            }

            public ushort GpsWeek
            {
                get;
                set;
            }

            public ushort LeapSeconds
            {
                get;
                set;
            }

            public Cereal.UbloxGnss.MeasurementReport.ReceiverStatus TheReceiverStatus
            {
                get;
                set;
            }

            public byte NumMeas
            {
                get;
                set;
            }

            public IReadOnlyList<Cereal.UbloxGnss.MeasurementReport.Measurement> Measurements
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public double RcvTow => ctx.ReadDataDouble(0UL, 0);
                public ushort GpsWeek => ctx.ReadDataUShort(64UL, (ushort)0);
                public ushort LeapSeconds => ctx.ReadDataUShort(80UL, (ushort)0);
                public Cereal.UbloxGnss.MeasurementReport.ReceiverStatus.READER TheReceiverStatus => ctx.ReadStruct(0, Cereal.UbloxGnss.MeasurementReport.ReceiverStatus.READER.create);
                public byte NumMeas => ctx.ReadDataByte(96UL, (byte)0);
                public IReadOnlyList<Cereal.UbloxGnss.MeasurementReport.Measurement.READER> Measurements => ctx.ReadList(1).Cast(Cereal.UbloxGnss.MeasurementReport.Measurement.READER.create);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(2, 2);
                }

                public double RcvTow
                {
                    get => this.ReadDataDouble(0UL, 0);
                    set => this.WriteData(0UL, value, 0);
                }

                public ushort GpsWeek
                {
                    get => this.ReadDataUShort(64UL, (ushort)0);
                    set => this.WriteData(64UL, value, (ushort)0);
                }

                public ushort LeapSeconds
                {
                    get => this.ReadDataUShort(80UL, (ushort)0);
                    set => this.WriteData(80UL, value, (ushort)0);
                }

                public Cereal.UbloxGnss.MeasurementReport.ReceiverStatus.WRITER TheReceiverStatus
                {
                    get => BuildPointer<Cereal.UbloxGnss.MeasurementReport.ReceiverStatus.WRITER>(0);
                    set => Link(0, value);
                }

                public byte NumMeas
                {
                    get => this.ReadDataByte(96UL, (byte)0);
                    set => this.WriteData(96UL, value, (byte)0);
                }

                public ListOfStructsSerializer<Cereal.UbloxGnss.MeasurementReport.Measurement.WRITER> Measurements
                {
                    get => BuildPointer<ListOfStructsSerializer<Cereal.UbloxGnss.MeasurementReport.Measurement.WRITER>>(1);
                    set => Link(1, value);
                }
            }

            [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xfbb838d65160aab6UL)]
            public class ReceiverStatus : ICapnpSerializable
            {
                public const UInt64 typeId = 0xfbb838d65160aab6UL;
                void ICapnpSerializable.Deserialize(DeserializerState arg_)
                {
                    var reader = READER.create(arg_);
                    LeapSecValid = reader.LeapSecValid;
                    ClkReset = reader.ClkReset;
                    applyDefaults();
                }

                public void serialize(WRITER writer)
                {
                    writer.LeapSecValid = LeapSecValid;
                    writer.ClkReset = ClkReset;
                }

                void ICapnpSerializable.Serialize(SerializerState arg_)
                {
                    serialize(arg_.Rewrap<WRITER>());
                }

                public void applyDefaults()
                {
                }

                public bool LeapSecValid
                {
                    get;
                    set;
                }

                public bool ClkReset
                {
                    get;
                    set;
                }

                public struct READER
                {
                    readonly DeserializerState ctx;
                    public READER(DeserializerState ctx)
                    {
                        this.ctx = ctx;
                    }

                    public static READER create(DeserializerState ctx) => new READER(ctx);
                    public static implicit operator DeserializerState(READER reader) => reader.ctx;
                    public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                    public bool LeapSecValid => ctx.ReadDataBool(0UL, false);
                    public bool ClkReset => ctx.ReadDataBool(1UL, false);
                }

                public class WRITER : SerializerState
                {
                    public WRITER()
                    {
                        this.SetStruct(1, 0);
                    }

                    public bool LeapSecValid
                    {
                        get => this.ReadDataBool(0UL, false);
                        set => this.WriteData(0UL, value, false);
                    }

                    public bool ClkReset
                    {
                        get => this.ReadDataBool(1UL, false);
                        set => this.WriteData(1UL, value, false);
                    }
                }
            }

            [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x8f8a655f5e326401UL)]
            public class Measurement : ICapnpSerializable
            {
                public const UInt64 typeId = 0x8f8a655f5e326401UL;
                void ICapnpSerializable.Deserialize(DeserializerState arg_)
                {
                    var reader = READER.create(arg_);
                    SvId = reader.SvId;
                    TheTrackingStatus = CapnpSerializable.Create<Cereal.UbloxGnss.MeasurementReport.Measurement.TrackingStatus>(reader.TheTrackingStatus);
                    Pseudorange = reader.Pseudorange;
                    CarrierCycles = reader.CarrierCycles;
                    Doppler = reader.Doppler;
                    GnssId = reader.GnssId;
                    GlonassFrequencyIndex = reader.GlonassFrequencyIndex;
                    Locktime = reader.Locktime;
                    Cno = reader.Cno;
                    PseudorangeStdev = reader.PseudorangeStdev;
                    CarrierPhaseStdev = reader.CarrierPhaseStdev;
                    DopplerStdev = reader.DopplerStdev;
                    SigId = reader.SigId;
                    applyDefaults();
                }

                public void serialize(WRITER writer)
                {
                    writer.SvId = SvId;
                    TheTrackingStatus?.serialize(writer.TheTrackingStatus);
                    writer.Pseudorange = Pseudorange;
                    writer.CarrierCycles = CarrierCycles;
                    writer.Doppler = Doppler;
                    writer.GnssId = GnssId;
                    writer.GlonassFrequencyIndex = GlonassFrequencyIndex;
                    writer.Locktime = Locktime;
                    writer.Cno = Cno;
                    writer.PseudorangeStdev = PseudorangeStdev;
                    writer.CarrierPhaseStdev = CarrierPhaseStdev;
                    writer.DopplerStdev = DopplerStdev;
                    writer.SigId = SigId;
                }

                void ICapnpSerializable.Serialize(SerializerState arg_)
                {
                    serialize(arg_.Rewrap<WRITER>());
                }

                public void applyDefaults()
                {
                }

                public byte SvId
                {
                    get;
                    set;
                }

                public Cereal.UbloxGnss.MeasurementReport.Measurement.TrackingStatus TheTrackingStatus
                {
                    get;
                    set;
                }

                public double Pseudorange
                {
                    get;
                    set;
                }

                public double CarrierCycles
                {
                    get;
                    set;
                }

                public float Doppler
                {
                    get;
                    set;
                }

                public byte GnssId
                {
                    get;
                    set;
                }

                public byte GlonassFrequencyIndex
                {
                    get;
                    set;
                }

                public ushort Locktime
                {
                    get;
                    set;
                }

                public byte Cno
                {
                    get;
                    set;
                }

                public float PseudorangeStdev
                {
                    get;
                    set;
                }

                public float CarrierPhaseStdev
                {
                    get;
                    set;
                }

                public float DopplerStdev
                {
                    get;
                    set;
                }

                public byte SigId
                {
                    get;
                    set;
                }

                public struct READER
                {
                    readonly DeserializerState ctx;
                    public READER(DeserializerState ctx)
                    {
                        this.ctx = ctx;
                    }

                    public static READER create(DeserializerState ctx) => new READER(ctx);
                    public static implicit operator DeserializerState(READER reader) => reader.ctx;
                    public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                    public byte SvId => ctx.ReadDataByte(0UL, (byte)0);
                    public Cereal.UbloxGnss.MeasurementReport.Measurement.TrackingStatus.READER TheTrackingStatus => ctx.ReadStruct(0, Cereal.UbloxGnss.MeasurementReport.Measurement.TrackingStatus.READER.create);
                    public double Pseudorange => ctx.ReadDataDouble(64UL, 0);
                    public double CarrierCycles => ctx.ReadDataDouble(128UL, 0);
                    public float Doppler => ctx.ReadDataFloat(32UL, 0F);
                    public byte GnssId => ctx.ReadDataByte(8UL, (byte)0);
                    public byte GlonassFrequencyIndex => ctx.ReadDataByte(16UL, (byte)0);
                    public ushort Locktime => ctx.ReadDataUShort(192UL, (ushort)0);
                    public byte Cno => ctx.ReadDataByte(24UL, (byte)0);
                    public float PseudorangeStdev => ctx.ReadDataFloat(224UL, 0F);
                    public float CarrierPhaseStdev => ctx.ReadDataFloat(256UL, 0F);
                    public float DopplerStdev => ctx.ReadDataFloat(288UL, 0F);
                    public byte SigId => ctx.ReadDataByte(208UL, (byte)0);
                }

                public class WRITER : SerializerState
                {
                    public WRITER()
                    {
                        this.SetStruct(5, 1);
                    }

                    public byte SvId
                    {
                        get => this.ReadDataByte(0UL, (byte)0);
                        set => this.WriteData(0UL, value, (byte)0);
                    }

                    public Cereal.UbloxGnss.MeasurementReport.Measurement.TrackingStatus.WRITER TheTrackingStatus
                    {
                        get => BuildPointer<Cereal.UbloxGnss.MeasurementReport.Measurement.TrackingStatus.WRITER>(0);
                        set => Link(0, value);
                    }

                    public double Pseudorange
                    {
                        get => this.ReadDataDouble(64UL, 0);
                        set => this.WriteData(64UL, value, 0);
                    }

                    public double CarrierCycles
                    {
                        get => this.ReadDataDouble(128UL, 0);
                        set => this.WriteData(128UL, value, 0);
                    }

                    public float Doppler
                    {
                        get => this.ReadDataFloat(32UL, 0F);
                        set => this.WriteData(32UL, value, 0F);
                    }

                    public byte GnssId
                    {
                        get => this.ReadDataByte(8UL, (byte)0);
                        set => this.WriteData(8UL, value, (byte)0);
                    }

                    public byte GlonassFrequencyIndex
                    {
                        get => this.ReadDataByte(16UL, (byte)0);
                        set => this.WriteData(16UL, value, (byte)0);
                    }

                    public ushort Locktime
                    {
                        get => this.ReadDataUShort(192UL, (ushort)0);
                        set => this.WriteData(192UL, value, (ushort)0);
                    }

                    public byte Cno
                    {
                        get => this.ReadDataByte(24UL, (byte)0);
                        set => this.WriteData(24UL, value, (byte)0);
                    }

                    public float PseudorangeStdev
                    {
                        get => this.ReadDataFloat(224UL, 0F);
                        set => this.WriteData(224UL, value, 0F);
                    }

                    public float CarrierPhaseStdev
                    {
                        get => this.ReadDataFloat(256UL, 0F);
                        set => this.WriteData(256UL, value, 0F);
                    }

                    public float DopplerStdev
                    {
                        get => this.ReadDataFloat(288UL, 0F);
                        set => this.WriteData(288UL, value, 0F);
                    }

                    public byte SigId
                    {
                        get => this.ReadDataByte(208UL, (byte)0);
                        set => this.WriteData(208UL, value, (byte)0);
                    }
                }

                [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xe8efb3a802b299b2UL)]
                public class TrackingStatus : ICapnpSerializable
                {
                    public const UInt64 typeId = 0xe8efb3a802b299b2UL;
                    void ICapnpSerializable.Deserialize(DeserializerState arg_)
                    {
                        var reader = READER.create(arg_);
                        PseudorangeValid = reader.PseudorangeValid;
                        CarrierPhaseValid = reader.CarrierPhaseValid;
                        HalfCycleValid = reader.HalfCycleValid;
                        HalfCycleSubtracted = reader.HalfCycleSubtracted;
                        applyDefaults();
                    }

                    public void serialize(WRITER writer)
                    {
                        writer.PseudorangeValid = PseudorangeValid;
                        writer.CarrierPhaseValid = CarrierPhaseValid;
                        writer.HalfCycleValid = HalfCycleValid;
                        writer.HalfCycleSubtracted = HalfCycleSubtracted;
                    }

                    void ICapnpSerializable.Serialize(SerializerState arg_)
                    {
                        serialize(arg_.Rewrap<WRITER>());
                    }

                    public void applyDefaults()
                    {
                    }

                    public bool PseudorangeValid
                    {
                        get;
                        set;
                    }

                    public bool CarrierPhaseValid
                    {
                        get;
                        set;
                    }

                    public bool HalfCycleValid
                    {
                        get;
                        set;
                    }

                    public bool HalfCycleSubtracted
                    {
                        get;
                        set;
                    }

                    public struct READER
                    {
                        readonly DeserializerState ctx;
                        public READER(DeserializerState ctx)
                        {
                            this.ctx = ctx;
                        }

                        public static READER create(DeserializerState ctx) => new READER(ctx);
                        public static implicit operator DeserializerState(READER reader) => reader.ctx;
                        public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                        public bool PseudorangeValid => ctx.ReadDataBool(0UL, false);
                        public bool CarrierPhaseValid => ctx.ReadDataBool(1UL, false);
                        public bool HalfCycleValid => ctx.ReadDataBool(2UL, false);
                        public bool HalfCycleSubtracted => ctx.ReadDataBool(3UL, false);
                    }

                    public class WRITER : SerializerState
                    {
                        public WRITER()
                        {
                            this.SetStruct(1, 0);
                        }

                        public bool PseudorangeValid
                        {
                            get => this.ReadDataBool(0UL, false);
                            set => this.WriteData(0UL, value, false);
                        }

                        public bool CarrierPhaseValid
                        {
                            get => this.ReadDataBool(1UL, false);
                            set => this.WriteData(1UL, value, false);
                        }

                        public bool HalfCycleValid
                        {
                            get => this.ReadDataBool(2UL, false);
                            set => this.WriteData(2UL, value, false);
                        }

                        public bool HalfCycleSubtracted
                        {
                            get => this.ReadDataBool(3UL, false);
                            set => this.WriteData(3UL, value, false);
                        }
                    }
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xd8418c788118f85cUL)]
        public class Ephemeris : ICapnpSerializable
        {
            public const UInt64 typeId = 0xd8418c788118f85cUL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                SvId = reader.SvId;
                Year = reader.Year;
                Month = reader.Month;
                Day = reader.Day;
                Hour = reader.Hour;
                Minute = reader.Minute;
                Second = reader.Second;
                Af0 = reader.Af0;
                Af1 = reader.Af1;
                Af2 = reader.Af2;
                Iode = reader.Iode;
                Crs = reader.Crs;
                DeltaN = reader.DeltaN;
                M0 = reader.M0;
                Cuc = reader.Cuc;
                Ecc = reader.Ecc;
                Cus = reader.Cus;
                A = reader.A;
                Toe = reader.Toe;
                Cic = reader.Cic;
                Omega0 = reader.Omega0;
                Cis = reader.Cis;
                I0 = reader.I0;
                Crc = reader.Crc;
                Omega = reader.Omega;
                OmegaDot = reader.OmegaDot;
                IDot = reader.IDot;
                CodesL2 = reader.CodesL2;
                GpsWeekDEPRECATED = reader.GpsWeekDEPRECATED;
                L2 = reader.L2;
                SvAcc = reader.SvAcc;
                SvHealth = reader.SvHealth;
                Tgd = reader.Tgd;
                Iodc = reader.Iodc;
                TransmissionTime = reader.TransmissionTime;
                FitInterval = reader.FitInterval;
                Toc = reader.Toc;
                IonoCoeffsValid = reader.IonoCoeffsValid;
                IonoAlpha = reader.IonoAlpha;
                IonoBeta = reader.IonoBeta;
                TowCount = reader.TowCount;
                ToeWeek = reader.ToeWeek;
                TocWeek = reader.TocWeek;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.SvId = SvId;
                writer.Year = Year;
                writer.Month = Month;
                writer.Day = Day;
                writer.Hour = Hour;
                writer.Minute = Minute;
                writer.Second = Second;
                writer.Af0 = Af0;
                writer.Af1 = Af1;
                writer.Af2 = Af2;
                writer.Iode = Iode;
                writer.Crs = Crs;
                writer.DeltaN = DeltaN;
                writer.M0 = M0;
                writer.Cuc = Cuc;
                writer.Ecc = Ecc;
                writer.Cus = Cus;
                writer.A = A;
                writer.Toe = Toe;
                writer.Cic = Cic;
                writer.Omega0 = Omega0;
                writer.Cis = Cis;
                writer.I0 = I0;
                writer.Crc = Crc;
                writer.Omega = Omega;
                writer.OmegaDot = OmegaDot;
                writer.IDot = IDot;
                writer.CodesL2 = CodesL2;
                writer.GpsWeekDEPRECATED = GpsWeekDEPRECATED;
                writer.L2 = L2;
                writer.SvAcc = SvAcc;
                writer.SvHealth = SvHealth;
                writer.Tgd = Tgd;
                writer.Iodc = Iodc;
                writer.TransmissionTime = TransmissionTime;
                writer.FitInterval = FitInterval;
                writer.Toc = Toc;
                writer.IonoCoeffsValid = IonoCoeffsValid;
                writer.IonoAlpha.Init(IonoAlpha);
                writer.IonoBeta.Init(IonoBeta);
                writer.TowCount = TowCount;
                writer.ToeWeek = ToeWeek;
                writer.TocWeek = TocWeek;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public ushort SvId
            {
                get;
                set;
            }

            public ushort Year
            {
                get;
                set;
            }

            public ushort Month
            {
                get;
                set;
            }

            public ushort Day
            {
                get;
                set;
            }

            public ushort Hour
            {
                get;
                set;
            }

            public ushort Minute
            {
                get;
                set;
            }

            public float Second
            {
                get;
                set;
            }

            public double Af0
            {
                get;
                set;
            }

            public double Af1
            {
                get;
                set;
            }

            public double Af2
            {
                get;
                set;
            }

            public double Iode
            {
                get;
                set;
            }

            public double Crs
            {
                get;
                set;
            }

            public double DeltaN
            {
                get;
                set;
            }

            public double M0
            {
                get;
                set;
            }

            public double Cuc
            {
                get;
                set;
            }

            public double Ecc
            {
                get;
                set;
            }

            public double Cus
            {
                get;
                set;
            }

            public double A
            {
                get;
                set;
            }

            public double Toe
            {
                get;
                set;
            }

            public double Cic
            {
                get;
                set;
            }

            public double Omega0
            {
                get;
                set;
            }

            public double Cis
            {
                get;
                set;
            }

            public double I0
            {
                get;
                set;
            }

            public double Crc
            {
                get;
                set;
            }

            public double Omega
            {
                get;
                set;
            }

            public double OmegaDot
            {
                get;
                set;
            }

            public double IDot
            {
                get;
                set;
            }

            public double CodesL2
            {
                get;
                set;
            }

            public double GpsWeekDEPRECATED
            {
                get;
                set;
            }

            public double L2
            {
                get;
                set;
            }

            public double SvAcc
            {
                get;
                set;
            }

            public double SvHealth
            {
                get;
                set;
            }

            public double Tgd
            {
                get;
                set;
            }

            public double Iodc
            {
                get;
                set;
            }

            public double TransmissionTime
            {
                get;
                set;
            }

            public double FitInterval
            {
                get;
                set;
            }

            public double Toc
            {
                get;
                set;
            }

            public bool IonoCoeffsValid
            {
                get;
                set;
            }

            public IReadOnlyList<double> IonoAlpha
            {
                get;
                set;
            }

            public IReadOnlyList<double> IonoBeta
            {
                get;
                set;
            }

            public uint TowCount
            {
                get;
                set;
            }

            public ushort ToeWeek
            {
                get;
                set;
            }

            public ushort TocWeek
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public ushort SvId => ctx.ReadDataUShort(0UL, (ushort)0);
                public ushort Year => ctx.ReadDataUShort(16UL, (ushort)0);
                public ushort Month => ctx.ReadDataUShort(32UL, (ushort)0);
                public ushort Day => ctx.ReadDataUShort(48UL, (ushort)0);
                public ushort Hour => ctx.ReadDataUShort(64UL, (ushort)0);
                public ushort Minute => ctx.ReadDataUShort(80UL, (ushort)0);
                public float Second => ctx.ReadDataFloat(96UL, 0F);
                public double Af0 => ctx.ReadDataDouble(128UL, 0);
                public double Af1 => ctx.ReadDataDouble(192UL, 0);
                public double Af2 => ctx.ReadDataDouble(256UL, 0);
                public double Iode => ctx.ReadDataDouble(320UL, 0);
                public double Crs => ctx.ReadDataDouble(384UL, 0);
                public double DeltaN => ctx.ReadDataDouble(448UL, 0);
                public double M0 => ctx.ReadDataDouble(512UL, 0);
                public double Cuc => ctx.ReadDataDouble(576UL, 0);
                public double Ecc => ctx.ReadDataDouble(640UL, 0);
                public double Cus => ctx.ReadDataDouble(704UL, 0);
                public double A => ctx.ReadDataDouble(768UL, 0);
                public double Toe => ctx.ReadDataDouble(832UL, 0);
                public double Cic => ctx.ReadDataDouble(896UL, 0);
                public double Omega0 => ctx.ReadDataDouble(960UL, 0);
                public double Cis => ctx.ReadDataDouble(1024UL, 0);
                public double I0 => ctx.ReadDataDouble(1088UL, 0);
                public double Crc => ctx.ReadDataDouble(1152UL, 0);
                public double Omega => ctx.ReadDataDouble(1216UL, 0);
                public double OmegaDot => ctx.ReadDataDouble(1280UL, 0);
                public double IDot => ctx.ReadDataDouble(1344UL, 0);
                public double CodesL2 => ctx.ReadDataDouble(1408UL, 0);
                public double GpsWeekDEPRECATED => ctx.ReadDataDouble(1472UL, 0);
                public double L2 => ctx.ReadDataDouble(1536UL, 0);
                public double SvAcc => ctx.ReadDataDouble(1600UL, 0);
                public double SvHealth => ctx.ReadDataDouble(1664UL, 0);
                public double Tgd => ctx.ReadDataDouble(1728UL, 0);
                public double Iodc => ctx.ReadDataDouble(1792UL, 0);
                public double TransmissionTime => ctx.ReadDataDouble(1856UL, 0);
                public double FitInterval => ctx.ReadDataDouble(1920UL, 0);
                public double Toc => ctx.ReadDataDouble(1984UL, 0);
                public bool IonoCoeffsValid => ctx.ReadDataBool(2048UL, false);
                public IReadOnlyList<double> IonoAlpha => ctx.ReadList(0).CastDouble();
                public IReadOnlyList<double> IonoBeta => ctx.ReadList(1).CastDouble();
                public uint TowCount => ctx.ReadDataUInt(2080UL, 0U);
                public ushort ToeWeek => ctx.ReadDataUShort(2064UL, (ushort)0);
                public ushort TocWeek => ctx.ReadDataUShort(2112UL, (ushort)0);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(34, 2);
                }

                public ushort SvId
                {
                    get => this.ReadDataUShort(0UL, (ushort)0);
                    set => this.WriteData(0UL, value, (ushort)0);
                }

                public ushort Year
                {
                    get => this.ReadDataUShort(16UL, (ushort)0);
                    set => this.WriteData(16UL, value, (ushort)0);
                }

                public ushort Month
                {
                    get => this.ReadDataUShort(32UL, (ushort)0);
                    set => this.WriteData(32UL, value, (ushort)0);
                }

                public ushort Day
                {
                    get => this.ReadDataUShort(48UL, (ushort)0);
                    set => this.WriteData(48UL, value, (ushort)0);
                }

                public ushort Hour
                {
                    get => this.ReadDataUShort(64UL, (ushort)0);
                    set => this.WriteData(64UL, value, (ushort)0);
                }

                public ushort Minute
                {
                    get => this.ReadDataUShort(80UL, (ushort)0);
                    set => this.WriteData(80UL, value, (ushort)0);
                }

                public float Second
                {
                    get => this.ReadDataFloat(96UL, 0F);
                    set => this.WriteData(96UL, value, 0F);
                }

                public double Af0
                {
                    get => this.ReadDataDouble(128UL, 0);
                    set => this.WriteData(128UL, value, 0);
                }

                public double Af1
                {
                    get => this.ReadDataDouble(192UL, 0);
                    set => this.WriteData(192UL, value, 0);
                }

                public double Af2
                {
                    get => this.ReadDataDouble(256UL, 0);
                    set => this.WriteData(256UL, value, 0);
                }

                public double Iode
                {
                    get => this.ReadDataDouble(320UL, 0);
                    set => this.WriteData(320UL, value, 0);
                }

                public double Crs
                {
                    get => this.ReadDataDouble(384UL, 0);
                    set => this.WriteData(384UL, value, 0);
                }

                public double DeltaN
                {
                    get => this.ReadDataDouble(448UL, 0);
                    set => this.WriteData(448UL, value, 0);
                }

                public double M0
                {
                    get => this.ReadDataDouble(512UL, 0);
                    set => this.WriteData(512UL, value, 0);
                }

                public double Cuc
                {
                    get => this.ReadDataDouble(576UL, 0);
                    set => this.WriteData(576UL, value, 0);
                }

                public double Ecc
                {
                    get => this.ReadDataDouble(640UL, 0);
                    set => this.WriteData(640UL, value, 0);
                }

                public double Cus
                {
                    get => this.ReadDataDouble(704UL, 0);
                    set => this.WriteData(704UL, value, 0);
                }

                public double A
                {
                    get => this.ReadDataDouble(768UL, 0);
                    set => this.WriteData(768UL, value, 0);
                }

                public double Toe
                {
                    get => this.ReadDataDouble(832UL, 0);
                    set => this.WriteData(832UL, value, 0);
                }

                public double Cic
                {
                    get => this.ReadDataDouble(896UL, 0);
                    set => this.WriteData(896UL, value, 0);
                }

                public double Omega0
                {
                    get => this.ReadDataDouble(960UL, 0);
                    set => this.WriteData(960UL, value, 0);
                }

                public double Cis
                {
                    get => this.ReadDataDouble(1024UL, 0);
                    set => this.WriteData(1024UL, value, 0);
                }

                public double I0
                {
                    get => this.ReadDataDouble(1088UL, 0);
                    set => this.WriteData(1088UL, value, 0);
                }

                public double Crc
                {
                    get => this.ReadDataDouble(1152UL, 0);
                    set => this.WriteData(1152UL, value, 0);
                }

                public double Omega
                {
                    get => this.ReadDataDouble(1216UL, 0);
                    set => this.WriteData(1216UL, value, 0);
                }

                public double OmegaDot
                {
                    get => this.ReadDataDouble(1280UL, 0);
                    set => this.WriteData(1280UL, value, 0);
                }

                public double IDot
                {
                    get => this.ReadDataDouble(1344UL, 0);
                    set => this.WriteData(1344UL, value, 0);
                }

                public double CodesL2
                {
                    get => this.ReadDataDouble(1408UL, 0);
                    set => this.WriteData(1408UL, value, 0);
                }

                public double GpsWeekDEPRECATED
                {
                    get => this.ReadDataDouble(1472UL, 0);
                    set => this.WriteData(1472UL, value, 0);
                }

                public double L2
                {
                    get => this.ReadDataDouble(1536UL, 0);
                    set => this.WriteData(1536UL, value, 0);
                }

                public double SvAcc
                {
                    get => this.ReadDataDouble(1600UL, 0);
                    set => this.WriteData(1600UL, value, 0);
                }

                public double SvHealth
                {
                    get => this.ReadDataDouble(1664UL, 0);
                    set => this.WriteData(1664UL, value, 0);
                }

                public double Tgd
                {
                    get => this.ReadDataDouble(1728UL, 0);
                    set => this.WriteData(1728UL, value, 0);
                }

                public double Iodc
                {
                    get => this.ReadDataDouble(1792UL, 0);
                    set => this.WriteData(1792UL, value, 0);
                }

                public double TransmissionTime
                {
                    get => this.ReadDataDouble(1856UL, 0);
                    set => this.WriteData(1856UL, value, 0);
                }

                public double FitInterval
                {
                    get => this.ReadDataDouble(1920UL, 0);
                    set => this.WriteData(1920UL, value, 0);
                }

                public double Toc
                {
                    get => this.ReadDataDouble(1984UL, 0);
                    set => this.WriteData(1984UL, value, 0);
                }

                public bool IonoCoeffsValid
                {
                    get => this.ReadDataBool(2048UL, false);
                    set => this.WriteData(2048UL, value, false);
                }

                public ListOfPrimitivesSerializer<double> IonoAlpha
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<double>>(0);
                    set => Link(0, value);
                }

                public ListOfPrimitivesSerializer<double> IonoBeta
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<double>>(1);
                    set => Link(1, value);
                }

                public uint TowCount
                {
                    get => this.ReadDataUInt(2080UL, 0U);
                    set => this.WriteData(2080UL, value, 0U);
                }

                public ushort ToeWeek
                {
                    get => this.ReadDataUShort(2064UL, (ushort)0);
                    set => this.WriteData(2064UL, value, (ushort)0);
                }

                public ushort TocWeek
                {
                    get => this.ReadDataUShort(2112UL, (ushort)0);
                    set => this.WriteData(2112UL, value, (ushort)0);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xc3a3a8de519a4a26UL)]
        public class IonoData : ICapnpSerializable
        {
            public const UInt64 typeId = 0xc3a3a8de519a4a26UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                SvHealth = reader.SvHealth;
                Tow = reader.Tow;
                GpsWeek = reader.GpsWeek;
                IonoAlpha = reader.IonoAlpha;
                IonoBeta = reader.IonoBeta;
                HealthValid = reader.HealthValid;
                IonoCoeffsValid = reader.IonoCoeffsValid;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.SvHealth = SvHealth;
                writer.Tow = Tow;
                writer.GpsWeek = GpsWeek;
                writer.IonoAlpha.Init(IonoAlpha);
                writer.IonoBeta.Init(IonoBeta);
                writer.HealthValid = HealthValid;
                writer.IonoCoeffsValid = IonoCoeffsValid;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public uint SvHealth
            {
                get;
                set;
            }

            public double Tow
            {
                get;
                set;
            }

            public double GpsWeek
            {
                get;
                set;
            }

            public IReadOnlyList<double> IonoAlpha
            {
                get;
                set;
            }

            public IReadOnlyList<double> IonoBeta
            {
                get;
                set;
            }

            public bool HealthValid
            {
                get;
                set;
            }

            public bool IonoCoeffsValid
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public uint SvHealth => ctx.ReadDataUInt(0UL, 0U);
                public double Tow => ctx.ReadDataDouble(64UL, 0);
                public double GpsWeek => ctx.ReadDataDouble(128UL, 0);
                public IReadOnlyList<double> IonoAlpha => ctx.ReadList(0).CastDouble();
                public IReadOnlyList<double> IonoBeta => ctx.ReadList(1).CastDouble();
                public bool HealthValid => ctx.ReadDataBool(32UL, false);
                public bool IonoCoeffsValid => ctx.ReadDataBool(33UL, false);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(3, 2);
                }

                public uint SvHealth
                {
                    get => this.ReadDataUInt(0UL, 0U);
                    set => this.WriteData(0UL, value, 0U);
                }

                public double Tow
                {
                    get => this.ReadDataDouble(64UL, 0);
                    set => this.WriteData(64UL, value, 0);
                }

                public double GpsWeek
                {
                    get => this.ReadDataDouble(128UL, 0);
                    set => this.WriteData(128UL, value, 0);
                }

                public ListOfPrimitivesSerializer<double> IonoAlpha
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<double>>(0);
                    set => Link(0, value);
                }

                public ListOfPrimitivesSerializer<double> IonoBeta
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<double>>(1);
                    set => Link(1, value);
                }

                public bool HealthValid
                {
                    get => this.ReadDataBool(32UL, false);
                    set => this.WriteData(32UL, value, false);
                }

                public bool IonoCoeffsValid
                {
                    get => this.ReadDataBool(33UL, false);
                    set => this.WriteData(33UL, value, false);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xebb036b114275aa8UL)]
        public class HwStatus : ICapnpSerializable
        {
            public const UInt64 typeId = 0xebb036b114275aa8UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                NoisePerMS = reader.NoisePerMS;
                AgcCnt = reader.AgcCnt;
                AStatus = reader.AStatus;
                APower = reader.APower;
                JamInd = reader.JamInd;
                Flags = reader.Flags;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.NoisePerMS = NoisePerMS;
                writer.AgcCnt = AgcCnt;
                writer.AStatus = AStatus;
                writer.APower = APower;
                writer.JamInd = JamInd;
                writer.Flags = Flags;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public ushort NoisePerMS
            {
                get;
                set;
            }

            public ushort AgcCnt
            {
                get;
                set;
            }

            public Cereal.UbloxGnss.HwStatus.AntennaSupervisorState AStatus
            {
                get;
                set;
            }

            public Cereal.UbloxGnss.HwStatus.AntennaPowerStatus APower
            {
                get;
                set;
            }

            public byte JamInd
            {
                get;
                set;
            }

            public byte Flags
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public ushort NoisePerMS => ctx.ReadDataUShort(0UL, (ushort)0);
                public ushort AgcCnt => ctx.ReadDataUShort(16UL, (ushort)0);
                public Cereal.UbloxGnss.HwStatus.AntennaSupervisorState AStatus => (Cereal.UbloxGnss.HwStatus.AntennaSupervisorState)ctx.ReadDataUShort(32UL, (ushort)0);
                public Cereal.UbloxGnss.HwStatus.AntennaPowerStatus APower => (Cereal.UbloxGnss.HwStatus.AntennaPowerStatus)ctx.ReadDataUShort(48UL, (ushort)0);
                public byte JamInd => ctx.ReadDataByte(64UL, (byte)0);
                public byte Flags => ctx.ReadDataByte(72UL, (byte)0);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(2, 0);
                }

                public ushort NoisePerMS
                {
                    get => this.ReadDataUShort(0UL, (ushort)0);
                    set => this.WriteData(0UL, value, (ushort)0);
                }

                public ushort AgcCnt
                {
                    get => this.ReadDataUShort(16UL, (ushort)0);
                    set => this.WriteData(16UL, value, (ushort)0);
                }

                public Cereal.UbloxGnss.HwStatus.AntennaSupervisorState AStatus
                {
                    get => (Cereal.UbloxGnss.HwStatus.AntennaSupervisorState)this.ReadDataUShort(32UL, (ushort)0);
                    set => this.WriteData(32UL, (ushort)value, (ushort)0);
                }

                public Cereal.UbloxGnss.HwStatus.AntennaPowerStatus APower
                {
                    get => (Cereal.UbloxGnss.HwStatus.AntennaPowerStatus)this.ReadDataUShort(48UL, (ushort)0);
                    set => this.WriteData(48UL, (ushort)value, (ushort)0);
                }

                public byte JamInd
                {
                    get => this.ReadDataByte(64UL, (byte)0);
                    set => this.WriteData(64UL, value, (byte)0);
                }

                public byte Flags
                {
                    get => this.ReadDataByte(72UL, (byte)0);
                    set => this.WriteData(72UL, value, (byte)0);
                }
            }

            [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xc23e1128ab4d5b53UL)]
            public enum AntennaSupervisorState : ushort
            {
                init,
                dontknow,
                ok,
                @short,
                open
            }

            [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xfe3b51a924e46559UL)]
            public enum AntennaPowerStatus : ushort
            {
                off,
                @on,
                dontknow
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xf919b410b90e53c6UL)]
        public class HwStatus2 : ICapnpSerializable
        {
            public const UInt64 typeId = 0xf919b410b90e53c6UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                OfsI = reader.OfsI;
                MagI = reader.MagI;
                OfsQ = reader.OfsQ;
                MagQ = reader.MagQ;
                CfgSource = reader.CfgSource;
                LowLevCfg = reader.LowLevCfg;
                PostStatus = reader.PostStatus;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.OfsI = OfsI;
                writer.MagI = MagI;
                writer.OfsQ = OfsQ;
                writer.MagQ = MagQ;
                writer.CfgSource = CfgSource;
                writer.LowLevCfg = LowLevCfg;
                writer.PostStatus = PostStatus;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public sbyte OfsI
            {
                get;
                set;
            }

            public byte MagI
            {
                get;
                set;
            }

            public sbyte OfsQ
            {
                get;
                set;
            }

            public byte MagQ
            {
                get;
                set;
            }

            public Cereal.UbloxGnss.HwStatus2.ConfigSource CfgSource
            {
                get;
                set;
            }

            public uint LowLevCfg
            {
                get;
                set;
            }

            public uint PostStatus
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public sbyte OfsI => ctx.ReadDataSByte(0UL, (sbyte)0);
                public byte MagI => ctx.ReadDataByte(8UL, (byte)0);
                public sbyte OfsQ => ctx.ReadDataSByte(16UL, (sbyte)0);
                public byte MagQ => ctx.ReadDataByte(24UL, (byte)0);
                public Cereal.UbloxGnss.HwStatus2.ConfigSource CfgSource => (Cereal.UbloxGnss.HwStatus2.ConfigSource)ctx.ReadDataUShort(32UL, (ushort)0);
                public uint LowLevCfg => ctx.ReadDataUInt(64UL, 0U);
                public uint PostStatus => ctx.ReadDataUInt(96UL, 0U);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(2, 0);
                }

                public sbyte OfsI
                {
                    get => this.ReadDataSByte(0UL, (sbyte)0);
                    set => this.WriteData(0UL, value, (sbyte)0);
                }

                public byte MagI
                {
                    get => this.ReadDataByte(8UL, (byte)0);
                    set => this.WriteData(8UL, value, (byte)0);
                }

                public sbyte OfsQ
                {
                    get => this.ReadDataSByte(16UL, (sbyte)0);
                    set => this.WriteData(16UL, value, (sbyte)0);
                }

                public byte MagQ
                {
                    get => this.ReadDataByte(24UL, (byte)0);
                    set => this.WriteData(24UL, value, (byte)0);
                }

                public Cereal.UbloxGnss.HwStatus2.ConfigSource CfgSource
                {
                    get => (Cereal.UbloxGnss.HwStatus2.ConfigSource)this.ReadDataUShort(32UL, (ushort)0);
                    set => this.WriteData(32UL, (ushort)value, (ushort)0);
                }

                public uint LowLevCfg
                {
                    get => this.ReadDataUInt(64UL, 0U);
                    set => this.WriteData(64UL, value, 0U);
                }

                public uint PostStatus
                {
                    get => this.ReadDataUInt(96UL, 0U);
                    set => this.WriteData(96UL, value, 0U);
                }
            }

            [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xb2d0985eb51c97b9UL)]
            public enum ConfigSource : ushort
            {
                undefined,
                rom,
                otp,
                configpins,
                flash
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xb9c5911198388e0cUL)]
        public class GlonassEphemeris : ICapnpSerializable
        {
            public const UInt64 typeId = 0xb9c5911198388e0cUL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                SvId = reader.SvId;
                Year = reader.Year;
                DayInYear = reader.DayInYear;
                Hour = reader.Hour;
                Minute = reader.Minute;
                Second = reader.Second;
                X = reader.X;
                XVel = reader.XVel;
                XAccel = reader.XAccel;
                Y = reader.Y;
                YVel = reader.YVel;
                YAccel = reader.YAccel;
                Z = reader.Z;
                ZVel = reader.ZVel;
                ZAccel = reader.ZAccel;
                SvType = reader.SvType;
                SvURA = reader.SvURA;
                Age = reader.Age;
                SvHealth = reader.SvHealth;
                TkDEPRECATED = reader.TkDEPRECATED;
                Tb = reader.Tb;
                TauN = reader.TauN;
                DeltaTauN = reader.DeltaTauN;
                GammaN = reader.GammaN;
                P1 = reader.P1;
                P2 = reader.P2;
                P3 = reader.P3;
                P4 = reader.P4;
                FreqNumDEPRECATED = reader.FreqNumDEPRECATED;
                N4 = reader.N4;
                Nt = reader.Nt;
                FreqNum = reader.FreqNum;
                TkSeconds = reader.TkSeconds;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.SvId = SvId;
                writer.Year = Year;
                writer.DayInYear = DayInYear;
                writer.Hour = Hour;
                writer.Minute = Minute;
                writer.Second = Second;
                writer.X = X;
                writer.XVel = XVel;
                writer.XAccel = XAccel;
                writer.Y = Y;
                writer.YVel = YVel;
                writer.YAccel = YAccel;
                writer.Z = Z;
                writer.ZVel = ZVel;
                writer.ZAccel = ZAccel;
                writer.SvType = SvType;
                writer.SvURA = SvURA;
                writer.Age = Age;
                writer.SvHealth = SvHealth;
                writer.TkDEPRECATED = TkDEPRECATED;
                writer.Tb = Tb;
                writer.TauN = TauN;
                writer.DeltaTauN = DeltaTauN;
                writer.GammaN = GammaN;
                writer.P1 = P1;
                writer.P2 = P2;
                writer.P3 = P3;
                writer.P4 = P4;
                writer.FreqNumDEPRECATED = FreqNumDEPRECATED;
                writer.N4 = N4;
                writer.Nt = Nt;
                writer.FreqNum = FreqNum;
                writer.TkSeconds = TkSeconds;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public ushort SvId
            {
                get;
                set;
            }

            public ushort Year
            {
                get;
                set;
            }

            public ushort DayInYear
            {
                get;
                set;
            }

            public ushort Hour
            {
                get;
                set;
            }

            public ushort Minute
            {
                get;
                set;
            }

            public float Second
            {
                get;
                set;
            }

            public double X
            {
                get;
                set;
            }

            public double XVel
            {
                get;
                set;
            }

            public double XAccel
            {
                get;
                set;
            }

            public double Y
            {
                get;
                set;
            }

            public double YVel
            {
                get;
                set;
            }

            public double YAccel
            {
                get;
                set;
            }

            public double Z
            {
                get;
                set;
            }

            public double ZVel
            {
                get;
                set;
            }

            public double ZAccel
            {
                get;
                set;
            }

            public byte SvType
            {
                get;
                set;
            }

            public float SvURA
            {
                get;
                set;
            }

            public byte Age
            {
                get;
                set;
            }

            public byte SvHealth
            {
                get;
                set;
            }

            public ushort TkDEPRECATED
            {
                get;
                set;
            }

            public ushort Tb
            {
                get;
                set;
            }

            public double TauN
            {
                get;
                set;
            }

            public double DeltaTauN
            {
                get;
                set;
            }

            public double GammaN
            {
                get;
                set;
            }

            public byte P1
            {
                get;
                set;
            }

            public byte P2
            {
                get;
                set;
            }

            public byte P3
            {
                get;
                set;
            }

            public byte P4
            {
                get;
                set;
            }

            public uint FreqNumDEPRECATED
            {
                get;
                set;
            }

            public byte N4
            {
                get;
                set;
            }

            public ushort Nt
            {
                get;
                set;
            }

            public short FreqNum
            {
                get;
                set;
            }

            public uint TkSeconds
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public ushort SvId => ctx.ReadDataUShort(0UL, (ushort)0);
                public ushort Year => ctx.ReadDataUShort(16UL, (ushort)0);
                public ushort DayInYear => ctx.ReadDataUShort(32UL, (ushort)0);
                public ushort Hour => ctx.ReadDataUShort(48UL, (ushort)0);
                public ushort Minute => ctx.ReadDataUShort(64UL, (ushort)0);
                public float Second => ctx.ReadDataFloat(96UL, 0F);
                public double X => ctx.ReadDataDouble(128UL, 0);
                public double XVel => ctx.ReadDataDouble(192UL, 0);
                public double XAccel => ctx.ReadDataDouble(256UL, 0);
                public double Y => ctx.ReadDataDouble(320UL, 0);
                public double YVel => ctx.ReadDataDouble(384UL, 0);
                public double YAccel => ctx.ReadDataDouble(448UL, 0);
                public double Z => ctx.ReadDataDouble(512UL, 0);
                public double ZVel => ctx.ReadDataDouble(576UL, 0);
                public double ZAccel => ctx.ReadDataDouble(640UL, 0);
                public byte SvType => ctx.ReadDataByte(80UL, (byte)0);
                public float SvURA => ctx.ReadDataFloat(704UL, 0F);
                public byte Age => ctx.ReadDataByte(88UL, (byte)0);
                public byte SvHealth => ctx.ReadDataByte(736UL, (byte)0);
                public ushort TkDEPRECATED => ctx.ReadDataUShort(752UL, (ushort)0);
                public ushort Tb => ctx.ReadDataUShort(768UL, (ushort)0);
                public double TauN => ctx.ReadDataDouble(832UL, 0);
                public double DeltaTauN => ctx.ReadDataDouble(896UL, 0);
                public double GammaN => ctx.ReadDataDouble(960UL, 0);
                public byte P1 => ctx.ReadDataByte(744UL, (byte)0);
                public byte P2 => ctx.ReadDataByte(784UL, (byte)0);
                public byte P3 => ctx.ReadDataByte(792UL, (byte)0);
                public byte P4 => ctx.ReadDataByte(800UL, (byte)0);
                public uint FreqNumDEPRECATED => ctx.ReadDataUInt(1024UL, 0U);
                public byte N4 => ctx.ReadDataByte(808UL, (byte)0);
                public ushort Nt => ctx.ReadDataUShort(816UL, (ushort)0);
                public short FreqNum => ctx.ReadDataShort(1056UL, (short)0);
                public uint TkSeconds => ctx.ReadDataUInt(1088UL, 0U);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(18, 0);
                }

                public ushort SvId
                {
                    get => this.ReadDataUShort(0UL, (ushort)0);
                    set => this.WriteData(0UL, value, (ushort)0);
                }

                public ushort Year
                {
                    get => this.ReadDataUShort(16UL, (ushort)0);
                    set => this.WriteData(16UL, value, (ushort)0);
                }

                public ushort DayInYear
                {
                    get => this.ReadDataUShort(32UL, (ushort)0);
                    set => this.WriteData(32UL, value, (ushort)0);
                }

                public ushort Hour
                {
                    get => this.ReadDataUShort(48UL, (ushort)0);
                    set => this.WriteData(48UL, value, (ushort)0);
                }

                public ushort Minute
                {
                    get => this.ReadDataUShort(64UL, (ushort)0);
                    set => this.WriteData(64UL, value, (ushort)0);
                }

                public float Second
                {
                    get => this.ReadDataFloat(96UL, 0F);
                    set => this.WriteData(96UL, value, 0F);
                }

                public double X
                {
                    get => this.ReadDataDouble(128UL, 0);
                    set => this.WriteData(128UL, value, 0);
                }

                public double XVel
                {
                    get => this.ReadDataDouble(192UL, 0);
                    set => this.WriteData(192UL, value, 0);
                }

                public double XAccel
                {
                    get => this.ReadDataDouble(256UL, 0);
                    set => this.WriteData(256UL, value, 0);
                }

                public double Y
                {
                    get => this.ReadDataDouble(320UL, 0);
                    set => this.WriteData(320UL, value, 0);
                }

                public double YVel
                {
                    get => this.ReadDataDouble(384UL, 0);
                    set => this.WriteData(384UL, value, 0);
                }

                public double YAccel
                {
                    get => this.ReadDataDouble(448UL, 0);
                    set => this.WriteData(448UL, value, 0);
                }

                public double Z
                {
                    get => this.ReadDataDouble(512UL, 0);
                    set => this.WriteData(512UL, value, 0);
                }

                public double ZVel
                {
                    get => this.ReadDataDouble(576UL, 0);
                    set => this.WriteData(576UL, value, 0);
                }

                public double ZAccel
                {
                    get => this.ReadDataDouble(640UL, 0);
                    set => this.WriteData(640UL, value, 0);
                }

                public byte SvType
                {
                    get => this.ReadDataByte(80UL, (byte)0);
                    set => this.WriteData(80UL, value, (byte)0);
                }

                public float SvURA
                {
                    get => this.ReadDataFloat(704UL, 0F);
                    set => this.WriteData(704UL, value, 0F);
                }

                public byte Age
                {
                    get => this.ReadDataByte(88UL, (byte)0);
                    set => this.WriteData(88UL, value, (byte)0);
                }

                public byte SvHealth
                {
                    get => this.ReadDataByte(736UL, (byte)0);
                    set => this.WriteData(736UL, value, (byte)0);
                }

                public ushort TkDEPRECATED
                {
                    get => this.ReadDataUShort(752UL, (ushort)0);
                    set => this.WriteData(752UL, value, (ushort)0);
                }

                public ushort Tb
                {
                    get => this.ReadDataUShort(768UL, (ushort)0);
                    set => this.WriteData(768UL, value, (ushort)0);
                }

                public double TauN
                {
                    get => this.ReadDataDouble(832UL, 0);
                    set => this.WriteData(832UL, value, 0);
                }

                public double DeltaTauN
                {
                    get => this.ReadDataDouble(896UL, 0);
                    set => this.WriteData(896UL, value, 0);
                }

                public double GammaN
                {
                    get => this.ReadDataDouble(960UL, 0);
                    set => this.WriteData(960UL, value, 0);
                }

                public byte P1
                {
                    get => this.ReadDataByte(744UL, (byte)0);
                    set => this.WriteData(744UL, value, (byte)0);
                }

                public byte P2
                {
                    get => this.ReadDataByte(784UL, (byte)0);
                    set => this.WriteData(784UL, value, (byte)0);
                }

                public byte P3
                {
                    get => this.ReadDataByte(792UL, (byte)0);
                    set => this.WriteData(792UL, value, (byte)0);
                }

                public byte P4
                {
                    get => this.ReadDataByte(800UL, (byte)0);
                    set => this.WriteData(800UL, value, (byte)0);
                }

                public uint FreqNumDEPRECATED
                {
                    get => this.ReadDataUInt(1024UL, 0U);
                    set => this.WriteData(1024UL, value, 0U);
                }

                public byte N4
                {
                    get => this.ReadDataByte(808UL, (byte)0);
                    set => this.WriteData(808UL, value, (byte)0);
                }

                public ushort Nt
                {
                    get => this.ReadDataUShort(816UL, (ushort)0);
                    set => this.WriteData(816UL, value, (ushort)0);
                }

                public short FreqNum
                {
                    get => this.ReadDataShort(1056UL, (short)0);
                    set => this.WriteData(1056UL, value, (short)0);
                }

                public uint TkSeconds
                {
                    get => this.ReadDataUInt(1088UL, 0U);
                    set => this.WriteData(1088UL, value, 0U);
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xde94674b07ae51c1UL)]
    public class QcomGnss : ICapnpSerializable
    {
        public const UInt64 typeId = 0xde94674b07ae51c1UL;
        public enum WHICH : ushort
        {
            TheMeasurementReport = 0,
            TheClockReport = 1,
            TheDrMeasurementReport = 2,
            DrSvPoly = 3,
            RawLog = 4,
            undefined = 65535
        }

        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            switch (reader.which)
            {
                case WHICH.TheMeasurementReport:
                    TheMeasurementReport = CapnpSerializable.Create<Cereal.QcomGnss.MeasurementReport>(reader.TheMeasurementReport);
                    break;
                case WHICH.TheClockReport:
                    TheClockReport = CapnpSerializable.Create<Cereal.QcomGnss.ClockReport>(reader.TheClockReport);
                    break;
                case WHICH.TheDrMeasurementReport:
                    TheDrMeasurementReport = CapnpSerializable.Create<Cereal.QcomGnss.DrMeasurementReport>(reader.TheDrMeasurementReport);
                    break;
                case WHICH.DrSvPoly:
                    DrSvPoly = CapnpSerializable.Create<Cereal.QcomGnss.DrSvPolyReport>(reader.DrSvPoly);
                    break;
                case WHICH.RawLog:
                    RawLog = reader.RawLog;
                    break;
            }

            LogTs = reader.LogTs;
            applyDefaults();
        }

        private WHICH _which = WHICH.undefined;
        private object _content;
        public WHICH which
        {
            get => _which;
            set
            {
                if (value == _which)
                    return;
                _which = value;
                switch (value)
                {
                    case WHICH.TheMeasurementReport:
                        _content = null;
                        break;
                    case WHICH.TheClockReport:
                        _content = null;
                        break;
                    case WHICH.TheDrMeasurementReport:
                        _content = null;
                        break;
                    case WHICH.DrSvPoly:
                        _content = null;
                        break;
                    case WHICH.RawLog:
                        _content = null;
                        break;
                }
            }
        }

        public void serialize(WRITER writer)
        {
            writer.which = which;
            switch (which)
            {
                case WHICH.TheMeasurementReport:
                    TheMeasurementReport?.serialize(writer.TheMeasurementReport);
                    break;
                case WHICH.TheClockReport:
                    TheClockReport?.serialize(writer.TheClockReport);
                    break;
                case WHICH.TheDrMeasurementReport:
                    TheDrMeasurementReport?.serialize(writer.TheDrMeasurementReport);
                    break;
                case WHICH.DrSvPoly:
                    DrSvPoly?.serialize(writer.DrSvPoly);
                    break;
                case WHICH.RawLog:
                    writer.RawLog.Init(RawLog);
                    break;
            }

            writer.LogTs = LogTs;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public ulong LogTs
        {
            get;
            set;
        }

        public Cereal.QcomGnss.MeasurementReport TheMeasurementReport
        {
            get => _which == WHICH.TheMeasurementReport ? (Cereal.QcomGnss.MeasurementReport)_content : null;
            set
            {
                _which = WHICH.TheMeasurementReport;
                _content = value;
            }
        }

        public Cereal.QcomGnss.ClockReport TheClockReport
        {
            get => _which == WHICH.TheClockReport ? (Cereal.QcomGnss.ClockReport)_content : null;
            set
            {
                _which = WHICH.TheClockReport;
                _content = value;
            }
        }

        public Cereal.QcomGnss.DrMeasurementReport TheDrMeasurementReport
        {
            get => _which == WHICH.TheDrMeasurementReport ? (Cereal.QcomGnss.DrMeasurementReport)_content : null;
            set
            {
                _which = WHICH.TheDrMeasurementReport;
                _content = value;
            }
        }

        public Cereal.QcomGnss.DrSvPolyReport DrSvPoly
        {
            get => _which == WHICH.DrSvPoly ? (Cereal.QcomGnss.DrSvPolyReport)_content : null;
            set
            {
                _which = WHICH.DrSvPoly;
                _content = value;
            }
        }

        public IReadOnlyList<byte> RawLog
        {
            get => _which == WHICH.RawLog ? (IReadOnlyList<byte>)_content : null;
            set
            {
                _which = WHICH.RawLog;
                _content = value;
            }
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public WHICH which => (WHICH)ctx.ReadDataUShort(64U, (ushort)0);
            public ulong LogTs => ctx.ReadDataULong(0UL, 0UL);
            public Cereal.QcomGnss.MeasurementReport.READER TheMeasurementReport => which == WHICH.TheMeasurementReport ? ctx.ReadStruct(0, Cereal.QcomGnss.MeasurementReport.READER.create) : default;
            public Cereal.QcomGnss.ClockReport.READER TheClockReport => which == WHICH.TheClockReport ? ctx.ReadStruct(0, Cereal.QcomGnss.ClockReport.READER.create) : default;
            public Cereal.QcomGnss.DrMeasurementReport.READER TheDrMeasurementReport => which == WHICH.TheDrMeasurementReport ? ctx.ReadStruct(0, Cereal.QcomGnss.DrMeasurementReport.READER.create) : default;
            public Cereal.QcomGnss.DrSvPolyReport.READER DrSvPoly => which == WHICH.DrSvPoly ? ctx.ReadStruct(0, Cereal.QcomGnss.DrSvPolyReport.READER.create) : default;
            public IReadOnlyList<byte> RawLog => which == WHICH.RawLog ? ctx.ReadList(0).CastByte() : default;
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(2, 1);
            }

            public WHICH which
            {
                get => (WHICH)this.ReadDataUShort(64U, (ushort)0);
                set => this.WriteData(64U, (ushort)value, (ushort)0);
            }

            public ulong LogTs
            {
                get => this.ReadDataULong(0UL, 0UL);
                set => this.WriteData(0UL, value, 0UL);
            }

            public Cereal.QcomGnss.MeasurementReport.WRITER TheMeasurementReport
            {
                get => which == WHICH.TheMeasurementReport ? BuildPointer<Cereal.QcomGnss.MeasurementReport.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.QcomGnss.ClockReport.WRITER TheClockReport
            {
                get => which == WHICH.TheClockReport ? BuildPointer<Cereal.QcomGnss.ClockReport.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.QcomGnss.DrMeasurementReport.WRITER TheDrMeasurementReport
            {
                get => which == WHICH.TheDrMeasurementReport ? BuildPointer<Cereal.QcomGnss.DrMeasurementReport.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.QcomGnss.DrSvPolyReport.WRITER DrSvPoly
            {
                get => which == WHICH.DrSvPoly ? BuildPointer<Cereal.QcomGnss.DrSvPolyReport.WRITER>(0) : default;
                set => Link(0, value);
            }

            public ListOfPrimitivesSerializer<byte> RawLog
            {
                get => which == WHICH.RawLog ? BuildPointer<ListOfPrimitivesSerializer<byte>>(0) : default;
                set => Link(0, value);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xd71a12b6faada7eeUL)]
        public enum MeasurementSource : ushort
        {
            gps,
            glonass,
            beidou,
            unknown3,
            unknown4,
            unknown5,
            sbas
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xe81e829a0d6c83e9UL)]
        public enum SVObservationState : ushort
        {
            idle,
            search,
            searchVerify,
            bitEdge,
            trackVerify,
            track,
            restart,
            dpo,
            glo10msBe,
            glo10msAt
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xe501010e1bcae83bUL)]
        public class MeasurementStatus : ICapnpSerializable
        {
            public const UInt64 typeId = 0xe501010e1bcae83bUL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                SubMillisecondIsValid = reader.SubMillisecondIsValid;
                SubBitTimeIsKnown = reader.SubBitTimeIsKnown;
                SatelliteTimeIsKnown = reader.SatelliteTimeIsKnown;
                BitEdgeConfirmedFromSignal = reader.BitEdgeConfirmedFromSignal;
                MeasuredVelocity = reader.MeasuredVelocity;
                FineOrCoarseVelocity = reader.FineOrCoarseVelocity;
                LockPointValid = reader.LockPointValid;
                LockPointPositive = reader.LockPointPositive;
                LastUpdateFromDifference = reader.LastUpdateFromDifference;
                LastUpdateFromVelocityDifference = reader.LastUpdateFromVelocityDifference;
                StrongIndicationOfCrossCorelation = reader.StrongIndicationOfCrossCorelation;
                TentativeMeasurement = reader.TentativeMeasurement;
                MeasurementNotUsable = reader.MeasurementNotUsable;
                SirCheckIsNeeded = reader.SirCheckIsNeeded;
                ProbationMode = reader.ProbationMode;
                GlonassMeanderBitEdgeValid = reader.GlonassMeanderBitEdgeValid;
                GlonassTimeMarkValid = reader.GlonassTimeMarkValid;
                GpsRoundRobinRxDiversity = reader.GpsRoundRobinRxDiversity;
                GpsRxDiversity = reader.GpsRxDiversity;
                GpsLowBandwidthRxDiversityCombined = reader.GpsLowBandwidthRxDiversityCombined;
                GpsHighBandwidthNu4 = reader.GpsHighBandwidthNu4;
                GpsHighBandwidthNu8 = reader.GpsHighBandwidthNu8;
                GpsHighBandwidthUniform = reader.GpsHighBandwidthUniform;
                MultipathIndicator = reader.MultipathIndicator;
                ImdJammingIndicator = reader.ImdJammingIndicator;
                LteB13TxJammingIndicator = reader.LteB13TxJammingIndicator;
                FreshMeasurementIndicator = reader.FreshMeasurementIndicator;
                MultipathEstimateIsValid = reader.MultipathEstimateIsValid;
                DirectionIsValid = reader.DirectionIsValid;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.SubMillisecondIsValid = SubMillisecondIsValid;
                writer.SubBitTimeIsKnown = SubBitTimeIsKnown;
                writer.SatelliteTimeIsKnown = SatelliteTimeIsKnown;
                writer.BitEdgeConfirmedFromSignal = BitEdgeConfirmedFromSignal;
                writer.MeasuredVelocity = MeasuredVelocity;
                writer.FineOrCoarseVelocity = FineOrCoarseVelocity;
                writer.LockPointValid = LockPointValid;
                writer.LockPointPositive = LockPointPositive;
                writer.LastUpdateFromDifference = LastUpdateFromDifference;
                writer.LastUpdateFromVelocityDifference = LastUpdateFromVelocityDifference;
                writer.StrongIndicationOfCrossCorelation = StrongIndicationOfCrossCorelation;
                writer.TentativeMeasurement = TentativeMeasurement;
                writer.MeasurementNotUsable = MeasurementNotUsable;
                writer.SirCheckIsNeeded = SirCheckIsNeeded;
                writer.ProbationMode = ProbationMode;
                writer.GlonassMeanderBitEdgeValid = GlonassMeanderBitEdgeValid;
                writer.GlonassTimeMarkValid = GlonassTimeMarkValid;
                writer.GpsRoundRobinRxDiversity = GpsRoundRobinRxDiversity;
                writer.GpsRxDiversity = GpsRxDiversity;
                writer.GpsLowBandwidthRxDiversityCombined = GpsLowBandwidthRxDiversityCombined;
                writer.GpsHighBandwidthNu4 = GpsHighBandwidthNu4;
                writer.GpsHighBandwidthNu8 = GpsHighBandwidthNu8;
                writer.GpsHighBandwidthUniform = GpsHighBandwidthUniform;
                writer.MultipathIndicator = MultipathIndicator;
                writer.ImdJammingIndicator = ImdJammingIndicator;
                writer.LteB13TxJammingIndicator = LteB13TxJammingIndicator;
                writer.FreshMeasurementIndicator = FreshMeasurementIndicator;
                writer.MultipathEstimateIsValid = MultipathEstimateIsValid;
                writer.DirectionIsValid = DirectionIsValid;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public bool SubMillisecondIsValid
            {
                get;
                set;
            }

            public bool SubBitTimeIsKnown
            {
                get;
                set;
            }

            public bool SatelliteTimeIsKnown
            {
                get;
                set;
            }

            public bool BitEdgeConfirmedFromSignal
            {
                get;
                set;
            }

            public bool MeasuredVelocity
            {
                get;
                set;
            }

            public bool FineOrCoarseVelocity
            {
                get;
                set;
            }

            public bool LockPointValid
            {
                get;
                set;
            }

            public bool LockPointPositive
            {
                get;
                set;
            }

            public bool LastUpdateFromDifference
            {
                get;
                set;
            }

            public bool LastUpdateFromVelocityDifference
            {
                get;
                set;
            }

            public bool StrongIndicationOfCrossCorelation
            {
                get;
                set;
            }

            public bool TentativeMeasurement
            {
                get;
                set;
            }

            public bool MeasurementNotUsable
            {
                get;
                set;
            }

            public bool SirCheckIsNeeded
            {
                get;
                set;
            }

            public bool ProbationMode
            {
                get;
                set;
            }

            public bool GlonassMeanderBitEdgeValid
            {
                get;
                set;
            }

            public bool GlonassTimeMarkValid
            {
                get;
                set;
            }

            public bool GpsRoundRobinRxDiversity
            {
                get;
                set;
            }

            public bool GpsRxDiversity
            {
                get;
                set;
            }

            public bool GpsLowBandwidthRxDiversityCombined
            {
                get;
                set;
            }

            public bool GpsHighBandwidthNu4
            {
                get;
                set;
            }

            public bool GpsHighBandwidthNu8
            {
                get;
                set;
            }

            public bool GpsHighBandwidthUniform
            {
                get;
                set;
            }

            public bool MultipathIndicator
            {
                get;
                set;
            }

            public bool ImdJammingIndicator
            {
                get;
                set;
            }

            public bool LteB13TxJammingIndicator
            {
                get;
                set;
            }

            public bool FreshMeasurementIndicator
            {
                get;
                set;
            }

            public bool MultipathEstimateIsValid
            {
                get;
                set;
            }

            public bool DirectionIsValid
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public bool SubMillisecondIsValid => ctx.ReadDataBool(0UL, false);
                public bool SubBitTimeIsKnown => ctx.ReadDataBool(1UL, false);
                public bool SatelliteTimeIsKnown => ctx.ReadDataBool(2UL, false);
                public bool BitEdgeConfirmedFromSignal => ctx.ReadDataBool(3UL, false);
                public bool MeasuredVelocity => ctx.ReadDataBool(4UL, false);
                public bool FineOrCoarseVelocity => ctx.ReadDataBool(5UL, false);
                public bool LockPointValid => ctx.ReadDataBool(6UL, false);
                public bool LockPointPositive => ctx.ReadDataBool(7UL, false);
                public bool LastUpdateFromDifference => ctx.ReadDataBool(8UL, false);
                public bool LastUpdateFromVelocityDifference => ctx.ReadDataBool(9UL, false);
                public bool StrongIndicationOfCrossCorelation => ctx.ReadDataBool(10UL, false);
                public bool TentativeMeasurement => ctx.ReadDataBool(11UL, false);
                public bool MeasurementNotUsable => ctx.ReadDataBool(12UL, false);
                public bool SirCheckIsNeeded => ctx.ReadDataBool(13UL, false);
                public bool ProbationMode => ctx.ReadDataBool(14UL, false);
                public bool GlonassMeanderBitEdgeValid => ctx.ReadDataBool(15UL, false);
                public bool GlonassTimeMarkValid => ctx.ReadDataBool(16UL, false);
                public bool GpsRoundRobinRxDiversity => ctx.ReadDataBool(17UL, false);
                public bool GpsRxDiversity => ctx.ReadDataBool(18UL, false);
                public bool GpsLowBandwidthRxDiversityCombined => ctx.ReadDataBool(19UL, false);
                public bool GpsHighBandwidthNu4 => ctx.ReadDataBool(20UL, false);
                public bool GpsHighBandwidthNu8 => ctx.ReadDataBool(21UL, false);
                public bool GpsHighBandwidthUniform => ctx.ReadDataBool(22UL, false);
                public bool MultipathIndicator => ctx.ReadDataBool(23UL, false);
                public bool ImdJammingIndicator => ctx.ReadDataBool(24UL, false);
                public bool LteB13TxJammingIndicator => ctx.ReadDataBool(25UL, false);
                public bool FreshMeasurementIndicator => ctx.ReadDataBool(26UL, false);
                public bool MultipathEstimateIsValid => ctx.ReadDataBool(27UL, false);
                public bool DirectionIsValid => ctx.ReadDataBool(28UL, false);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(1, 0);
                }

                public bool SubMillisecondIsValid
                {
                    get => this.ReadDataBool(0UL, false);
                    set => this.WriteData(0UL, value, false);
                }

                public bool SubBitTimeIsKnown
                {
                    get => this.ReadDataBool(1UL, false);
                    set => this.WriteData(1UL, value, false);
                }

                public bool SatelliteTimeIsKnown
                {
                    get => this.ReadDataBool(2UL, false);
                    set => this.WriteData(2UL, value, false);
                }

                public bool BitEdgeConfirmedFromSignal
                {
                    get => this.ReadDataBool(3UL, false);
                    set => this.WriteData(3UL, value, false);
                }

                public bool MeasuredVelocity
                {
                    get => this.ReadDataBool(4UL, false);
                    set => this.WriteData(4UL, value, false);
                }

                public bool FineOrCoarseVelocity
                {
                    get => this.ReadDataBool(5UL, false);
                    set => this.WriteData(5UL, value, false);
                }

                public bool LockPointValid
                {
                    get => this.ReadDataBool(6UL, false);
                    set => this.WriteData(6UL, value, false);
                }

                public bool LockPointPositive
                {
                    get => this.ReadDataBool(7UL, false);
                    set => this.WriteData(7UL, value, false);
                }

                public bool LastUpdateFromDifference
                {
                    get => this.ReadDataBool(8UL, false);
                    set => this.WriteData(8UL, value, false);
                }

                public bool LastUpdateFromVelocityDifference
                {
                    get => this.ReadDataBool(9UL, false);
                    set => this.WriteData(9UL, value, false);
                }

                public bool StrongIndicationOfCrossCorelation
                {
                    get => this.ReadDataBool(10UL, false);
                    set => this.WriteData(10UL, value, false);
                }

                public bool TentativeMeasurement
                {
                    get => this.ReadDataBool(11UL, false);
                    set => this.WriteData(11UL, value, false);
                }

                public bool MeasurementNotUsable
                {
                    get => this.ReadDataBool(12UL, false);
                    set => this.WriteData(12UL, value, false);
                }

                public bool SirCheckIsNeeded
                {
                    get => this.ReadDataBool(13UL, false);
                    set => this.WriteData(13UL, value, false);
                }

                public bool ProbationMode
                {
                    get => this.ReadDataBool(14UL, false);
                    set => this.WriteData(14UL, value, false);
                }

                public bool GlonassMeanderBitEdgeValid
                {
                    get => this.ReadDataBool(15UL, false);
                    set => this.WriteData(15UL, value, false);
                }

                public bool GlonassTimeMarkValid
                {
                    get => this.ReadDataBool(16UL, false);
                    set => this.WriteData(16UL, value, false);
                }

                public bool GpsRoundRobinRxDiversity
                {
                    get => this.ReadDataBool(17UL, false);
                    set => this.WriteData(17UL, value, false);
                }

                public bool GpsRxDiversity
                {
                    get => this.ReadDataBool(18UL, false);
                    set => this.WriteData(18UL, value, false);
                }

                public bool GpsLowBandwidthRxDiversityCombined
                {
                    get => this.ReadDataBool(19UL, false);
                    set => this.WriteData(19UL, value, false);
                }

                public bool GpsHighBandwidthNu4
                {
                    get => this.ReadDataBool(20UL, false);
                    set => this.WriteData(20UL, value, false);
                }

                public bool GpsHighBandwidthNu8
                {
                    get => this.ReadDataBool(21UL, false);
                    set => this.WriteData(21UL, value, false);
                }

                public bool GpsHighBandwidthUniform
                {
                    get => this.ReadDataBool(22UL, false);
                    set => this.WriteData(22UL, value, false);
                }

                public bool MultipathIndicator
                {
                    get => this.ReadDataBool(23UL, false);
                    set => this.WriteData(23UL, value, false);
                }

                public bool ImdJammingIndicator
                {
                    get => this.ReadDataBool(24UL, false);
                    set => this.WriteData(24UL, value, false);
                }

                public bool LteB13TxJammingIndicator
                {
                    get => this.ReadDataBool(25UL, false);
                    set => this.WriteData(25UL, value, false);
                }

                public bool FreshMeasurementIndicator
                {
                    get => this.ReadDataBool(26UL, false);
                    set => this.WriteData(26UL, value, false);
                }

                public bool MultipathEstimateIsValid
                {
                    get => this.ReadDataBool(27UL, false);
                    set => this.WriteData(27UL, value, false);
                }

                public bool DirectionIsValid
                {
                    get => this.ReadDataBool(28UL, false);
                    set => this.WriteData(28UL, value, false);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xf580d7d86b7b8692UL)]
        public class MeasurementReport : ICapnpSerializable
        {
            public const UInt64 typeId = 0xf580d7d86b7b8692UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Source = reader.Source;
                FCount = reader.FCount;
                GpsWeek = reader.GpsWeek;
                GlonassCycleNumber = reader.GlonassCycleNumber;
                GlonassNumberOfDays = reader.GlonassNumberOfDays;
                Milliseconds = reader.Milliseconds;
                TimeBias = reader.TimeBias;
                ClockTimeUncertainty = reader.ClockTimeUncertainty;
                ClockFrequencyBias = reader.ClockFrequencyBias;
                ClockFrequencyUncertainty = reader.ClockFrequencyUncertainty;
                Sv = reader.Sv?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.QcomGnss.MeasurementReport.SV>(_));
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Source = Source;
                writer.FCount = FCount;
                writer.GpsWeek = GpsWeek;
                writer.GlonassCycleNumber = GlonassCycleNumber;
                writer.GlonassNumberOfDays = GlonassNumberOfDays;
                writer.Milliseconds = Milliseconds;
                writer.TimeBias = TimeBias;
                writer.ClockTimeUncertainty = ClockTimeUncertainty;
                writer.ClockFrequencyBias = ClockFrequencyBias;
                writer.ClockFrequencyUncertainty = ClockFrequencyUncertainty;
                writer.Sv.Init(Sv, (_s1, _v1) => _v1?.serialize(_s1));
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public Cereal.QcomGnss.MeasurementSource Source
            {
                get;
                set;
            }

            public uint FCount
            {
                get;
                set;
            }

            public ushort GpsWeek
            {
                get;
                set;
            }

            public byte GlonassCycleNumber
            {
                get;
                set;
            }

            public ushort GlonassNumberOfDays
            {
                get;
                set;
            }

            public uint Milliseconds
            {
                get;
                set;
            }

            public float TimeBias
            {
                get;
                set;
            }

            public float ClockTimeUncertainty
            {
                get;
                set;
            }

            public float ClockFrequencyBias
            {
                get;
                set;
            }

            public float ClockFrequencyUncertainty
            {
                get;
                set;
            }

            public IReadOnlyList<Cereal.QcomGnss.MeasurementReport.SV> Sv
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public Cereal.QcomGnss.MeasurementSource Source => (Cereal.QcomGnss.MeasurementSource)ctx.ReadDataUShort(0UL, (ushort)0);
                public uint FCount => ctx.ReadDataUInt(32UL, 0U);
                public ushort GpsWeek => ctx.ReadDataUShort(16UL, (ushort)0);
                public byte GlonassCycleNumber => ctx.ReadDataByte(64UL, (byte)0);
                public ushort GlonassNumberOfDays => ctx.ReadDataUShort(80UL, (ushort)0);
                public uint Milliseconds => ctx.ReadDataUInt(96UL, 0U);
                public float TimeBias => ctx.ReadDataFloat(128UL, 0F);
                public float ClockTimeUncertainty => ctx.ReadDataFloat(160UL, 0F);
                public float ClockFrequencyBias => ctx.ReadDataFloat(192UL, 0F);
                public float ClockFrequencyUncertainty => ctx.ReadDataFloat(224UL, 0F);
                public IReadOnlyList<Cereal.QcomGnss.MeasurementReport.SV.READER> Sv => ctx.ReadList(0).Cast(Cereal.QcomGnss.MeasurementReport.SV.READER.create);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(4, 1);
                }

                public Cereal.QcomGnss.MeasurementSource Source
                {
                    get => (Cereal.QcomGnss.MeasurementSource)this.ReadDataUShort(0UL, (ushort)0);
                    set => this.WriteData(0UL, (ushort)value, (ushort)0);
                }

                public uint FCount
                {
                    get => this.ReadDataUInt(32UL, 0U);
                    set => this.WriteData(32UL, value, 0U);
                }

                public ushort GpsWeek
                {
                    get => this.ReadDataUShort(16UL, (ushort)0);
                    set => this.WriteData(16UL, value, (ushort)0);
                }

                public byte GlonassCycleNumber
                {
                    get => this.ReadDataByte(64UL, (byte)0);
                    set => this.WriteData(64UL, value, (byte)0);
                }

                public ushort GlonassNumberOfDays
                {
                    get => this.ReadDataUShort(80UL, (ushort)0);
                    set => this.WriteData(80UL, value, (ushort)0);
                }

                public uint Milliseconds
                {
                    get => this.ReadDataUInt(96UL, 0U);
                    set => this.WriteData(96UL, value, 0U);
                }

                public float TimeBias
                {
                    get => this.ReadDataFloat(128UL, 0F);
                    set => this.WriteData(128UL, value, 0F);
                }

                public float ClockTimeUncertainty
                {
                    get => this.ReadDataFloat(160UL, 0F);
                    set => this.WriteData(160UL, value, 0F);
                }

                public float ClockFrequencyBias
                {
                    get => this.ReadDataFloat(192UL, 0F);
                    set => this.WriteData(192UL, value, 0F);
                }

                public float ClockFrequencyUncertainty
                {
                    get => this.ReadDataFloat(224UL, 0F);
                    set => this.WriteData(224UL, value, 0F);
                }

                public ListOfStructsSerializer<Cereal.QcomGnss.MeasurementReport.SV.WRITER> Sv
                {
                    get => BuildPointer<ListOfStructsSerializer<Cereal.QcomGnss.MeasurementReport.SV.WRITER>>(0);
                    set => Link(0, value);
                }
            }

            [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xf10c595ae7bb2c27UL)]
            public class SV : ICapnpSerializable
            {
                public const UInt64 typeId = 0xf10c595ae7bb2c27UL;
                void ICapnpSerializable.Deserialize(DeserializerState arg_)
                {
                    var reader = READER.create(arg_);
                    SvId = reader.SvId;
                    GlonassFrequencyIndex = reader.GlonassFrequencyIndex;
                    ObservationState = reader.ObservationState;
                    Observations = reader.Observations;
                    GoodObservations = reader.GoodObservations;
                    GpsParityErrorCount = reader.GpsParityErrorCount;
                    GlonassHemmingErrorCount = reader.GlonassHemmingErrorCount;
                    FilterStages = reader.FilterStages;
                    CarrierNoise = reader.CarrierNoise;
                    Latency = reader.Latency;
                    PredetectInterval = reader.PredetectInterval;
                    Postdetections = reader.Postdetections;
                    UnfilteredMeasurementIntegral = reader.UnfilteredMeasurementIntegral;
                    UnfilteredMeasurementFraction = reader.UnfilteredMeasurementFraction;
                    UnfilteredTimeUncertainty = reader.UnfilteredTimeUncertainty;
                    UnfilteredSpeed = reader.UnfilteredSpeed;
                    UnfilteredSpeedUncertainty = reader.UnfilteredSpeedUncertainty;
                    MeasurementStatus = CapnpSerializable.Create<Cereal.QcomGnss.MeasurementStatus>(reader.MeasurementStatus);
                    MultipathEstimate = reader.MultipathEstimate;
                    Azimuth = reader.Azimuth;
                    Elevation = reader.Elevation;
                    CarrierPhaseCyclesIntegral = reader.CarrierPhaseCyclesIntegral;
                    CarrierPhaseCyclesFraction = reader.CarrierPhaseCyclesFraction;
                    FineSpeed = reader.FineSpeed;
                    FineSpeedUncertainty = reader.FineSpeedUncertainty;
                    CycleSlipCount = reader.CycleSlipCount;
                    applyDefaults();
                }

                public void serialize(WRITER writer)
                {
                    writer.SvId = SvId;
                    writer.GlonassFrequencyIndex = GlonassFrequencyIndex;
                    writer.ObservationState = ObservationState;
                    writer.Observations = Observations;
                    writer.GoodObservations = GoodObservations;
                    writer.GpsParityErrorCount = GpsParityErrorCount;
                    writer.GlonassHemmingErrorCount = GlonassHemmingErrorCount;
                    writer.FilterStages = FilterStages;
                    writer.CarrierNoise = CarrierNoise;
                    writer.Latency = Latency;
                    writer.PredetectInterval = PredetectInterval;
                    writer.Postdetections = Postdetections;
                    writer.UnfilteredMeasurementIntegral = UnfilteredMeasurementIntegral;
                    writer.UnfilteredMeasurementFraction = UnfilteredMeasurementFraction;
                    writer.UnfilteredTimeUncertainty = UnfilteredTimeUncertainty;
                    writer.UnfilteredSpeed = UnfilteredSpeed;
                    writer.UnfilteredSpeedUncertainty = UnfilteredSpeedUncertainty;
                    MeasurementStatus?.serialize(writer.MeasurementStatus);
                    writer.MultipathEstimate = MultipathEstimate;
                    writer.Azimuth = Azimuth;
                    writer.Elevation = Elevation;
                    writer.CarrierPhaseCyclesIntegral = CarrierPhaseCyclesIntegral;
                    writer.CarrierPhaseCyclesFraction = CarrierPhaseCyclesFraction;
                    writer.FineSpeed = FineSpeed;
                    writer.FineSpeedUncertainty = FineSpeedUncertainty;
                    writer.CycleSlipCount = CycleSlipCount;
                }

                void ICapnpSerializable.Serialize(SerializerState arg_)
                {
                    serialize(arg_.Rewrap<WRITER>());
                }

                public void applyDefaults()
                {
                }

                public byte SvId
                {
                    get;
                    set;
                }

                public sbyte GlonassFrequencyIndex
                {
                    get;
                    set;
                }

                public Cereal.QcomGnss.SVObservationState ObservationState
                {
                    get;
                    set;
                }

                public byte Observations
                {
                    get;
                    set;
                }

                public byte GoodObservations
                {
                    get;
                    set;
                }

                public ushort GpsParityErrorCount
                {
                    get;
                    set;
                }

                public byte GlonassHemmingErrorCount
                {
                    get;
                    set;
                }

                public byte FilterStages
                {
                    get;
                    set;
                }

                public ushort CarrierNoise
                {
                    get;
                    set;
                }

                public short Latency
                {
                    get;
                    set;
                }

                public byte PredetectInterval
                {
                    get;
                    set;
                }

                public ushort Postdetections
                {
                    get;
                    set;
                }

                public uint UnfilteredMeasurementIntegral
                {
                    get;
                    set;
                }

                public float UnfilteredMeasurementFraction
                {
                    get;
                    set;
                }

                public float UnfilteredTimeUncertainty
                {
                    get;
                    set;
                }

                public float UnfilteredSpeed
                {
                    get;
                    set;
                }

                public float UnfilteredSpeedUncertainty
                {
                    get;
                    set;
                }

                public Cereal.QcomGnss.MeasurementStatus MeasurementStatus
                {
                    get;
                    set;
                }

                public uint MultipathEstimate
                {
                    get;
                    set;
                }

                public float Azimuth
                {
                    get;
                    set;
                }

                public float Elevation
                {
                    get;
                    set;
                }

                public int CarrierPhaseCyclesIntegral
                {
                    get;
                    set;
                }

                public ushort CarrierPhaseCyclesFraction
                {
                    get;
                    set;
                }

                public float FineSpeed
                {
                    get;
                    set;
                }

                public float FineSpeedUncertainty
                {
                    get;
                    set;
                }

                public byte CycleSlipCount
                {
                    get;
                    set;
                }

                public struct READER
                {
                    readonly DeserializerState ctx;
                    public READER(DeserializerState ctx)
                    {
                        this.ctx = ctx;
                    }

                    public static READER create(DeserializerState ctx) => new READER(ctx);
                    public static implicit operator DeserializerState(READER reader) => reader.ctx;
                    public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                    public byte SvId => ctx.ReadDataByte(0UL, (byte)0);
                    public sbyte GlonassFrequencyIndex => ctx.ReadDataSByte(8UL, (sbyte)0);
                    public Cereal.QcomGnss.SVObservationState ObservationState => (Cereal.QcomGnss.SVObservationState)ctx.ReadDataUShort(16UL, (ushort)0);
                    public byte Observations => ctx.ReadDataByte(32UL, (byte)0);
                    public byte GoodObservations => ctx.ReadDataByte(40UL, (byte)0);
                    public ushort GpsParityErrorCount => ctx.ReadDataUShort(48UL, (ushort)0);
                    public byte GlonassHemmingErrorCount => ctx.ReadDataByte(64UL, (byte)0);
                    public byte FilterStages => ctx.ReadDataByte(72UL, (byte)0);
                    public ushort CarrierNoise => ctx.ReadDataUShort(80UL, (ushort)0);
                    public short Latency => ctx.ReadDataShort(96UL, (short)0);
                    public byte PredetectInterval => ctx.ReadDataByte(112UL, (byte)0);
                    public ushort Postdetections => ctx.ReadDataUShort(128UL, (ushort)0);
                    public uint UnfilteredMeasurementIntegral => ctx.ReadDataUInt(160UL, 0U);
                    public float UnfilteredMeasurementFraction => ctx.ReadDataFloat(192UL, 0F);
                    public float UnfilteredTimeUncertainty => ctx.ReadDataFloat(224UL, 0F);
                    public float UnfilteredSpeed => ctx.ReadDataFloat(256UL, 0F);
                    public float UnfilteredSpeedUncertainty => ctx.ReadDataFloat(288UL, 0F);
                    public Cereal.QcomGnss.MeasurementStatus.READER MeasurementStatus => ctx.ReadStruct(0, Cereal.QcomGnss.MeasurementStatus.READER.create);
                    public uint MultipathEstimate => ctx.ReadDataUInt(320UL, 0U);
                    public float Azimuth => ctx.ReadDataFloat(352UL, 0F);
                    public float Elevation => ctx.ReadDataFloat(384UL, 0F);
                    public int CarrierPhaseCyclesIntegral => ctx.ReadDataInt(416UL, 0);
                    public ushort CarrierPhaseCyclesFraction => ctx.ReadDataUShort(144UL, (ushort)0);
                    public float FineSpeed => ctx.ReadDataFloat(448UL, 0F);
                    public float FineSpeedUncertainty => ctx.ReadDataFloat(480UL, 0F);
                    public byte CycleSlipCount => ctx.ReadDataByte(120UL, (byte)0);
                }

                public class WRITER : SerializerState
                {
                    public WRITER()
                    {
                        this.SetStruct(8, 1);
                    }

                    public byte SvId
                    {
                        get => this.ReadDataByte(0UL, (byte)0);
                        set => this.WriteData(0UL, value, (byte)0);
                    }

                    public sbyte GlonassFrequencyIndex
                    {
                        get => this.ReadDataSByte(8UL, (sbyte)0);
                        set => this.WriteData(8UL, value, (sbyte)0);
                    }

                    public Cereal.QcomGnss.SVObservationState ObservationState
                    {
                        get => (Cereal.QcomGnss.SVObservationState)this.ReadDataUShort(16UL, (ushort)0);
                        set => this.WriteData(16UL, (ushort)value, (ushort)0);
                    }

                    public byte Observations
                    {
                        get => this.ReadDataByte(32UL, (byte)0);
                        set => this.WriteData(32UL, value, (byte)0);
                    }

                    public byte GoodObservations
                    {
                        get => this.ReadDataByte(40UL, (byte)0);
                        set => this.WriteData(40UL, value, (byte)0);
                    }

                    public ushort GpsParityErrorCount
                    {
                        get => this.ReadDataUShort(48UL, (ushort)0);
                        set => this.WriteData(48UL, value, (ushort)0);
                    }

                    public byte GlonassHemmingErrorCount
                    {
                        get => this.ReadDataByte(64UL, (byte)0);
                        set => this.WriteData(64UL, value, (byte)0);
                    }

                    public byte FilterStages
                    {
                        get => this.ReadDataByte(72UL, (byte)0);
                        set => this.WriteData(72UL, value, (byte)0);
                    }

                    public ushort CarrierNoise
                    {
                        get => this.ReadDataUShort(80UL, (ushort)0);
                        set => this.WriteData(80UL, value, (ushort)0);
                    }

                    public short Latency
                    {
                        get => this.ReadDataShort(96UL, (short)0);
                        set => this.WriteData(96UL, value, (short)0);
                    }

                    public byte PredetectInterval
                    {
                        get => this.ReadDataByte(112UL, (byte)0);
                        set => this.WriteData(112UL, value, (byte)0);
                    }

                    public ushort Postdetections
                    {
                        get => this.ReadDataUShort(128UL, (ushort)0);
                        set => this.WriteData(128UL, value, (ushort)0);
                    }

                    public uint UnfilteredMeasurementIntegral
                    {
                        get => this.ReadDataUInt(160UL, 0U);
                        set => this.WriteData(160UL, value, 0U);
                    }

                    public float UnfilteredMeasurementFraction
                    {
                        get => this.ReadDataFloat(192UL, 0F);
                        set => this.WriteData(192UL, value, 0F);
                    }

                    public float UnfilteredTimeUncertainty
                    {
                        get => this.ReadDataFloat(224UL, 0F);
                        set => this.WriteData(224UL, value, 0F);
                    }

                    public float UnfilteredSpeed
                    {
                        get => this.ReadDataFloat(256UL, 0F);
                        set => this.WriteData(256UL, value, 0F);
                    }

                    public float UnfilteredSpeedUncertainty
                    {
                        get => this.ReadDataFloat(288UL, 0F);
                        set => this.WriteData(288UL, value, 0F);
                    }

                    public Cereal.QcomGnss.MeasurementStatus.WRITER MeasurementStatus
                    {
                        get => BuildPointer<Cereal.QcomGnss.MeasurementStatus.WRITER>(0);
                        set => Link(0, value);
                    }

                    public uint MultipathEstimate
                    {
                        get => this.ReadDataUInt(320UL, 0U);
                        set => this.WriteData(320UL, value, 0U);
                    }

                    public float Azimuth
                    {
                        get => this.ReadDataFloat(352UL, 0F);
                        set => this.WriteData(352UL, value, 0F);
                    }

                    public float Elevation
                    {
                        get => this.ReadDataFloat(384UL, 0F);
                        set => this.WriteData(384UL, value, 0F);
                    }

                    public int CarrierPhaseCyclesIntegral
                    {
                        get => this.ReadDataInt(416UL, 0);
                        set => this.WriteData(416UL, value, 0);
                    }

                    public ushort CarrierPhaseCyclesFraction
                    {
                        get => this.ReadDataUShort(144UL, (ushort)0);
                        set => this.WriteData(144UL, value, (ushort)0);
                    }

                    public float FineSpeed
                    {
                        get => this.ReadDataFloat(448UL, 0F);
                        set => this.WriteData(448UL, value, 0F);
                    }

                    public float FineSpeedUncertainty
                    {
                        get => this.ReadDataFloat(480UL, 0F);
                        set => this.WriteData(480UL, value, 0F);
                    }

                    public byte CycleSlipCount
                    {
                        get => this.ReadDataByte(120UL, (byte)0);
                        set => this.WriteData(120UL, value, (byte)0);
                    }
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xca965e4add8f4f0bUL)]
        public class ClockReport : ICapnpSerializable
        {
            public const UInt64 typeId = 0xca965e4add8f4f0bUL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                HasFCount = reader.HasFCount;
                FCount = reader.FCount;
                HasGpsWeek = reader.HasGpsWeek;
                GpsWeek = reader.GpsWeek;
                HasGpsMilliseconds = reader.HasGpsMilliseconds;
                GpsMilliseconds = reader.GpsMilliseconds;
                GpsTimeBias = reader.GpsTimeBias;
                GpsClockTimeUncertainty = reader.GpsClockTimeUncertainty;
                GpsClockSource = reader.GpsClockSource;
                HasGlonassYear = reader.HasGlonassYear;
                GlonassYear = reader.GlonassYear;
                HasGlonassDay = reader.HasGlonassDay;
                GlonassDay = reader.GlonassDay;
                HasGlonassMilliseconds = reader.HasGlonassMilliseconds;
                GlonassMilliseconds = reader.GlonassMilliseconds;
                GlonassTimeBias = reader.GlonassTimeBias;
                GlonassClockTimeUncertainty = reader.GlonassClockTimeUncertainty;
                GlonassClockSource = reader.GlonassClockSource;
                BdsWeek = reader.BdsWeek;
                BdsMilliseconds = reader.BdsMilliseconds;
                BdsTimeBias = reader.BdsTimeBias;
                BdsClockTimeUncertainty = reader.BdsClockTimeUncertainty;
                BdsClockSource = reader.BdsClockSource;
                GalWeek = reader.GalWeek;
                GalMilliseconds = reader.GalMilliseconds;
                GalTimeBias = reader.GalTimeBias;
                GalClockTimeUncertainty = reader.GalClockTimeUncertainty;
                GalClockSource = reader.GalClockSource;
                ClockFrequencyBias = reader.ClockFrequencyBias;
                ClockFrequencyUncertainty = reader.ClockFrequencyUncertainty;
                FrequencySource = reader.FrequencySource;
                GpsLeapSeconds = reader.GpsLeapSeconds;
                GpsLeapSecondsUncertainty = reader.GpsLeapSecondsUncertainty;
                GpsLeapSecondsSource = reader.GpsLeapSecondsSource;
                GpsToGlonassTimeBiasMilliseconds = reader.GpsToGlonassTimeBiasMilliseconds;
                GpsToGlonassTimeBiasMillisecondsUncertainty = reader.GpsToGlonassTimeBiasMillisecondsUncertainty;
                GpsToBdsTimeBiasMilliseconds = reader.GpsToBdsTimeBiasMilliseconds;
                GpsToBdsTimeBiasMillisecondsUncertainty = reader.GpsToBdsTimeBiasMillisecondsUncertainty;
                BdsToGloTimeBiasMilliseconds = reader.BdsToGloTimeBiasMilliseconds;
                BdsToGloTimeBiasMillisecondsUncertainty = reader.BdsToGloTimeBiasMillisecondsUncertainty;
                GpsToGalTimeBiasMilliseconds = reader.GpsToGalTimeBiasMilliseconds;
                GpsToGalTimeBiasMillisecondsUncertainty = reader.GpsToGalTimeBiasMillisecondsUncertainty;
                GalToGloTimeBiasMilliseconds = reader.GalToGloTimeBiasMilliseconds;
                GalToGloTimeBiasMillisecondsUncertainty = reader.GalToGloTimeBiasMillisecondsUncertainty;
                GalToBdsTimeBiasMilliseconds = reader.GalToBdsTimeBiasMilliseconds;
                GalToBdsTimeBiasMillisecondsUncertainty = reader.GalToBdsTimeBiasMillisecondsUncertainty;
                HasRtcTime = reader.HasRtcTime;
                SystemRtcTime = reader.SystemRtcTime;
                FCountOffset = reader.FCountOffset;
                LpmRtcCount = reader.LpmRtcCount;
                ClockResets = reader.ClockResets;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.HasFCount = HasFCount;
                writer.FCount = FCount;
                writer.HasGpsWeek = HasGpsWeek;
                writer.GpsWeek = GpsWeek;
                writer.HasGpsMilliseconds = HasGpsMilliseconds;
                writer.GpsMilliseconds = GpsMilliseconds;
                writer.GpsTimeBias = GpsTimeBias;
                writer.GpsClockTimeUncertainty = GpsClockTimeUncertainty;
                writer.GpsClockSource = GpsClockSource;
                writer.HasGlonassYear = HasGlonassYear;
                writer.GlonassYear = GlonassYear;
                writer.HasGlonassDay = HasGlonassDay;
                writer.GlonassDay = GlonassDay;
                writer.HasGlonassMilliseconds = HasGlonassMilliseconds;
                writer.GlonassMilliseconds = GlonassMilliseconds;
                writer.GlonassTimeBias = GlonassTimeBias;
                writer.GlonassClockTimeUncertainty = GlonassClockTimeUncertainty;
                writer.GlonassClockSource = GlonassClockSource;
                writer.BdsWeek = BdsWeek;
                writer.BdsMilliseconds = BdsMilliseconds;
                writer.BdsTimeBias = BdsTimeBias;
                writer.BdsClockTimeUncertainty = BdsClockTimeUncertainty;
                writer.BdsClockSource = BdsClockSource;
                writer.GalWeek = GalWeek;
                writer.GalMilliseconds = GalMilliseconds;
                writer.GalTimeBias = GalTimeBias;
                writer.GalClockTimeUncertainty = GalClockTimeUncertainty;
                writer.GalClockSource = GalClockSource;
                writer.ClockFrequencyBias = ClockFrequencyBias;
                writer.ClockFrequencyUncertainty = ClockFrequencyUncertainty;
                writer.FrequencySource = FrequencySource;
                writer.GpsLeapSeconds = GpsLeapSeconds;
                writer.GpsLeapSecondsUncertainty = GpsLeapSecondsUncertainty;
                writer.GpsLeapSecondsSource = GpsLeapSecondsSource;
                writer.GpsToGlonassTimeBiasMilliseconds = GpsToGlonassTimeBiasMilliseconds;
                writer.GpsToGlonassTimeBiasMillisecondsUncertainty = GpsToGlonassTimeBiasMillisecondsUncertainty;
                writer.GpsToBdsTimeBiasMilliseconds = GpsToBdsTimeBiasMilliseconds;
                writer.GpsToBdsTimeBiasMillisecondsUncertainty = GpsToBdsTimeBiasMillisecondsUncertainty;
                writer.BdsToGloTimeBiasMilliseconds = BdsToGloTimeBiasMilliseconds;
                writer.BdsToGloTimeBiasMillisecondsUncertainty = BdsToGloTimeBiasMillisecondsUncertainty;
                writer.GpsToGalTimeBiasMilliseconds = GpsToGalTimeBiasMilliseconds;
                writer.GpsToGalTimeBiasMillisecondsUncertainty = GpsToGalTimeBiasMillisecondsUncertainty;
                writer.GalToGloTimeBiasMilliseconds = GalToGloTimeBiasMilliseconds;
                writer.GalToGloTimeBiasMillisecondsUncertainty = GalToGloTimeBiasMillisecondsUncertainty;
                writer.GalToBdsTimeBiasMilliseconds = GalToBdsTimeBiasMilliseconds;
                writer.GalToBdsTimeBiasMillisecondsUncertainty = GalToBdsTimeBiasMillisecondsUncertainty;
                writer.HasRtcTime = HasRtcTime;
                writer.SystemRtcTime = SystemRtcTime;
                writer.FCountOffset = FCountOffset;
                writer.LpmRtcCount = LpmRtcCount;
                writer.ClockResets = ClockResets;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public bool HasFCount
            {
                get;
                set;
            }

            public uint FCount
            {
                get;
                set;
            }

            public bool HasGpsWeek
            {
                get;
                set;
            }

            public ushort GpsWeek
            {
                get;
                set;
            }

            public bool HasGpsMilliseconds
            {
                get;
                set;
            }

            public uint GpsMilliseconds
            {
                get;
                set;
            }

            public float GpsTimeBias
            {
                get;
                set;
            }

            public float GpsClockTimeUncertainty
            {
                get;
                set;
            }

            public byte GpsClockSource
            {
                get;
                set;
            }

            public bool HasGlonassYear
            {
                get;
                set;
            }

            public byte GlonassYear
            {
                get;
                set;
            }

            public bool HasGlonassDay
            {
                get;
                set;
            }

            public ushort GlonassDay
            {
                get;
                set;
            }

            public bool HasGlonassMilliseconds
            {
                get;
                set;
            }

            public uint GlonassMilliseconds
            {
                get;
                set;
            }

            public float GlonassTimeBias
            {
                get;
                set;
            }

            public float GlonassClockTimeUncertainty
            {
                get;
                set;
            }

            public byte GlonassClockSource
            {
                get;
                set;
            }

            public ushort BdsWeek
            {
                get;
                set;
            }

            public uint BdsMilliseconds
            {
                get;
                set;
            }

            public float BdsTimeBias
            {
                get;
                set;
            }

            public float BdsClockTimeUncertainty
            {
                get;
                set;
            }

            public byte BdsClockSource
            {
                get;
                set;
            }

            public ushort GalWeek
            {
                get;
                set;
            }

            public uint GalMilliseconds
            {
                get;
                set;
            }

            public float GalTimeBias
            {
                get;
                set;
            }

            public float GalClockTimeUncertainty
            {
                get;
                set;
            }

            public byte GalClockSource
            {
                get;
                set;
            }

            public float ClockFrequencyBias
            {
                get;
                set;
            }

            public float ClockFrequencyUncertainty
            {
                get;
                set;
            }

            public byte FrequencySource
            {
                get;
                set;
            }

            public byte GpsLeapSeconds
            {
                get;
                set;
            }

            public byte GpsLeapSecondsUncertainty
            {
                get;
                set;
            }

            public byte GpsLeapSecondsSource
            {
                get;
                set;
            }

            public float GpsToGlonassTimeBiasMilliseconds
            {
                get;
                set;
            }

            public float GpsToGlonassTimeBiasMillisecondsUncertainty
            {
                get;
                set;
            }

            public float GpsToBdsTimeBiasMilliseconds
            {
                get;
                set;
            }

            public float GpsToBdsTimeBiasMillisecondsUncertainty
            {
                get;
                set;
            }

            public float BdsToGloTimeBiasMilliseconds
            {
                get;
                set;
            }

            public float BdsToGloTimeBiasMillisecondsUncertainty
            {
                get;
                set;
            }

            public float GpsToGalTimeBiasMilliseconds
            {
                get;
                set;
            }

            public float GpsToGalTimeBiasMillisecondsUncertainty
            {
                get;
                set;
            }

            public float GalToGloTimeBiasMilliseconds
            {
                get;
                set;
            }

            public float GalToGloTimeBiasMillisecondsUncertainty
            {
                get;
                set;
            }

            public float GalToBdsTimeBiasMilliseconds
            {
                get;
                set;
            }

            public float GalToBdsTimeBiasMillisecondsUncertainty
            {
                get;
                set;
            }

            public bool HasRtcTime
            {
                get;
                set;
            }

            public uint SystemRtcTime
            {
                get;
                set;
            }

            public uint FCountOffset
            {
                get;
                set;
            }

            public uint LpmRtcCount
            {
                get;
                set;
            }

            public uint ClockResets
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public bool HasFCount => ctx.ReadDataBool(0UL, false);
                public uint FCount => ctx.ReadDataUInt(32UL, 0U);
                public bool HasGpsWeek => ctx.ReadDataBool(1UL, false);
                public ushort GpsWeek => ctx.ReadDataUShort(16UL, (ushort)0);
                public bool HasGpsMilliseconds => ctx.ReadDataBool(2UL, false);
                public uint GpsMilliseconds => ctx.ReadDataUInt(64UL, 0U);
                public float GpsTimeBias => ctx.ReadDataFloat(96UL, 0F);
                public float GpsClockTimeUncertainty => ctx.ReadDataFloat(128UL, 0F);
                public byte GpsClockSource => ctx.ReadDataByte(8UL, (byte)0);
                public bool HasGlonassYear => ctx.ReadDataBool(3UL, false);
                public byte GlonassYear => ctx.ReadDataByte(160UL, (byte)0);
                public bool HasGlonassDay => ctx.ReadDataBool(4UL, false);
                public ushort GlonassDay => ctx.ReadDataUShort(176UL, (ushort)0);
                public bool HasGlonassMilliseconds => ctx.ReadDataBool(5UL, false);
                public uint GlonassMilliseconds => ctx.ReadDataUInt(192UL, 0U);
                public float GlonassTimeBias => ctx.ReadDataFloat(224UL, 0F);
                public float GlonassClockTimeUncertainty => ctx.ReadDataFloat(256UL, 0F);
                public byte GlonassClockSource => ctx.ReadDataByte(168UL, (byte)0);
                public ushort BdsWeek => ctx.ReadDataUShort(288UL, (ushort)0);
                public uint BdsMilliseconds => ctx.ReadDataUInt(320UL, 0U);
                public float BdsTimeBias => ctx.ReadDataFloat(352UL, 0F);
                public float BdsClockTimeUncertainty => ctx.ReadDataFloat(384UL, 0F);
                public byte BdsClockSource => ctx.ReadDataByte(304UL, (byte)0);
                public ushort GalWeek => ctx.ReadDataUShort(416UL, (ushort)0);
                public uint GalMilliseconds => ctx.ReadDataUInt(448UL, 0U);
                public float GalTimeBias => ctx.ReadDataFloat(480UL, 0F);
                public float GalClockTimeUncertainty => ctx.ReadDataFloat(512UL, 0F);
                public byte GalClockSource => ctx.ReadDataByte(312UL, (byte)0);
                public float ClockFrequencyBias => ctx.ReadDataFloat(544UL, 0F);
                public float ClockFrequencyUncertainty => ctx.ReadDataFloat(576UL, 0F);
                public byte FrequencySource => ctx.ReadDataByte(432UL, (byte)0);
                public byte GpsLeapSeconds => ctx.ReadDataByte(440UL, (byte)0);
                public byte GpsLeapSecondsUncertainty => ctx.ReadDataByte(608UL, (byte)0);
                public byte GpsLeapSecondsSource => ctx.ReadDataByte(616UL, (byte)0);
                public float GpsToGlonassTimeBiasMilliseconds => ctx.ReadDataFloat(640UL, 0F);
                public float GpsToGlonassTimeBiasMillisecondsUncertainty => ctx.ReadDataFloat(672UL, 0F);
                public float GpsToBdsTimeBiasMilliseconds => ctx.ReadDataFloat(704UL, 0F);
                public float GpsToBdsTimeBiasMillisecondsUncertainty => ctx.ReadDataFloat(736UL, 0F);
                public float BdsToGloTimeBiasMilliseconds => ctx.ReadDataFloat(768UL, 0F);
                public float BdsToGloTimeBiasMillisecondsUncertainty => ctx.ReadDataFloat(800UL, 0F);
                public float GpsToGalTimeBiasMilliseconds => ctx.ReadDataFloat(832UL, 0F);
                public float GpsToGalTimeBiasMillisecondsUncertainty => ctx.ReadDataFloat(864UL, 0F);
                public float GalToGloTimeBiasMilliseconds => ctx.ReadDataFloat(896UL, 0F);
                public float GalToGloTimeBiasMillisecondsUncertainty => ctx.ReadDataFloat(928UL, 0F);
                public float GalToBdsTimeBiasMilliseconds => ctx.ReadDataFloat(960UL, 0F);
                public float GalToBdsTimeBiasMillisecondsUncertainty => ctx.ReadDataFloat(992UL, 0F);
                public bool HasRtcTime => ctx.ReadDataBool(6UL, false);
                public uint SystemRtcTime => ctx.ReadDataUInt(1024UL, 0U);
                public uint FCountOffset => ctx.ReadDataUInt(1056UL, 0U);
                public uint LpmRtcCount => ctx.ReadDataUInt(1088UL, 0U);
                public uint ClockResets => ctx.ReadDataUInt(1120UL, 0U);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(18, 0);
                }

                public bool HasFCount
                {
                    get => this.ReadDataBool(0UL, false);
                    set => this.WriteData(0UL, value, false);
                }

                public uint FCount
                {
                    get => this.ReadDataUInt(32UL, 0U);
                    set => this.WriteData(32UL, value, 0U);
                }

                public bool HasGpsWeek
                {
                    get => this.ReadDataBool(1UL, false);
                    set => this.WriteData(1UL, value, false);
                }

                public ushort GpsWeek
                {
                    get => this.ReadDataUShort(16UL, (ushort)0);
                    set => this.WriteData(16UL, value, (ushort)0);
                }

                public bool HasGpsMilliseconds
                {
                    get => this.ReadDataBool(2UL, false);
                    set => this.WriteData(2UL, value, false);
                }

                public uint GpsMilliseconds
                {
                    get => this.ReadDataUInt(64UL, 0U);
                    set => this.WriteData(64UL, value, 0U);
                }

                public float GpsTimeBias
                {
                    get => this.ReadDataFloat(96UL, 0F);
                    set => this.WriteData(96UL, value, 0F);
                }

                public float GpsClockTimeUncertainty
                {
                    get => this.ReadDataFloat(128UL, 0F);
                    set => this.WriteData(128UL, value, 0F);
                }

                public byte GpsClockSource
                {
                    get => this.ReadDataByte(8UL, (byte)0);
                    set => this.WriteData(8UL, value, (byte)0);
                }

                public bool HasGlonassYear
                {
                    get => this.ReadDataBool(3UL, false);
                    set => this.WriteData(3UL, value, false);
                }

                public byte GlonassYear
                {
                    get => this.ReadDataByte(160UL, (byte)0);
                    set => this.WriteData(160UL, value, (byte)0);
                }

                public bool HasGlonassDay
                {
                    get => this.ReadDataBool(4UL, false);
                    set => this.WriteData(4UL, value, false);
                }

                public ushort GlonassDay
                {
                    get => this.ReadDataUShort(176UL, (ushort)0);
                    set => this.WriteData(176UL, value, (ushort)0);
                }

                public bool HasGlonassMilliseconds
                {
                    get => this.ReadDataBool(5UL, false);
                    set => this.WriteData(5UL, value, false);
                }

                public uint GlonassMilliseconds
                {
                    get => this.ReadDataUInt(192UL, 0U);
                    set => this.WriteData(192UL, value, 0U);
                }

                public float GlonassTimeBias
                {
                    get => this.ReadDataFloat(224UL, 0F);
                    set => this.WriteData(224UL, value, 0F);
                }

                public float GlonassClockTimeUncertainty
                {
                    get => this.ReadDataFloat(256UL, 0F);
                    set => this.WriteData(256UL, value, 0F);
                }

                public byte GlonassClockSource
                {
                    get => this.ReadDataByte(168UL, (byte)0);
                    set => this.WriteData(168UL, value, (byte)0);
                }

                public ushort BdsWeek
                {
                    get => this.ReadDataUShort(288UL, (ushort)0);
                    set => this.WriteData(288UL, value, (ushort)0);
                }

                public uint BdsMilliseconds
                {
                    get => this.ReadDataUInt(320UL, 0U);
                    set => this.WriteData(320UL, value, 0U);
                }

                public float BdsTimeBias
                {
                    get => this.ReadDataFloat(352UL, 0F);
                    set => this.WriteData(352UL, value, 0F);
                }

                public float BdsClockTimeUncertainty
                {
                    get => this.ReadDataFloat(384UL, 0F);
                    set => this.WriteData(384UL, value, 0F);
                }

                public byte BdsClockSource
                {
                    get => this.ReadDataByte(304UL, (byte)0);
                    set => this.WriteData(304UL, value, (byte)0);
                }

                public ushort GalWeek
                {
                    get => this.ReadDataUShort(416UL, (ushort)0);
                    set => this.WriteData(416UL, value, (ushort)0);
                }

                public uint GalMilliseconds
                {
                    get => this.ReadDataUInt(448UL, 0U);
                    set => this.WriteData(448UL, value, 0U);
                }

                public float GalTimeBias
                {
                    get => this.ReadDataFloat(480UL, 0F);
                    set => this.WriteData(480UL, value, 0F);
                }

                public float GalClockTimeUncertainty
                {
                    get => this.ReadDataFloat(512UL, 0F);
                    set => this.WriteData(512UL, value, 0F);
                }

                public byte GalClockSource
                {
                    get => this.ReadDataByte(312UL, (byte)0);
                    set => this.WriteData(312UL, value, (byte)0);
                }

                public float ClockFrequencyBias
                {
                    get => this.ReadDataFloat(544UL, 0F);
                    set => this.WriteData(544UL, value, 0F);
                }

                public float ClockFrequencyUncertainty
                {
                    get => this.ReadDataFloat(576UL, 0F);
                    set => this.WriteData(576UL, value, 0F);
                }

                public byte FrequencySource
                {
                    get => this.ReadDataByte(432UL, (byte)0);
                    set => this.WriteData(432UL, value, (byte)0);
                }

                public byte GpsLeapSeconds
                {
                    get => this.ReadDataByte(440UL, (byte)0);
                    set => this.WriteData(440UL, value, (byte)0);
                }

                public byte GpsLeapSecondsUncertainty
                {
                    get => this.ReadDataByte(608UL, (byte)0);
                    set => this.WriteData(608UL, value, (byte)0);
                }

                public byte GpsLeapSecondsSource
                {
                    get => this.ReadDataByte(616UL, (byte)0);
                    set => this.WriteData(616UL, value, (byte)0);
                }

                public float GpsToGlonassTimeBiasMilliseconds
                {
                    get => this.ReadDataFloat(640UL, 0F);
                    set => this.WriteData(640UL, value, 0F);
                }

                public float GpsToGlonassTimeBiasMillisecondsUncertainty
                {
                    get => this.ReadDataFloat(672UL, 0F);
                    set => this.WriteData(672UL, value, 0F);
                }

                public float GpsToBdsTimeBiasMilliseconds
                {
                    get => this.ReadDataFloat(704UL, 0F);
                    set => this.WriteData(704UL, value, 0F);
                }

                public float GpsToBdsTimeBiasMillisecondsUncertainty
                {
                    get => this.ReadDataFloat(736UL, 0F);
                    set => this.WriteData(736UL, value, 0F);
                }

                public float BdsToGloTimeBiasMilliseconds
                {
                    get => this.ReadDataFloat(768UL, 0F);
                    set => this.WriteData(768UL, value, 0F);
                }

                public float BdsToGloTimeBiasMillisecondsUncertainty
                {
                    get => this.ReadDataFloat(800UL, 0F);
                    set => this.WriteData(800UL, value, 0F);
                }

                public float GpsToGalTimeBiasMilliseconds
                {
                    get => this.ReadDataFloat(832UL, 0F);
                    set => this.WriteData(832UL, value, 0F);
                }

                public float GpsToGalTimeBiasMillisecondsUncertainty
                {
                    get => this.ReadDataFloat(864UL, 0F);
                    set => this.WriteData(864UL, value, 0F);
                }

                public float GalToGloTimeBiasMilliseconds
                {
                    get => this.ReadDataFloat(896UL, 0F);
                    set => this.WriteData(896UL, value, 0F);
                }

                public float GalToGloTimeBiasMillisecondsUncertainty
                {
                    get => this.ReadDataFloat(928UL, 0F);
                    set => this.WriteData(928UL, value, 0F);
                }

                public float GalToBdsTimeBiasMilliseconds
                {
                    get => this.ReadDataFloat(960UL, 0F);
                    set => this.WriteData(960UL, value, 0F);
                }

                public float GalToBdsTimeBiasMillisecondsUncertainty
                {
                    get => this.ReadDataFloat(992UL, 0F);
                    set => this.WriteData(992UL, value, 0F);
                }

                public bool HasRtcTime
                {
                    get => this.ReadDataBool(6UL, false);
                    set => this.WriteData(6UL, value, false);
                }

                public uint SystemRtcTime
                {
                    get => this.ReadDataUInt(1024UL, 0U);
                    set => this.WriteData(1024UL, value, 0U);
                }

                public uint FCountOffset
                {
                    get => this.ReadDataUInt(1056UL, 0U);
                    set => this.WriteData(1056UL, value, 0U);
                }

                public uint LpmRtcCount
                {
                    get => this.ReadDataUInt(1088UL, 0U);
                    set => this.WriteData(1088UL, value, 0U);
                }

                public uint ClockResets
                {
                    get => this.ReadDataUInt(1120UL, 0U);
                    set => this.WriteData(1120UL, value, 0U);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x8053c39445c6c75cUL)]
        public class DrMeasurementReport : ICapnpSerializable
        {
            public const UInt64 typeId = 0x8053c39445c6c75cUL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Reason = reader.Reason;
                SeqNum = reader.SeqNum;
                SeqMax = reader.SeqMax;
                RfLoss = reader.RfLoss;
                SystemRtcValid = reader.SystemRtcValid;
                FCount = reader.FCount;
                ClockResets = reader.ClockResets;
                SystemRtcTime = reader.SystemRtcTime;
                GpsLeapSeconds = reader.GpsLeapSeconds;
                GpsLeapSecondsUncertainty = reader.GpsLeapSecondsUncertainty;
                GpsToGlonassTimeBiasMilliseconds = reader.GpsToGlonassTimeBiasMilliseconds;
                GpsToGlonassTimeBiasMillisecondsUncertainty = reader.GpsToGlonassTimeBiasMillisecondsUncertainty;
                GpsWeek = reader.GpsWeek;
                GpsMilliseconds = reader.GpsMilliseconds;
                GpsTimeBiasMs = reader.GpsTimeBiasMs;
                GpsClockTimeUncertaintyMs = reader.GpsClockTimeUncertaintyMs;
                GpsClockSource = reader.GpsClockSource;
                GlonassClockSource = reader.GlonassClockSource;
                GlonassYear = reader.GlonassYear;
                GlonassDay = reader.GlonassDay;
                GlonassMilliseconds = reader.GlonassMilliseconds;
                GlonassTimeBias = reader.GlonassTimeBias;
                GlonassClockTimeUncertainty = reader.GlonassClockTimeUncertainty;
                ClockFrequencyBias = reader.ClockFrequencyBias;
                ClockFrequencyUncertainty = reader.ClockFrequencyUncertainty;
                FrequencySource = reader.FrequencySource;
                Source = reader.Source;
                Sv = reader.Sv?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.QcomGnss.DrMeasurementReport.SV>(_));
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Reason = Reason;
                writer.SeqNum = SeqNum;
                writer.SeqMax = SeqMax;
                writer.RfLoss = RfLoss;
                writer.SystemRtcValid = SystemRtcValid;
                writer.FCount = FCount;
                writer.ClockResets = ClockResets;
                writer.SystemRtcTime = SystemRtcTime;
                writer.GpsLeapSeconds = GpsLeapSeconds;
                writer.GpsLeapSecondsUncertainty = GpsLeapSecondsUncertainty;
                writer.GpsToGlonassTimeBiasMilliseconds = GpsToGlonassTimeBiasMilliseconds;
                writer.GpsToGlonassTimeBiasMillisecondsUncertainty = GpsToGlonassTimeBiasMillisecondsUncertainty;
                writer.GpsWeek = GpsWeek;
                writer.GpsMilliseconds = GpsMilliseconds;
                writer.GpsTimeBiasMs = GpsTimeBiasMs;
                writer.GpsClockTimeUncertaintyMs = GpsClockTimeUncertaintyMs;
                writer.GpsClockSource = GpsClockSource;
                writer.GlonassClockSource = GlonassClockSource;
                writer.GlonassYear = GlonassYear;
                writer.GlonassDay = GlonassDay;
                writer.GlonassMilliseconds = GlonassMilliseconds;
                writer.GlonassTimeBias = GlonassTimeBias;
                writer.GlonassClockTimeUncertainty = GlonassClockTimeUncertainty;
                writer.ClockFrequencyBias = ClockFrequencyBias;
                writer.ClockFrequencyUncertainty = ClockFrequencyUncertainty;
                writer.FrequencySource = FrequencySource;
                writer.Source = Source;
                writer.Sv.Init(Sv, (_s1, _v1) => _v1?.serialize(_s1));
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public byte Reason
            {
                get;
                set;
            }

            public byte SeqNum
            {
                get;
                set;
            }

            public byte SeqMax
            {
                get;
                set;
            }

            public ushort RfLoss
            {
                get;
                set;
            }

            public bool SystemRtcValid
            {
                get;
                set;
            }

            public uint FCount
            {
                get;
                set;
            }

            public uint ClockResets
            {
                get;
                set;
            }

            public ulong SystemRtcTime
            {
                get;
                set;
            }

            public byte GpsLeapSeconds
            {
                get;
                set;
            }

            public byte GpsLeapSecondsUncertainty
            {
                get;
                set;
            }

            public float GpsToGlonassTimeBiasMilliseconds
            {
                get;
                set;
            }

            public float GpsToGlonassTimeBiasMillisecondsUncertainty
            {
                get;
                set;
            }

            public ushort GpsWeek
            {
                get;
                set;
            }

            public uint GpsMilliseconds
            {
                get;
                set;
            }

            public uint GpsTimeBiasMs
            {
                get;
                set;
            }

            public uint GpsClockTimeUncertaintyMs
            {
                get;
                set;
            }

            public byte GpsClockSource
            {
                get;
                set;
            }

            public byte GlonassClockSource
            {
                get;
                set;
            }

            public byte GlonassYear
            {
                get;
                set;
            }

            public ushort GlonassDay
            {
                get;
                set;
            }

            public uint GlonassMilliseconds
            {
                get;
                set;
            }

            public float GlonassTimeBias
            {
                get;
                set;
            }

            public float GlonassClockTimeUncertainty
            {
                get;
                set;
            }

            public float ClockFrequencyBias
            {
                get;
                set;
            }

            public float ClockFrequencyUncertainty
            {
                get;
                set;
            }

            public byte FrequencySource
            {
                get;
                set;
            }

            public Cereal.QcomGnss.MeasurementSource Source
            {
                get;
                set;
            }

            public IReadOnlyList<Cereal.QcomGnss.DrMeasurementReport.SV> Sv
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public byte Reason => ctx.ReadDataByte(0UL, (byte)0);
                public byte SeqNum => ctx.ReadDataByte(8UL, (byte)0);
                public byte SeqMax => ctx.ReadDataByte(16UL, (byte)0);
                public ushort RfLoss => ctx.ReadDataUShort(32UL, (ushort)0);
                public bool SystemRtcValid => ctx.ReadDataBool(24UL, false);
                public uint FCount => ctx.ReadDataUInt(64UL, 0U);
                public uint ClockResets => ctx.ReadDataUInt(96UL, 0U);
                public ulong SystemRtcTime => ctx.ReadDataULong(128UL, 0UL);
                public byte GpsLeapSeconds => ctx.ReadDataByte(48UL, (byte)0);
                public byte GpsLeapSecondsUncertainty => ctx.ReadDataByte(56UL, (byte)0);
                public float GpsToGlonassTimeBiasMilliseconds => ctx.ReadDataFloat(192UL, 0F);
                public float GpsToGlonassTimeBiasMillisecondsUncertainty => ctx.ReadDataFloat(224UL, 0F);
                public ushort GpsWeek => ctx.ReadDataUShort(256UL, (ushort)0);
                public uint GpsMilliseconds => ctx.ReadDataUInt(288UL, 0U);
                public uint GpsTimeBiasMs => ctx.ReadDataUInt(320UL, 0U);
                public uint GpsClockTimeUncertaintyMs => ctx.ReadDataUInt(352UL, 0U);
                public byte GpsClockSource => ctx.ReadDataByte(272UL, (byte)0);
                public byte GlonassClockSource => ctx.ReadDataByte(280UL, (byte)0);
                public byte GlonassYear => ctx.ReadDataByte(384UL, (byte)0);
                public ushort GlonassDay => ctx.ReadDataUShort(400UL, (ushort)0);
                public uint GlonassMilliseconds => ctx.ReadDataUInt(416UL, 0U);
                public float GlonassTimeBias => ctx.ReadDataFloat(448UL, 0F);
                public float GlonassClockTimeUncertainty => ctx.ReadDataFloat(480UL, 0F);
                public float ClockFrequencyBias => ctx.ReadDataFloat(512UL, 0F);
                public float ClockFrequencyUncertainty => ctx.ReadDataFloat(544UL, 0F);
                public byte FrequencySource => ctx.ReadDataByte(392UL, (byte)0);
                public Cereal.QcomGnss.MeasurementSource Source => (Cereal.QcomGnss.MeasurementSource)ctx.ReadDataUShort(576UL, (ushort)0);
                public IReadOnlyList<Cereal.QcomGnss.DrMeasurementReport.SV.READER> Sv => ctx.ReadList(0).Cast(Cereal.QcomGnss.DrMeasurementReport.SV.READER.create);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(10, 1);
                }

                public byte Reason
                {
                    get => this.ReadDataByte(0UL, (byte)0);
                    set => this.WriteData(0UL, value, (byte)0);
                }

                public byte SeqNum
                {
                    get => this.ReadDataByte(8UL, (byte)0);
                    set => this.WriteData(8UL, value, (byte)0);
                }

                public byte SeqMax
                {
                    get => this.ReadDataByte(16UL, (byte)0);
                    set => this.WriteData(16UL, value, (byte)0);
                }

                public ushort RfLoss
                {
                    get => this.ReadDataUShort(32UL, (ushort)0);
                    set => this.WriteData(32UL, value, (ushort)0);
                }

                public bool SystemRtcValid
                {
                    get => this.ReadDataBool(24UL, false);
                    set => this.WriteData(24UL, value, false);
                }

                public uint FCount
                {
                    get => this.ReadDataUInt(64UL, 0U);
                    set => this.WriteData(64UL, value, 0U);
                }

                public uint ClockResets
                {
                    get => this.ReadDataUInt(96UL, 0U);
                    set => this.WriteData(96UL, value, 0U);
                }

                public ulong SystemRtcTime
                {
                    get => this.ReadDataULong(128UL, 0UL);
                    set => this.WriteData(128UL, value, 0UL);
                }

                public byte GpsLeapSeconds
                {
                    get => this.ReadDataByte(48UL, (byte)0);
                    set => this.WriteData(48UL, value, (byte)0);
                }

                public byte GpsLeapSecondsUncertainty
                {
                    get => this.ReadDataByte(56UL, (byte)0);
                    set => this.WriteData(56UL, value, (byte)0);
                }

                public float GpsToGlonassTimeBiasMilliseconds
                {
                    get => this.ReadDataFloat(192UL, 0F);
                    set => this.WriteData(192UL, value, 0F);
                }

                public float GpsToGlonassTimeBiasMillisecondsUncertainty
                {
                    get => this.ReadDataFloat(224UL, 0F);
                    set => this.WriteData(224UL, value, 0F);
                }

                public ushort GpsWeek
                {
                    get => this.ReadDataUShort(256UL, (ushort)0);
                    set => this.WriteData(256UL, value, (ushort)0);
                }

                public uint GpsMilliseconds
                {
                    get => this.ReadDataUInt(288UL, 0U);
                    set => this.WriteData(288UL, value, 0U);
                }

                public uint GpsTimeBiasMs
                {
                    get => this.ReadDataUInt(320UL, 0U);
                    set => this.WriteData(320UL, value, 0U);
                }

                public uint GpsClockTimeUncertaintyMs
                {
                    get => this.ReadDataUInt(352UL, 0U);
                    set => this.WriteData(352UL, value, 0U);
                }

                public byte GpsClockSource
                {
                    get => this.ReadDataByte(272UL, (byte)0);
                    set => this.WriteData(272UL, value, (byte)0);
                }

                public byte GlonassClockSource
                {
                    get => this.ReadDataByte(280UL, (byte)0);
                    set => this.WriteData(280UL, value, (byte)0);
                }

                public byte GlonassYear
                {
                    get => this.ReadDataByte(384UL, (byte)0);
                    set => this.WriteData(384UL, value, (byte)0);
                }

                public ushort GlonassDay
                {
                    get => this.ReadDataUShort(400UL, (ushort)0);
                    set => this.WriteData(400UL, value, (ushort)0);
                }

                public uint GlonassMilliseconds
                {
                    get => this.ReadDataUInt(416UL, 0U);
                    set => this.WriteData(416UL, value, 0U);
                }

                public float GlonassTimeBias
                {
                    get => this.ReadDataFloat(448UL, 0F);
                    set => this.WriteData(448UL, value, 0F);
                }

                public float GlonassClockTimeUncertainty
                {
                    get => this.ReadDataFloat(480UL, 0F);
                    set => this.WriteData(480UL, value, 0F);
                }

                public float ClockFrequencyBias
                {
                    get => this.ReadDataFloat(512UL, 0F);
                    set => this.WriteData(512UL, value, 0F);
                }

                public float ClockFrequencyUncertainty
                {
                    get => this.ReadDataFloat(544UL, 0F);
                    set => this.WriteData(544UL, value, 0F);
                }

                public byte FrequencySource
                {
                    get => this.ReadDataByte(392UL, (byte)0);
                    set => this.WriteData(392UL, value, (byte)0);
                }

                public Cereal.QcomGnss.MeasurementSource Source
                {
                    get => (Cereal.QcomGnss.MeasurementSource)this.ReadDataUShort(576UL, (ushort)0);
                    set => this.WriteData(576UL, (ushort)value, (ushort)0);
                }

                public ListOfStructsSerializer<Cereal.QcomGnss.DrMeasurementReport.SV.WRITER> Sv
                {
                    get => BuildPointer<ListOfStructsSerializer<Cereal.QcomGnss.DrMeasurementReport.SV.WRITER>>(0);
                    set => Link(0, value);
                }
            }

            [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xf08b81df8cbf459cUL)]
            public class SV : ICapnpSerializable
            {
                public const UInt64 typeId = 0xf08b81df8cbf459cUL;
                void ICapnpSerializable.Deserialize(DeserializerState arg_)
                {
                    var reader = READER.create(arg_);
                    SvId = reader.SvId;
                    GlonassFrequencyIndex = reader.GlonassFrequencyIndex;
                    ObservationState = reader.ObservationState;
                    Observations = reader.Observations;
                    GoodObservations = reader.GoodObservations;
                    FilterStages = reader.FilterStages;
                    PredetectInterval = reader.PredetectInterval;
                    CycleSlipCount = reader.CycleSlipCount;
                    Postdetections = reader.Postdetections;
                    MeasurementStatus = CapnpSerializable.Create<Cereal.QcomGnss.MeasurementStatus>(reader.MeasurementStatus);
                    CarrierNoise = reader.CarrierNoise;
                    RfLoss = reader.RfLoss;
                    Latency = reader.Latency;
                    FilteredMeasurementFraction = reader.FilteredMeasurementFraction;
                    FilteredMeasurementIntegral = reader.FilteredMeasurementIntegral;
                    FilteredTimeUncertainty = reader.FilteredTimeUncertainty;
                    FilteredSpeed = reader.FilteredSpeed;
                    FilteredSpeedUncertainty = reader.FilteredSpeedUncertainty;
                    UnfilteredMeasurementFraction = reader.UnfilteredMeasurementFraction;
                    UnfilteredMeasurementIntegral = reader.UnfilteredMeasurementIntegral;
                    UnfilteredTimeUncertainty = reader.UnfilteredTimeUncertainty;
                    UnfilteredSpeed = reader.UnfilteredSpeed;
                    UnfilteredSpeedUncertainty = reader.UnfilteredSpeedUncertainty;
                    MultipathEstimate = reader.MultipathEstimate;
                    Azimuth = reader.Azimuth;
                    Elevation = reader.Elevation;
                    DopplerAcceleration = reader.DopplerAcceleration;
                    FineSpeed = reader.FineSpeed;
                    FineSpeedUncertainty = reader.FineSpeedUncertainty;
                    CarrierPhase = reader.CarrierPhase;
                    FCount = reader.FCount;
                    ParityErrorCount = reader.ParityErrorCount;
                    GoodParity = reader.GoodParity;
                    applyDefaults();
                }

                public void serialize(WRITER writer)
                {
                    writer.SvId = SvId;
                    writer.GlonassFrequencyIndex = GlonassFrequencyIndex;
                    writer.ObservationState = ObservationState;
                    writer.Observations = Observations;
                    writer.GoodObservations = GoodObservations;
                    writer.FilterStages = FilterStages;
                    writer.PredetectInterval = PredetectInterval;
                    writer.CycleSlipCount = CycleSlipCount;
                    writer.Postdetections = Postdetections;
                    MeasurementStatus?.serialize(writer.MeasurementStatus);
                    writer.CarrierNoise = CarrierNoise;
                    writer.RfLoss = RfLoss;
                    writer.Latency = Latency;
                    writer.FilteredMeasurementFraction = FilteredMeasurementFraction;
                    writer.FilteredMeasurementIntegral = FilteredMeasurementIntegral;
                    writer.FilteredTimeUncertainty = FilteredTimeUncertainty;
                    writer.FilteredSpeed = FilteredSpeed;
                    writer.FilteredSpeedUncertainty = FilteredSpeedUncertainty;
                    writer.UnfilteredMeasurementFraction = UnfilteredMeasurementFraction;
                    writer.UnfilteredMeasurementIntegral = UnfilteredMeasurementIntegral;
                    writer.UnfilteredTimeUncertainty = UnfilteredTimeUncertainty;
                    writer.UnfilteredSpeed = UnfilteredSpeed;
                    writer.UnfilteredSpeedUncertainty = UnfilteredSpeedUncertainty;
                    writer.MultipathEstimate = MultipathEstimate;
                    writer.Azimuth = Azimuth;
                    writer.Elevation = Elevation;
                    writer.DopplerAcceleration = DopplerAcceleration;
                    writer.FineSpeed = FineSpeed;
                    writer.FineSpeedUncertainty = FineSpeedUncertainty;
                    writer.CarrierPhase = CarrierPhase;
                    writer.FCount = FCount;
                    writer.ParityErrorCount = ParityErrorCount;
                    writer.GoodParity = GoodParity;
                }

                void ICapnpSerializable.Serialize(SerializerState arg_)
                {
                    serialize(arg_.Rewrap<WRITER>());
                }

                public void applyDefaults()
                {
                }

                public byte SvId
                {
                    get;
                    set;
                }

                public sbyte GlonassFrequencyIndex
                {
                    get;
                    set;
                }

                public Cereal.QcomGnss.SVObservationState ObservationState
                {
                    get;
                    set;
                }

                public byte Observations
                {
                    get;
                    set;
                }

                public byte GoodObservations
                {
                    get;
                    set;
                }

                public byte FilterStages
                {
                    get;
                    set;
                }

                public byte PredetectInterval
                {
                    get;
                    set;
                }

                public byte CycleSlipCount
                {
                    get;
                    set;
                }

                public ushort Postdetections
                {
                    get;
                    set;
                }

                public Cereal.QcomGnss.MeasurementStatus MeasurementStatus
                {
                    get;
                    set;
                }

                public ushort CarrierNoise
                {
                    get;
                    set;
                }

                public ushort RfLoss
                {
                    get;
                    set;
                }

                public short Latency
                {
                    get;
                    set;
                }

                public float FilteredMeasurementFraction
                {
                    get;
                    set;
                }

                public uint FilteredMeasurementIntegral
                {
                    get;
                    set;
                }

                public float FilteredTimeUncertainty
                {
                    get;
                    set;
                }

                public float FilteredSpeed
                {
                    get;
                    set;
                }

                public float FilteredSpeedUncertainty
                {
                    get;
                    set;
                }

                public float UnfilteredMeasurementFraction
                {
                    get;
                    set;
                }

                public uint UnfilteredMeasurementIntegral
                {
                    get;
                    set;
                }

                public float UnfilteredTimeUncertainty
                {
                    get;
                    set;
                }

                public float UnfilteredSpeed
                {
                    get;
                    set;
                }

                public float UnfilteredSpeedUncertainty
                {
                    get;
                    set;
                }

                public uint MultipathEstimate
                {
                    get;
                    set;
                }

                public float Azimuth
                {
                    get;
                    set;
                }

                public float Elevation
                {
                    get;
                    set;
                }

                public float DopplerAcceleration
                {
                    get;
                    set;
                }

                public float FineSpeed
                {
                    get;
                    set;
                }

                public float FineSpeedUncertainty
                {
                    get;
                    set;
                }

                public double CarrierPhase
                {
                    get;
                    set;
                }

                public uint FCount
                {
                    get;
                    set;
                }

                public ushort ParityErrorCount
                {
                    get;
                    set;
                }

                public bool GoodParity
                {
                    get;
                    set;
                }

                public struct READER
                {
                    readonly DeserializerState ctx;
                    public READER(DeserializerState ctx)
                    {
                        this.ctx = ctx;
                    }

                    public static READER create(DeserializerState ctx) => new READER(ctx);
                    public static implicit operator DeserializerState(READER reader) => reader.ctx;
                    public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                    public byte SvId => ctx.ReadDataByte(0UL, (byte)0);
                    public sbyte GlonassFrequencyIndex => ctx.ReadDataSByte(8UL, (sbyte)0);
                    public Cereal.QcomGnss.SVObservationState ObservationState => (Cereal.QcomGnss.SVObservationState)ctx.ReadDataUShort(16UL, (ushort)0);
                    public byte Observations => ctx.ReadDataByte(32UL, (byte)0);
                    public byte GoodObservations => ctx.ReadDataByte(40UL, (byte)0);
                    public byte FilterStages => ctx.ReadDataByte(48UL, (byte)0);
                    public byte PredetectInterval => ctx.ReadDataByte(56UL, (byte)0);
                    public byte CycleSlipCount => ctx.ReadDataByte(64UL, (byte)0);
                    public ushort Postdetections => ctx.ReadDataUShort(80UL, (ushort)0);
                    public Cereal.QcomGnss.MeasurementStatus.READER MeasurementStatus => ctx.ReadStruct(0, Cereal.QcomGnss.MeasurementStatus.READER.create);
                    public ushort CarrierNoise => ctx.ReadDataUShort(96UL, (ushort)0);
                    public ushort RfLoss => ctx.ReadDataUShort(112UL, (ushort)0);
                    public short Latency => ctx.ReadDataShort(128UL, (short)0);
                    public float FilteredMeasurementFraction => ctx.ReadDataFloat(160UL, 0F);
                    public uint FilteredMeasurementIntegral => ctx.ReadDataUInt(192UL, 0U);
                    public float FilteredTimeUncertainty => ctx.ReadDataFloat(224UL, 0F);
                    public float FilteredSpeed => ctx.ReadDataFloat(256UL, 0F);
                    public float FilteredSpeedUncertainty => ctx.ReadDataFloat(288UL, 0F);
                    public float UnfilteredMeasurementFraction => ctx.ReadDataFloat(320UL, 0F);
                    public uint UnfilteredMeasurementIntegral => ctx.ReadDataUInt(352UL, 0U);
                    public float UnfilteredTimeUncertainty => ctx.ReadDataFloat(384UL, 0F);
                    public float UnfilteredSpeed => ctx.ReadDataFloat(416UL, 0F);
                    public float UnfilteredSpeedUncertainty => ctx.ReadDataFloat(448UL, 0F);
                    public uint MultipathEstimate => ctx.ReadDataUInt(480UL, 0U);
                    public float Azimuth => ctx.ReadDataFloat(512UL, 0F);
                    public float Elevation => ctx.ReadDataFloat(544UL, 0F);
                    public float DopplerAcceleration => ctx.ReadDataFloat(576UL, 0F);
                    public float FineSpeed => ctx.ReadDataFloat(608UL, 0F);
                    public float FineSpeedUncertainty => ctx.ReadDataFloat(640UL, 0F);
                    public double CarrierPhase => ctx.ReadDataDouble(704UL, 0);
                    public uint FCount => ctx.ReadDataUInt(672UL, 0U);
                    public ushort ParityErrorCount => ctx.ReadDataUShort(144UL, (ushort)0);
                    public bool GoodParity => ctx.ReadDataBool(72UL, false);
                }

                public class WRITER : SerializerState
                {
                    public WRITER()
                    {
                        this.SetStruct(12, 1);
                    }

                    public byte SvId
                    {
                        get => this.ReadDataByte(0UL, (byte)0);
                        set => this.WriteData(0UL, value, (byte)0);
                    }

                    public sbyte GlonassFrequencyIndex
                    {
                        get => this.ReadDataSByte(8UL, (sbyte)0);
                        set => this.WriteData(8UL, value, (sbyte)0);
                    }

                    public Cereal.QcomGnss.SVObservationState ObservationState
                    {
                        get => (Cereal.QcomGnss.SVObservationState)this.ReadDataUShort(16UL, (ushort)0);
                        set => this.WriteData(16UL, (ushort)value, (ushort)0);
                    }

                    public byte Observations
                    {
                        get => this.ReadDataByte(32UL, (byte)0);
                        set => this.WriteData(32UL, value, (byte)0);
                    }

                    public byte GoodObservations
                    {
                        get => this.ReadDataByte(40UL, (byte)0);
                        set => this.WriteData(40UL, value, (byte)0);
                    }

                    public byte FilterStages
                    {
                        get => this.ReadDataByte(48UL, (byte)0);
                        set => this.WriteData(48UL, value, (byte)0);
                    }

                    public byte PredetectInterval
                    {
                        get => this.ReadDataByte(56UL, (byte)0);
                        set => this.WriteData(56UL, value, (byte)0);
                    }

                    public byte CycleSlipCount
                    {
                        get => this.ReadDataByte(64UL, (byte)0);
                        set => this.WriteData(64UL, value, (byte)0);
                    }

                    public ushort Postdetections
                    {
                        get => this.ReadDataUShort(80UL, (ushort)0);
                        set => this.WriteData(80UL, value, (ushort)0);
                    }

                    public Cereal.QcomGnss.MeasurementStatus.WRITER MeasurementStatus
                    {
                        get => BuildPointer<Cereal.QcomGnss.MeasurementStatus.WRITER>(0);
                        set => Link(0, value);
                    }

                    public ushort CarrierNoise
                    {
                        get => this.ReadDataUShort(96UL, (ushort)0);
                        set => this.WriteData(96UL, value, (ushort)0);
                    }

                    public ushort RfLoss
                    {
                        get => this.ReadDataUShort(112UL, (ushort)0);
                        set => this.WriteData(112UL, value, (ushort)0);
                    }

                    public short Latency
                    {
                        get => this.ReadDataShort(128UL, (short)0);
                        set => this.WriteData(128UL, value, (short)0);
                    }

                    public float FilteredMeasurementFraction
                    {
                        get => this.ReadDataFloat(160UL, 0F);
                        set => this.WriteData(160UL, value, 0F);
                    }

                    public uint FilteredMeasurementIntegral
                    {
                        get => this.ReadDataUInt(192UL, 0U);
                        set => this.WriteData(192UL, value, 0U);
                    }

                    public float FilteredTimeUncertainty
                    {
                        get => this.ReadDataFloat(224UL, 0F);
                        set => this.WriteData(224UL, value, 0F);
                    }

                    public float FilteredSpeed
                    {
                        get => this.ReadDataFloat(256UL, 0F);
                        set => this.WriteData(256UL, value, 0F);
                    }

                    public float FilteredSpeedUncertainty
                    {
                        get => this.ReadDataFloat(288UL, 0F);
                        set => this.WriteData(288UL, value, 0F);
                    }

                    public float UnfilteredMeasurementFraction
                    {
                        get => this.ReadDataFloat(320UL, 0F);
                        set => this.WriteData(320UL, value, 0F);
                    }

                    public uint UnfilteredMeasurementIntegral
                    {
                        get => this.ReadDataUInt(352UL, 0U);
                        set => this.WriteData(352UL, value, 0U);
                    }

                    public float UnfilteredTimeUncertainty
                    {
                        get => this.ReadDataFloat(384UL, 0F);
                        set => this.WriteData(384UL, value, 0F);
                    }

                    public float UnfilteredSpeed
                    {
                        get => this.ReadDataFloat(416UL, 0F);
                        set => this.WriteData(416UL, value, 0F);
                    }

                    public float UnfilteredSpeedUncertainty
                    {
                        get => this.ReadDataFloat(448UL, 0F);
                        set => this.WriteData(448UL, value, 0F);
                    }

                    public uint MultipathEstimate
                    {
                        get => this.ReadDataUInt(480UL, 0U);
                        set => this.WriteData(480UL, value, 0U);
                    }

                    public float Azimuth
                    {
                        get => this.ReadDataFloat(512UL, 0F);
                        set => this.WriteData(512UL, value, 0F);
                    }

                    public float Elevation
                    {
                        get => this.ReadDataFloat(544UL, 0F);
                        set => this.WriteData(544UL, value, 0F);
                    }

                    public float DopplerAcceleration
                    {
                        get => this.ReadDataFloat(576UL, 0F);
                        set => this.WriteData(576UL, value, 0F);
                    }

                    public float FineSpeed
                    {
                        get => this.ReadDataFloat(608UL, 0F);
                        set => this.WriteData(608UL, value, 0F);
                    }

                    public float FineSpeedUncertainty
                    {
                        get => this.ReadDataFloat(640UL, 0F);
                        set => this.WriteData(640UL, value, 0F);
                    }

                    public double CarrierPhase
                    {
                        get => this.ReadDataDouble(704UL, 0);
                        set => this.WriteData(704UL, value, 0);
                    }

                    public uint FCount
                    {
                        get => this.ReadDataUInt(672UL, 0U);
                        set => this.WriteData(672UL, value, 0U);
                    }

                    public ushort ParityErrorCount
                    {
                        get => this.ReadDataUShort(144UL, (ushort)0);
                        set => this.WriteData(144UL, value, (ushort)0);
                    }

                    public bool GoodParity
                    {
                        get => this.ReadDataBool(72UL, false);
                        set => this.WriteData(72UL, value, false);
                    }
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xb1fb80811a673270UL)]
        public class DrSvPolyReport : ICapnpSerializable
        {
            public const UInt64 typeId = 0xb1fb80811a673270UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                SvId = reader.SvId;
                FrequencyIndex = reader.FrequencyIndex;
                HasPosition = reader.HasPosition;
                HasIono = reader.HasIono;
                HasTropo = reader.HasTropo;
                HasElevation = reader.HasElevation;
                PolyFromXtra = reader.PolyFromXtra;
                HasSbasIono = reader.HasSbasIono;
                Iode = reader.Iode;
                T0 = reader.T0;
                Xyz0 = reader.Xyz0;
                XyzN = reader.XyzN;
                Other = reader.Other;
                PositionUncertainty = reader.PositionUncertainty;
                IonoDelay = reader.IonoDelay;
                IonoDot = reader.IonoDot;
                SbasIonoDelay = reader.SbasIonoDelay;
                SbasIonoDot = reader.SbasIonoDot;
                TropoDelay = reader.TropoDelay;
                Elevation = reader.Elevation;
                ElevationDot = reader.ElevationDot;
                ElevationUncertainty = reader.ElevationUncertainty;
                VelocityCoeff = reader.VelocityCoeff;
                GpsWeek = reader.GpsWeek;
                GpsTow = reader.GpsTow;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.SvId = SvId;
                writer.FrequencyIndex = FrequencyIndex;
                writer.HasPosition = HasPosition;
                writer.HasIono = HasIono;
                writer.HasTropo = HasTropo;
                writer.HasElevation = HasElevation;
                writer.PolyFromXtra = PolyFromXtra;
                writer.HasSbasIono = HasSbasIono;
                writer.Iode = Iode;
                writer.T0 = T0;
                writer.Xyz0.Init(Xyz0);
                writer.XyzN.Init(XyzN);
                writer.Other.Init(Other);
                writer.PositionUncertainty = PositionUncertainty;
                writer.IonoDelay = IonoDelay;
                writer.IonoDot = IonoDot;
                writer.SbasIonoDelay = SbasIonoDelay;
                writer.SbasIonoDot = SbasIonoDot;
                writer.TropoDelay = TropoDelay;
                writer.Elevation = Elevation;
                writer.ElevationDot = ElevationDot;
                writer.ElevationUncertainty = ElevationUncertainty;
                writer.VelocityCoeff.Init(VelocityCoeff);
                writer.GpsWeek = GpsWeek;
                writer.GpsTow = GpsTow;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public ushort SvId
            {
                get;
                set;
            }

            public sbyte FrequencyIndex
            {
                get;
                set;
            }

            public bool HasPosition
            {
                get;
                set;
            }

            public bool HasIono
            {
                get;
                set;
            }

            public bool HasTropo
            {
                get;
                set;
            }

            public bool HasElevation
            {
                get;
                set;
            }

            public bool PolyFromXtra
            {
                get;
                set;
            }

            public bool HasSbasIono
            {
                get;
                set;
            }

            public ushort Iode
            {
                get;
                set;
            }

            public double T0
            {
                get;
                set;
            }

            public IReadOnlyList<double> Xyz0
            {
                get;
                set;
            }

            public IReadOnlyList<double> XyzN
            {
                get;
                set;
            }

            public IReadOnlyList<float> Other
            {
                get;
                set;
            }

            public float PositionUncertainty
            {
                get;
                set;
            }

            public float IonoDelay
            {
                get;
                set;
            }

            public float IonoDot
            {
                get;
                set;
            }

            public float SbasIonoDelay
            {
                get;
                set;
            }

            public float SbasIonoDot
            {
                get;
                set;
            }

            public float TropoDelay
            {
                get;
                set;
            }

            public float Elevation
            {
                get;
                set;
            }

            public float ElevationDot
            {
                get;
                set;
            }

            public float ElevationUncertainty
            {
                get;
                set;
            }

            public IReadOnlyList<double> VelocityCoeff
            {
                get;
                set;
            }

            public ushort GpsWeek
            {
                get;
                set;
            }

            public double GpsTow
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public ushort SvId => ctx.ReadDataUShort(0UL, (ushort)0);
                public sbyte FrequencyIndex => ctx.ReadDataSByte(16UL, (sbyte)0);
                public bool HasPosition => ctx.ReadDataBool(24UL, false);
                public bool HasIono => ctx.ReadDataBool(25UL, false);
                public bool HasTropo => ctx.ReadDataBool(26UL, false);
                public bool HasElevation => ctx.ReadDataBool(27UL, false);
                public bool PolyFromXtra => ctx.ReadDataBool(28UL, false);
                public bool HasSbasIono => ctx.ReadDataBool(29UL, false);
                public ushort Iode => ctx.ReadDataUShort(32UL, (ushort)0);
                public double T0 => ctx.ReadDataDouble(64UL, 0);
                public IReadOnlyList<double> Xyz0 => ctx.ReadList(0).CastDouble();
                public IReadOnlyList<double> XyzN => ctx.ReadList(1).CastDouble();
                public IReadOnlyList<float> Other => ctx.ReadList(2).CastFloat();
                public float PositionUncertainty => ctx.ReadDataFloat(128UL, 0F);
                public float IonoDelay => ctx.ReadDataFloat(160UL, 0F);
                public float IonoDot => ctx.ReadDataFloat(192UL, 0F);
                public float SbasIonoDelay => ctx.ReadDataFloat(224UL, 0F);
                public float SbasIonoDot => ctx.ReadDataFloat(256UL, 0F);
                public float TropoDelay => ctx.ReadDataFloat(288UL, 0F);
                public float Elevation => ctx.ReadDataFloat(320UL, 0F);
                public float ElevationDot => ctx.ReadDataFloat(352UL, 0F);
                public float ElevationUncertainty => ctx.ReadDataFloat(384UL, 0F);
                public IReadOnlyList<double> VelocityCoeff => ctx.ReadList(3).CastDouble();
                public ushort GpsWeek => ctx.ReadDataUShort(48UL, (ushort)0);
                public double GpsTow => ctx.ReadDataDouble(448UL, 0);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(8, 4);
                }

                public ushort SvId
                {
                    get => this.ReadDataUShort(0UL, (ushort)0);
                    set => this.WriteData(0UL, value, (ushort)0);
                }

                public sbyte FrequencyIndex
                {
                    get => this.ReadDataSByte(16UL, (sbyte)0);
                    set => this.WriteData(16UL, value, (sbyte)0);
                }

                public bool HasPosition
                {
                    get => this.ReadDataBool(24UL, false);
                    set => this.WriteData(24UL, value, false);
                }

                public bool HasIono
                {
                    get => this.ReadDataBool(25UL, false);
                    set => this.WriteData(25UL, value, false);
                }

                public bool HasTropo
                {
                    get => this.ReadDataBool(26UL, false);
                    set => this.WriteData(26UL, value, false);
                }

                public bool HasElevation
                {
                    get => this.ReadDataBool(27UL, false);
                    set => this.WriteData(27UL, value, false);
                }

                public bool PolyFromXtra
                {
                    get => this.ReadDataBool(28UL, false);
                    set => this.WriteData(28UL, value, false);
                }

                public bool HasSbasIono
                {
                    get => this.ReadDataBool(29UL, false);
                    set => this.WriteData(29UL, value, false);
                }

                public ushort Iode
                {
                    get => this.ReadDataUShort(32UL, (ushort)0);
                    set => this.WriteData(32UL, value, (ushort)0);
                }

                public double T0
                {
                    get => this.ReadDataDouble(64UL, 0);
                    set => this.WriteData(64UL, value, 0);
                }

                public ListOfPrimitivesSerializer<double> Xyz0
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<double>>(0);
                    set => Link(0, value);
                }

                public ListOfPrimitivesSerializer<double> XyzN
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<double>>(1);
                    set => Link(1, value);
                }

                public ListOfPrimitivesSerializer<float> Other
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(2);
                    set => Link(2, value);
                }

                public float PositionUncertainty
                {
                    get => this.ReadDataFloat(128UL, 0F);
                    set => this.WriteData(128UL, value, 0F);
                }

                public float IonoDelay
                {
                    get => this.ReadDataFloat(160UL, 0F);
                    set => this.WriteData(160UL, value, 0F);
                }

                public float IonoDot
                {
                    get => this.ReadDataFloat(192UL, 0F);
                    set => this.WriteData(192UL, value, 0F);
                }

                public float SbasIonoDelay
                {
                    get => this.ReadDataFloat(224UL, 0F);
                    set => this.WriteData(224UL, value, 0F);
                }

                public float SbasIonoDot
                {
                    get => this.ReadDataFloat(256UL, 0F);
                    set => this.WriteData(256UL, value, 0F);
                }

                public float TropoDelay
                {
                    get => this.ReadDataFloat(288UL, 0F);
                    set => this.WriteData(288UL, value, 0F);
                }

                public float Elevation
                {
                    get => this.ReadDataFloat(320UL, 0F);
                    set => this.WriteData(320UL, value, 0F);
                }

                public float ElevationDot
                {
                    get => this.ReadDataFloat(352UL, 0F);
                    set => this.WriteData(352UL, value, 0F);
                }

                public float ElevationUncertainty
                {
                    get => this.ReadDataFloat(384UL, 0F);
                    set => this.WriteData(384UL, value, 0F);
                }

                public ListOfPrimitivesSerializer<double> VelocityCoeff
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<double>>(3);
                    set => Link(3, value);
                }

                public ushort GpsWeek
                {
                    get => this.ReadDataUShort(48UL, (ushort)0);
                    set => this.WriteData(48UL, value, (ushort)0);
                }

                public double GpsTow
                {
                    get => this.ReadDataDouble(448UL, 0);
                    set => this.WriteData(448UL, value, 0);
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xc95fb49a7bdc4618UL)]
    public class Clocks : ICapnpSerializable
    {
        public const UInt64 typeId = 0xc95fb49a7bdc4618UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            BootTimeNanosDEPRECATED = reader.BootTimeNanosDEPRECATED;
            MonotonicNanosDEPRECATED = reader.MonotonicNanosDEPRECATED;
            MonotonicRawNanosDEPRECATD = reader.MonotonicRawNanosDEPRECATD;
            WallTimeNanos = reader.WallTimeNanos;
            ModemUptimeMillisDEPRECATED = reader.ModemUptimeMillisDEPRECATED;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.BootTimeNanosDEPRECATED = BootTimeNanosDEPRECATED;
            writer.MonotonicNanosDEPRECATED = MonotonicNanosDEPRECATED;
            writer.MonotonicRawNanosDEPRECATD = MonotonicRawNanosDEPRECATD;
            writer.WallTimeNanos = WallTimeNanos;
            writer.ModemUptimeMillisDEPRECATED = ModemUptimeMillisDEPRECATED;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public ulong BootTimeNanosDEPRECATED
        {
            get;
            set;
        }

        public ulong MonotonicNanosDEPRECATED
        {
            get;
            set;
        }

        public ulong MonotonicRawNanosDEPRECATD
        {
            get;
            set;
        }

        public ulong WallTimeNanos
        {
            get;
            set;
        }

        public ulong ModemUptimeMillisDEPRECATED
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public ulong BootTimeNanosDEPRECATED => ctx.ReadDataULong(0UL, 0UL);
            public ulong MonotonicNanosDEPRECATED => ctx.ReadDataULong(64UL, 0UL);
            public ulong MonotonicRawNanosDEPRECATD => ctx.ReadDataULong(128UL, 0UL);
            public ulong WallTimeNanos => ctx.ReadDataULong(192UL, 0UL);
            public ulong ModemUptimeMillisDEPRECATED => ctx.ReadDataULong(256UL, 0UL);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(5, 0);
            }

            public ulong BootTimeNanosDEPRECATED
            {
                get => this.ReadDataULong(0UL, 0UL);
                set => this.WriteData(0UL, value, 0UL);
            }

            public ulong MonotonicNanosDEPRECATED
            {
                get => this.ReadDataULong(64UL, 0UL);
                set => this.WriteData(64UL, value, 0UL);
            }

            public ulong MonotonicRawNanosDEPRECATD
            {
                get => this.ReadDataULong(128UL, 0UL);
                set => this.WriteData(128UL, value, 0UL);
            }

            public ulong WallTimeNanos
            {
                get => this.ReadDataULong(192UL, 0UL);
                set => this.WriteData(192UL, value, 0UL);
            }

            public ulong ModemUptimeMillisDEPRECATED
            {
                get => this.ReadDataULong(256UL, 0UL);
                set => this.WriteData(256UL, value, 0UL);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x92a5e332a85f32a0UL)]
    public class LiveMpcData : ICapnpSerializable
    {
        public const UInt64 typeId = 0x92a5e332a85f32a0UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            X = reader.X;
            Y = reader.Y;
            Psi = reader.Psi;
            Curvature = reader.Curvature;
            QpIterations = reader.QpIterations;
            CalculationTime = reader.CalculationTime;
            Cost = reader.Cost;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.X.Init(X);
            writer.Y.Init(Y);
            writer.Psi.Init(Psi);
            writer.Curvature.Init(Curvature);
            writer.QpIterations = QpIterations;
            writer.CalculationTime = CalculationTime;
            writer.Cost = Cost;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public IReadOnlyList<float> X
        {
            get;
            set;
        }

        public IReadOnlyList<float> Y
        {
            get;
            set;
        }

        public IReadOnlyList<float> Psi
        {
            get;
            set;
        }

        public IReadOnlyList<float> Curvature
        {
            get;
            set;
        }

        public uint QpIterations
        {
            get;
            set;
        }

        public ulong CalculationTime
        {
            get;
            set;
        }

        public double Cost
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public IReadOnlyList<float> X => ctx.ReadList(0).CastFloat();
            public IReadOnlyList<float> Y => ctx.ReadList(1).CastFloat();
            public IReadOnlyList<float> Psi => ctx.ReadList(2).CastFloat();
            public IReadOnlyList<float> Curvature => ctx.ReadList(3).CastFloat();
            public uint QpIterations => ctx.ReadDataUInt(0UL, 0U);
            public ulong CalculationTime => ctx.ReadDataULong(64UL, 0UL);
            public double Cost => ctx.ReadDataDouble(128UL, 0);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(3, 4);
            }

            public ListOfPrimitivesSerializer<float> X
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(0);
                set => Link(0, value);
            }

            public ListOfPrimitivesSerializer<float> Y
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(1);
                set => Link(1, value);
            }

            public ListOfPrimitivesSerializer<float> Psi
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(2);
                set => Link(2, value);
            }

            public ListOfPrimitivesSerializer<float> Curvature
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(3);
                set => Link(3, value);
            }

            public uint QpIterations
            {
                get => this.ReadDataUInt(0UL, 0U);
                set => this.WriteData(0UL, value, 0U);
            }

            public ulong CalculationTime
            {
                get => this.ReadDataULong(64UL, 0UL);
                set => this.WriteData(64UL, value, 0UL);
            }

            public double Cost
            {
                get => this.ReadDataDouble(128UL, 0);
                set => this.WriteData(128UL, value, 0);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xe7e17c434f865ae2UL)]
    public class LiveLongitudinalMpcData : ICapnpSerializable
    {
        public const UInt64 typeId = 0xe7e17c434f865ae2UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            XEgo = reader.XEgo;
            VEgo = reader.VEgo;
            AEgo = reader.AEgo;
            XLead = reader.XLead;
            VLead = reader.VLead;
            ALead = reader.ALead;
            ALeadTau = reader.ALeadTau;
            QpIterations = reader.QpIterations;
            MpcId = reader.MpcId;
            CalculationTime = reader.CalculationTime;
            Cost = reader.Cost;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.XEgo.Init(XEgo);
            writer.VEgo.Init(VEgo);
            writer.AEgo.Init(AEgo);
            writer.XLead.Init(XLead);
            writer.VLead.Init(VLead);
            writer.ALead.Init(ALead);
            writer.ALeadTau = ALeadTau;
            writer.QpIterations = QpIterations;
            writer.MpcId = MpcId;
            writer.CalculationTime = CalculationTime;
            writer.Cost = Cost;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public IReadOnlyList<float> XEgo
        {
            get;
            set;
        }

        public IReadOnlyList<float> VEgo
        {
            get;
            set;
        }

        public IReadOnlyList<float> AEgo
        {
            get;
            set;
        }

        public IReadOnlyList<float> XLead
        {
            get;
            set;
        }

        public IReadOnlyList<float> VLead
        {
            get;
            set;
        }

        public IReadOnlyList<float> ALead
        {
            get;
            set;
        }

        public float ALeadTau
        {
            get;
            set;
        }

        public uint QpIterations
        {
            get;
            set;
        }

        public uint MpcId
        {
            get;
            set;
        }

        public ulong CalculationTime
        {
            get;
            set;
        }

        public double Cost
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public IReadOnlyList<float> XEgo => ctx.ReadList(0).CastFloat();
            public IReadOnlyList<float> VEgo => ctx.ReadList(1).CastFloat();
            public IReadOnlyList<float> AEgo => ctx.ReadList(2).CastFloat();
            public IReadOnlyList<float> XLead => ctx.ReadList(3).CastFloat();
            public IReadOnlyList<float> VLead => ctx.ReadList(4).CastFloat();
            public IReadOnlyList<float> ALead => ctx.ReadList(5).CastFloat();
            public float ALeadTau => ctx.ReadDataFloat(0UL, 0F);
            public uint QpIterations => ctx.ReadDataUInt(32UL, 0U);
            public uint MpcId => ctx.ReadDataUInt(64UL, 0U);
            public ulong CalculationTime => ctx.ReadDataULong(128UL, 0UL);
            public double Cost => ctx.ReadDataDouble(192UL, 0);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(4, 6);
            }

            public ListOfPrimitivesSerializer<float> XEgo
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(0);
                set => Link(0, value);
            }

            public ListOfPrimitivesSerializer<float> VEgo
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(1);
                set => Link(1, value);
            }

            public ListOfPrimitivesSerializer<float> AEgo
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(2);
                set => Link(2, value);
            }

            public ListOfPrimitivesSerializer<float> XLead
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(3);
                set => Link(3, value);
            }

            public ListOfPrimitivesSerializer<float> VLead
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(4);
                set => Link(4, value);
            }

            public ListOfPrimitivesSerializer<float> ALead
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(5);
                set => Link(5, value);
            }

            public float ALeadTau
            {
                get => this.ReadDataFloat(0UL, 0F);
                set => this.WriteData(0UL, value, 0F);
            }

            public uint QpIterations
            {
                get => this.ReadDataUInt(32UL, 0U);
                set => this.WriteData(32UL, value, 0U);
            }

            public uint MpcId
            {
                get => this.ReadDataUInt(64UL, 0U);
                set => this.WriteData(64UL, value, 0U);
            }

            public ulong CalculationTime
            {
                get => this.ReadDataULong(128UL, 0UL);
                set => this.WriteData(128UL, value, 0UL);
            }

            public double Cost
            {
                get => this.ReadDataDouble(192UL, 0);
                set => this.WriteData(192UL, value, 0);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xe42401658e2715e2UL)]
    public class Joystick : ICapnpSerializable
    {
        public const UInt64 typeId = 0xe42401658e2715e2UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            Axes = reader.Axes;
            Buttons = reader.Buttons;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.Axes.Init(Axes);
            writer.Buttons.Init(Buttons);
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public IReadOnlyList<float> Axes
        {
            get;
            set;
        }

        public IReadOnlyList<bool> Buttons
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public IReadOnlyList<float> Axes => ctx.ReadList(0).CastFloat();
            public IReadOnlyList<bool> Buttons => ctx.ReadList(1).CastBool();
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(0, 2);
            }

            public ListOfPrimitivesSerializer<float> Axes
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(0);
                set => Link(0, value);
            }

            public ListOfBitsSerializer Buttons
            {
                get => BuildPointer<ListOfBitsSerializer>(1);
                set => Link(1, value);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xfc010c40147563b0UL)]
    public class DriverStateV2 : ICapnpSerializable
    {
        public const UInt64 typeId = 0xfc010c40147563b0UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            FrameId = reader.FrameId;
            ModelExecutionTime = reader.ModelExecutionTime;
            DspExecutionTime = reader.DspExecutionTime;
            RawPredictions = reader.RawPredictions;
            PoorVisionProb = reader.PoorVisionProb;
            WheelOnRightProb = reader.WheelOnRightProb;
            LeftDriverData = CapnpSerializable.Create<Cereal.DriverStateV2.DriverData>(reader.LeftDriverData);
            RightDriverData = CapnpSerializable.Create<Cereal.DriverStateV2.DriverData>(reader.RightDriverData);
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.FrameId = FrameId;
            writer.ModelExecutionTime = ModelExecutionTime;
            writer.DspExecutionTime = DspExecutionTime;
            writer.RawPredictions.Init(RawPredictions);
            writer.PoorVisionProb = PoorVisionProb;
            writer.WheelOnRightProb = WheelOnRightProb;
            LeftDriverData?.serialize(writer.LeftDriverData);
            RightDriverData?.serialize(writer.RightDriverData);
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public uint FrameId
        {
            get;
            set;
        }

        public float ModelExecutionTime
        {
            get;
            set;
        }

        public float DspExecutionTime
        {
            get;
            set;
        }

        public IReadOnlyList<byte> RawPredictions
        {
            get;
            set;
        }

        public float PoorVisionProb
        {
            get;
            set;
        }

        public float WheelOnRightProb
        {
            get;
            set;
        }

        public Cereal.DriverStateV2.DriverData LeftDriverData
        {
            get;
            set;
        }

        public Cereal.DriverStateV2.DriverData RightDriverData
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public uint FrameId => ctx.ReadDataUInt(0UL, 0U);
            public float ModelExecutionTime => ctx.ReadDataFloat(32UL, 0F);
            public float DspExecutionTime => ctx.ReadDataFloat(64UL, 0F);
            public IReadOnlyList<byte> RawPredictions => ctx.ReadList(0).CastByte();
            public float PoorVisionProb => ctx.ReadDataFloat(96UL, 0F);
            public float WheelOnRightProb => ctx.ReadDataFloat(128UL, 0F);
            public Cereal.DriverStateV2.DriverData.READER LeftDriverData => ctx.ReadStruct(1, Cereal.DriverStateV2.DriverData.READER.create);
            public Cereal.DriverStateV2.DriverData.READER RightDriverData => ctx.ReadStruct(2, Cereal.DriverStateV2.DriverData.READER.create);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(3, 3);
            }

            public uint FrameId
            {
                get => this.ReadDataUInt(0UL, 0U);
                set => this.WriteData(0UL, value, 0U);
            }

            public float ModelExecutionTime
            {
                get => this.ReadDataFloat(32UL, 0F);
                set => this.WriteData(32UL, value, 0F);
            }

            public float DspExecutionTime
            {
                get => this.ReadDataFloat(64UL, 0F);
                set => this.WriteData(64UL, value, 0F);
            }

            public ListOfPrimitivesSerializer<byte> RawPredictions
            {
                get => BuildPointer<ListOfPrimitivesSerializer<byte>>(0);
                set => Link(0, value);
            }

            public float PoorVisionProb
            {
                get => this.ReadDataFloat(96UL, 0F);
                set => this.WriteData(96UL, value, 0F);
            }

            public float WheelOnRightProb
            {
                get => this.ReadDataFloat(128UL, 0F);
                set => this.WriteData(128UL, value, 0F);
            }

            public Cereal.DriverStateV2.DriverData.WRITER LeftDriverData
            {
                get => BuildPointer<Cereal.DriverStateV2.DriverData.WRITER>(1);
                set => Link(1, value);
            }

            public Cereal.DriverStateV2.DriverData.WRITER RightDriverData
            {
                get => BuildPointer<Cereal.DriverStateV2.DriverData.WRITER>(2);
                set => Link(2, value);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xc9f73bb1cdf28a6aUL)]
        public class DriverData : ICapnpSerializable
        {
            public const UInt64 typeId = 0xc9f73bb1cdf28a6aUL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                FaceOrientation = reader.FaceOrientation;
                FaceOrientationStd = reader.FaceOrientationStd;
                FacePosition = reader.FacePosition;
                FacePositionStd = reader.FacePositionStd;
                FaceProb = reader.FaceProb;
                LeftEyeProb = reader.LeftEyeProb;
                RightEyeProb = reader.RightEyeProb;
                LeftBlinkProb = reader.LeftBlinkProb;
                RightBlinkProb = reader.RightBlinkProb;
                SunglassesProb = reader.SunglassesProb;
                OccludedProb = reader.OccludedProb;
                ReadyProb = reader.ReadyProb;
                NotReadyProb = reader.NotReadyProb;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.FaceOrientation.Init(FaceOrientation);
                writer.FaceOrientationStd.Init(FaceOrientationStd);
                writer.FacePosition.Init(FacePosition);
                writer.FacePositionStd.Init(FacePositionStd);
                writer.FaceProb = FaceProb;
                writer.LeftEyeProb = LeftEyeProb;
                writer.RightEyeProb = RightEyeProb;
                writer.LeftBlinkProb = LeftBlinkProb;
                writer.RightBlinkProb = RightBlinkProb;
                writer.SunglassesProb = SunglassesProb;
                writer.OccludedProb = OccludedProb;
                writer.ReadyProb.Init(ReadyProb);
                writer.NotReadyProb.Init(NotReadyProb);
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public IReadOnlyList<float> FaceOrientation
            {
                get;
                set;
            }

            public IReadOnlyList<float> FaceOrientationStd
            {
                get;
                set;
            }

            public IReadOnlyList<float> FacePosition
            {
                get;
                set;
            }

            public IReadOnlyList<float> FacePositionStd
            {
                get;
                set;
            }

            public float FaceProb
            {
                get;
                set;
            }

            public float LeftEyeProb
            {
                get;
                set;
            }

            public float RightEyeProb
            {
                get;
                set;
            }

            public float LeftBlinkProb
            {
                get;
                set;
            }

            public float RightBlinkProb
            {
                get;
                set;
            }

            public float SunglassesProb
            {
                get;
                set;
            }

            public float OccludedProb
            {
                get;
                set;
            }

            public IReadOnlyList<float> ReadyProb
            {
                get;
                set;
            }

            public IReadOnlyList<float> NotReadyProb
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public IReadOnlyList<float> FaceOrientation => ctx.ReadList(0).CastFloat();
                public IReadOnlyList<float> FaceOrientationStd => ctx.ReadList(1).CastFloat();
                public IReadOnlyList<float> FacePosition => ctx.ReadList(2).CastFloat();
                public IReadOnlyList<float> FacePositionStd => ctx.ReadList(3).CastFloat();
                public float FaceProb => ctx.ReadDataFloat(0UL, 0F);
                public float LeftEyeProb => ctx.ReadDataFloat(32UL, 0F);
                public float RightEyeProb => ctx.ReadDataFloat(64UL, 0F);
                public float LeftBlinkProb => ctx.ReadDataFloat(96UL, 0F);
                public float RightBlinkProb => ctx.ReadDataFloat(128UL, 0F);
                public float SunglassesProb => ctx.ReadDataFloat(160UL, 0F);
                public float OccludedProb => ctx.ReadDataFloat(192UL, 0F);
                public IReadOnlyList<float> ReadyProb => ctx.ReadList(4).CastFloat();
                public IReadOnlyList<float> NotReadyProb => ctx.ReadList(5).CastFloat();
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(4, 6);
                }

                public ListOfPrimitivesSerializer<float> FaceOrientation
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(0);
                    set => Link(0, value);
                }

                public ListOfPrimitivesSerializer<float> FaceOrientationStd
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(1);
                    set => Link(1, value);
                }

                public ListOfPrimitivesSerializer<float> FacePosition
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(2);
                    set => Link(2, value);
                }

                public ListOfPrimitivesSerializer<float> FacePositionStd
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(3);
                    set => Link(3, value);
                }

                public float FaceProb
                {
                    get => this.ReadDataFloat(0UL, 0F);
                    set => this.WriteData(0UL, value, 0F);
                }

                public float LeftEyeProb
                {
                    get => this.ReadDataFloat(32UL, 0F);
                    set => this.WriteData(32UL, value, 0F);
                }

                public float RightEyeProb
                {
                    get => this.ReadDataFloat(64UL, 0F);
                    set => this.WriteData(64UL, value, 0F);
                }

                public float LeftBlinkProb
                {
                    get => this.ReadDataFloat(96UL, 0F);
                    set => this.WriteData(96UL, value, 0F);
                }

                public float RightBlinkProb
                {
                    get => this.ReadDataFloat(128UL, 0F);
                    set => this.WriteData(128UL, value, 0F);
                }

                public float SunglassesProb
                {
                    get => this.ReadDataFloat(160UL, 0F);
                    set => this.WriteData(160UL, value, 0F);
                }

                public float OccludedProb
                {
                    get => this.ReadDataFloat(192UL, 0F);
                    set => this.WriteData(192UL, value, 0F);
                }

                public ListOfPrimitivesSerializer<float> ReadyProb
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(4);
                    set => Link(4, value);
                }

                public ListOfPrimitivesSerializer<float> NotReadyProb
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(5);
                    set => Link(5, value);
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xb83c6cc593ed0a00UL)]
    public class DriverStateDEPRECATED : ICapnpSerializable
    {
        public const UInt64 typeId = 0xb83c6cc593ed0a00UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            FrameId = reader.FrameId;
            DescriptorDEPRECATED = reader.DescriptorDEPRECATED;
            StdDEPRECATED = reader.StdDEPRECATED;
            FaceOrientation = reader.FaceOrientation;
            FacePosition = reader.FacePosition;
            FaceProb = reader.FaceProb;
            LeftEyeProb = reader.LeftEyeProb;
            RightEyeProb = reader.RightEyeProb;
            LeftBlinkProb = reader.LeftBlinkProb;
            RightBlinkProb = reader.RightBlinkProb;
            IrPwrDEPRECATED = reader.IrPwrDEPRECATED;
            FaceOrientationStd = reader.FaceOrientationStd;
            FacePositionStd = reader.FacePositionStd;
            SunglassesProb = reader.SunglassesProb;
            ModelExecutionTime = reader.ModelExecutionTime;
            RawPredictions = reader.RawPredictions;
            DspExecutionTime = reader.DspExecutionTime;
            PoorVision = reader.PoorVision;
            PartialFace = reader.PartialFace;
            DistractedPose = reader.DistractedPose;
            DistractedEyes = reader.DistractedEyes;
            EyesOnRoad = reader.EyesOnRoad;
            PhoneUse = reader.PhoneUse;
            OccludedProb = reader.OccludedProb;
            ReadyProb = reader.ReadyProb;
            NotReadyProb = reader.NotReadyProb;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.FrameId = FrameId;
            writer.DescriptorDEPRECATED.Init(DescriptorDEPRECATED);
            writer.StdDEPRECATED = StdDEPRECATED;
            writer.FaceOrientation.Init(FaceOrientation);
            writer.FacePosition.Init(FacePosition);
            writer.FaceProb = FaceProb;
            writer.LeftEyeProb = LeftEyeProb;
            writer.RightEyeProb = RightEyeProb;
            writer.LeftBlinkProb = LeftBlinkProb;
            writer.RightBlinkProb = RightBlinkProb;
            writer.IrPwrDEPRECATED = IrPwrDEPRECATED;
            writer.FaceOrientationStd.Init(FaceOrientationStd);
            writer.FacePositionStd.Init(FacePositionStd);
            writer.SunglassesProb = SunglassesProb;
            writer.ModelExecutionTime = ModelExecutionTime;
            writer.RawPredictions.Init(RawPredictions);
            writer.DspExecutionTime = DspExecutionTime;
            writer.PoorVision = PoorVision;
            writer.PartialFace = PartialFace;
            writer.DistractedPose = DistractedPose;
            writer.DistractedEyes = DistractedEyes;
            writer.EyesOnRoad = EyesOnRoad;
            writer.PhoneUse = PhoneUse;
            writer.OccludedProb = OccludedProb;
            writer.ReadyProb.Init(ReadyProb);
            writer.NotReadyProb.Init(NotReadyProb);
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public uint FrameId
        {
            get;
            set;
        }

        public IReadOnlyList<float> DescriptorDEPRECATED
        {
            get;
            set;
        }

        public float StdDEPRECATED
        {
            get;
            set;
        }

        public IReadOnlyList<float> FaceOrientation
        {
            get;
            set;
        }

        public IReadOnlyList<float> FacePosition
        {
            get;
            set;
        }

        public float FaceProb
        {
            get;
            set;
        }

        public float LeftEyeProb
        {
            get;
            set;
        }

        public float RightEyeProb
        {
            get;
            set;
        }

        public float LeftBlinkProb
        {
            get;
            set;
        }

        public float RightBlinkProb
        {
            get;
            set;
        }

        public float IrPwrDEPRECATED
        {
            get;
            set;
        }

        public IReadOnlyList<float> FaceOrientationStd
        {
            get;
            set;
        }

        public IReadOnlyList<float> FacePositionStd
        {
            get;
            set;
        }

        public float SunglassesProb
        {
            get;
            set;
        }

        public float ModelExecutionTime
        {
            get;
            set;
        }

        public IReadOnlyList<byte> RawPredictions
        {
            get;
            set;
        }

        public float DspExecutionTime
        {
            get;
            set;
        }

        public float PoorVision
        {
            get;
            set;
        }

        public float PartialFace
        {
            get;
            set;
        }

        public float DistractedPose
        {
            get;
            set;
        }

        public float DistractedEyes
        {
            get;
            set;
        }

        public float EyesOnRoad
        {
            get;
            set;
        }

        public float PhoneUse
        {
            get;
            set;
        }

        public float OccludedProb
        {
            get;
            set;
        }

        public IReadOnlyList<float> ReadyProb
        {
            get;
            set;
        }

        public IReadOnlyList<float> NotReadyProb
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public uint FrameId => ctx.ReadDataUInt(0UL, 0U);
            public IReadOnlyList<float> DescriptorDEPRECATED => ctx.ReadList(0).CastFloat();
            public float StdDEPRECATED => ctx.ReadDataFloat(32UL, 0F);
            public IReadOnlyList<float> FaceOrientation => ctx.ReadList(1).CastFloat();
            public IReadOnlyList<float> FacePosition => ctx.ReadList(2).CastFloat();
            public float FaceProb => ctx.ReadDataFloat(64UL, 0F);
            public float LeftEyeProb => ctx.ReadDataFloat(96UL, 0F);
            public float RightEyeProb => ctx.ReadDataFloat(128UL, 0F);
            public float LeftBlinkProb => ctx.ReadDataFloat(160UL, 0F);
            public float RightBlinkProb => ctx.ReadDataFloat(192UL, 0F);
            public float IrPwrDEPRECATED => ctx.ReadDataFloat(224UL, 0F);
            public IReadOnlyList<float> FaceOrientationStd => ctx.ReadList(3).CastFloat();
            public IReadOnlyList<float> FacePositionStd => ctx.ReadList(4).CastFloat();
            public float SunglassesProb => ctx.ReadDataFloat(256UL, 0F);
            public float ModelExecutionTime => ctx.ReadDataFloat(288UL, 0F);
            public IReadOnlyList<byte> RawPredictions => ctx.ReadList(5).CastByte();
            public float DspExecutionTime => ctx.ReadDataFloat(320UL, 0F);
            public float PoorVision => ctx.ReadDataFloat(352UL, 0F);
            public float PartialFace => ctx.ReadDataFloat(384UL, 0F);
            public float DistractedPose => ctx.ReadDataFloat(416UL, 0F);
            public float DistractedEyes => ctx.ReadDataFloat(448UL, 0F);
            public float EyesOnRoad => ctx.ReadDataFloat(480UL, 0F);
            public float PhoneUse => ctx.ReadDataFloat(512UL, 0F);
            public float OccludedProb => ctx.ReadDataFloat(544UL, 0F);
            public IReadOnlyList<float> ReadyProb => ctx.ReadList(6).CastFloat();
            public IReadOnlyList<float> NotReadyProb => ctx.ReadList(7).CastFloat();
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(9, 8);
            }

            public uint FrameId
            {
                get => this.ReadDataUInt(0UL, 0U);
                set => this.WriteData(0UL, value, 0U);
            }

            public ListOfPrimitivesSerializer<float> DescriptorDEPRECATED
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(0);
                set => Link(0, value);
            }

            public float StdDEPRECATED
            {
                get => this.ReadDataFloat(32UL, 0F);
                set => this.WriteData(32UL, value, 0F);
            }

            public ListOfPrimitivesSerializer<float> FaceOrientation
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(1);
                set => Link(1, value);
            }

            public ListOfPrimitivesSerializer<float> FacePosition
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(2);
                set => Link(2, value);
            }

            public float FaceProb
            {
                get => this.ReadDataFloat(64UL, 0F);
                set => this.WriteData(64UL, value, 0F);
            }

            public float LeftEyeProb
            {
                get => this.ReadDataFloat(96UL, 0F);
                set => this.WriteData(96UL, value, 0F);
            }

            public float RightEyeProb
            {
                get => this.ReadDataFloat(128UL, 0F);
                set => this.WriteData(128UL, value, 0F);
            }

            public float LeftBlinkProb
            {
                get => this.ReadDataFloat(160UL, 0F);
                set => this.WriteData(160UL, value, 0F);
            }

            public float RightBlinkProb
            {
                get => this.ReadDataFloat(192UL, 0F);
                set => this.WriteData(192UL, value, 0F);
            }

            public float IrPwrDEPRECATED
            {
                get => this.ReadDataFloat(224UL, 0F);
                set => this.WriteData(224UL, value, 0F);
            }

            public ListOfPrimitivesSerializer<float> FaceOrientationStd
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(3);
                set => Link(3, value);
            }

            public ListOfPrimitivesSerializer<float> FacePositionStd
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(4);
                set => Link(4, value);
            }

            public float SunglassesProb
            {
                get => this.ReadDataFloat(256UL, 0F);
                set => this.WriteData(256UL, value, 0F);
            }

            public float ModelExecutionTime
            {
                get => this.ReadDataFloat(288UL, 0F);
                set => this.WriteData(288UL, value, 0F);
            }

            public ListOfPrimitivesSerializer<byte> RawPredictions
            {
                get => BuildPointer<ListOfPrimitivesSerializer<byte>>(5);
                set => Link(5, value);
            }

            public float DspExecutionTime
            {
                get => this.ReadDataFloat(320UL, 0F);
                set => this.WriteData(320UL, value, 0F);
            }

            public float PoorVision
            {
                get => this.ReadDataFloat(352UL, 0F);
                set => this.WriteData(352UL, value, 0F);
            }

            public float PartialFace
            {
                get => this.ReadDataFloat(384UL, 0F);
                set => this.WriteData(384UL, value, 0F);
            }

            public float DistractedPose
            {
                get => this.ReadDataFloat(416UL, 0F);
                set => this.WriteData(416UL, value, 0F);
            }

            public float DistractedEyes
            {
                get => this.ReadDataFloat(448UL, 0F);
                set => this.WriteData(448UL, value, 0F);
            }

            public float EyesOnRoad
            {
                get => this.ReadDataFloat(480UL, 0F);
                set => this.WriteData(480UL, value, 0F);
            }

            public float PhoneUse
            {
                get => this.ReadDataFloat(512UL, 0F);
                set => this.WriteData(512UL, value, 0F);
            }

            public float OccludedProb
            {
                get => this.ReadDataFloat(544UL, 0F);
                set => this.WriteData(544UL, value, 0F);
            }

            public ListOfPrimitivesSerializer<float> ReadyProb
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(6);
                set => Link(6, value);
            }

            public ListOfPrimitivesSerializer<float> NotReadyProb
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(7);
                set => Link(7, value);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xb83cda094a1da284UL)]
    public class DriverMonitoringState : ICapnpSerializable
    {
        public const UInt64 typeId = 0xb83cda094a1da284UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            Events = reader.Events?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.CarEvent>(_));
            FaceDetected = reader.FaceDetected;
            IsDistracted = reader.IsDistracted;
            AwarenessStatus = reader.AwarenessStatus;
            IsRHD = reader.IsRHD;
            RhdCheckedDEPRECATED = reader.RhdCheckedDEPRECATED;
            PosePitchOffset = reader.PosePitchOffset;
            PosePitchValidCount = reader.PosePitchValidCount;
            PoseYawOffset = reader.PoseYawOffset;
            PoseYawValidCount = reader.PoseYawValidCount;
            StepChange = reader.StepChange;
            AwarenessActive = reader.AwarenessActive;
            AwarenessPassive = reader.AwarenessPassive;
            IsLowStd = reader.IsLowStd;
            HiStdCount = reader.HiStdCount;
            IsPreviewDEPRECATED = reader.IsPreviewDEPRECATED;
            IsActiveMode = reader.IsActiveMode;
            DistractedType = reader.DistractedType;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.Events.Init(Events, (_s1, _v1) => _v1?.serialize(_s1));
            writer.FaceDetected = FaceDetected;
            writer.IsDistracted = IsDistracted;
            writer.AwarenessStatus = AwarenessStatus;
            writer.IsRHD = IsRHD;
            writer.RhdCheckedDEPRECATED = RhdCheckedDEPRECATED;
            writer.PosePitchOffset = PosePitchOffset;
            writer.PosePitchValidCount = PosePitchValidCount;
            writer.PoseYawOffset = PoseYawOffset;
            writer.PoseYawValidCount = PoseYawValidCount;
            writer.StepChange = StepChange;
            writer.AwarenessActive = AwarenessActive;
            writer.AwarenessPassive = AwarenessPassive;
            writer.IsLowStd = IsLowStd;
            writer.HiStdCount = HiStdCount;
            writer.IsPreviewDEPRECATED = IsPreviewDEPRECATED;
            writer.IsActiveMode = IsActiveMode;
            writer.DistractedType = DistractedType;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public IReadOnlyList<Cereal.CarEvent> Events
        {
            get;
            set;
        }

        public bool FaceDetected
        {
            get;
            set;
        }

        public bool IsDistracted
        {
            get;
            set;
        }

        public float AwarenessStatus
        {
            get;
            set;
        }

        public bool IsRHD
        {
            get;
            set;
        }

        public bool RhdCheckedDEPRECATED
        {
            get;
            set;
        }

        public float PosePitchOffset
        {
            get;
            set;
        }

        public uint PosePitchValidCount
        {
            get;
            set;
        }

        public float PoseYawOffset
        {
            get;
            set;
        }

        public uint PoseYawValidCount
        {
            get;
            set;
        }

        public float StepChange
        {
            get;
            set;
        }

        public float AwarenessActive
        {
            get;
            set;
        }

        public float AwarenessPassive
        {
            get;
            set;
        }

        public bool IsLowStd
        {
            get;
            set;
        }

        public uint HiStdCount
        {
            get;
            set;
        }

        public bool IsPreviewDEPRECATED
        {
            get;
            set;
        }

        public bool IsActiveMode
        {
            get;
            set;
        }

        public uint DistractedType
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public IReadOnlyList<Cereal.CarEvent.READER> Events => ctx.ReadList(0).Cast(Cereal.CarEvent.READER.create);
            public bool FaceDetected => ctx.ReadDataBool(0UL, false);
            public bool IsDistracted => ctx.ReadDataBool(1UL, false);
            public float AwarenessStatus => ctx.ReadDataFloat(32UL, 0F);
            public bool IsRHD => ctx.ReadDataBool(2UL, false);
            public bool RhdCheckedDEPRECATED => ctx.ReadDataBool(3UL, false);
            public float PosePitchOffset => ctx.ReadDataFloat(64UL, 0F);
            public uint PosePitchValidCount => ctx.ReadDataUInt(96UL, 0U);
            public float PoseYawOffset => ctx.ReadDataFloat(128UL, 0F);
            public uint PoseYawValidCount => ctx.ReadDataUInt(160UL, 0U);
            public float StepChange => ctx.ReadDataFloat(192UL, 0F);
            public float AwarenessActive => ctx.ReadDataFloat(224UL, 0F);
            public float AwarenessPassive => ctx.ReadDataFloat(256UL, 0F);
            public bool IsLowStd => ctx.ReadDataBool(4UL, false);
            public uint HiStdCount => ctx.ReadDataUInt(288UL, 0U);
            public bool IsPreviewDEPRECATED => ctx.ReadDataBool(5UL, false);
            public bool IsActiveMode => ctx.ReadDataBool(6UL, false);
            public uint DistractedType => ctx.ReadDataUInt(320UL, 0U);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(6, 1);
            }

            public ListOfStructsSerializer<Cereal.CarEvent.WRITER> Events
            {
                get => BuildPointer<ListOfStructsSerializer<Cereal.CarEvent.WRITER>>(0);
                set => Link(0, value);
            }

            public bool FaceDetected
            {
                get => this.ReadDataBool(0UL, false);
                set => this.WriteData(0UL, value, false);
            }

            public bool IsDistracted
            {
                get => this.ReadDataBool(1UL, false);
                set => this.WriteData(1UL, value, false);
            }

            public float AwarenessStatus
            {
                get => this.ReadDataFloat(32UL, 0F);
                set => this.WriteData(32UL, value, 0F);
            }

            public bool IsRHD
            {
                get => this.ReadDataBool(2UL, false);
                set => this.WriteData(2UL, value, false);
            }

            public bool RhdCheckedDEPRECATED
            {
                get => this.ReadDataBool(3UL, false);
                set => this.WriteData(3UL, value, false);
            }

            public float PosePitchOffset
            {
                get => this.ReadDataFloat(64UL, 0F);
                set => this.WriteData(64UL, value, 0F);
            }

            public uint PosePitchValidCount
            {
                get => this.ReadDataUInt(96UL, 0U);
                set => this.WriteData(96UL, value, 0U);
            }

            public float PoseYawOffset
            {
                get => this.ReadDataFloat(128UL, 0F);
                set => this.WriteData(128UL, value, 0F);
            }

            public uint PoseYawValidCount
            {
                get => this.ReadDataUInt(160UL, 0U);
                set => this.WriteData(160UL, value, 0U);
            }

            public float StepChange
            {
                get => this.ReadDataFloat(192UL, 0F);
                set => this.WriteData(192UL, value, 0F);
            }

            public float AwarenessActive
            {
                get => this.ReadDataFloat(224UL, 0F);
                set => this.WriteData(224UL, value, 0F);
            }

            public float AwarenessPassive
            {
                get => this.ReadDataFloat(256UL, 0F);
                set => this.WriteData(256UL, value, 0F);
            }

            public bool IsLowStd
            {
                get => this.ReadDataBool(4UL, false);
                set => this.WriteData(4UL, value, false);
            }

            public uint HiStdCount
            {
                get => this.ReadDataUInt(288UL, 0U);
                set => this.WriteData(288UL, value, 0U);
            }

            public bool IsPreviewDEPRECATED
            {
                get => this.ReadDataBool(5UL, false);
                set => this.WriteData(5UL, value, false);
            }

            public bool IsActiveMode
            {
                get => this.ReadDataBool(6UL, false);
                set => this.WriteData(6UL, value, false);
            }

            public uint DistractedType
            {
                get => this.ReadDataUInt(320UL, 0U);
                set => this.WriteData(320UL, value, 0U);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xa12e8670927a2549UL)]
    public class Boot : ICapnpSerializable
    {
        public const UInt64 typeId = 0xa12e8670927a2549UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            WallTimeNanos = reader.WallTimeNanos;
            LastKmsgDEPRECATED = reader.LastKmsgDEPRECATED;
            LastPmsgDEPRECATED = reader.LastPmsgDEPRECATED;
            LaunchLog = reader.LaunchLog;
            Pstore = CapnpSerializable.Create<Cereal.Map<string, IReadOnlyList<byte>>>(reader.Pstore);
            Commands = CapnpSerializable.Create<Cereal.Map<string, IReadOnlyList<byte>>>(reader.Commands);
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.WallTimeNanos = WallTimeNanos;
            writer.LastKmsgDEPRECATED.Init(LastKmsgDEPRECATED);
            writer.LastPmsgDEPRECATED.Init(LastPmsgDEPRECATED);
            writer.LaunchLog = LaunchLog;
            Pstore?.serialize(writer.Pstore);
            Commands?.serialize(writer.Commands);
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public ulong WallTimeNanos
        {
            get;
            set;
        }

        public IReadOnlyList<byte> LastKmsgDEPRECATED
        {
            get;
            set;
        }

        public IReadOnlyList<byte> LastPmsgDEPRECATED
        {
            get;
            set;
        }

        public string LaunchLog
        {
            get;
            set;
        }

        public Cereal.Map<string, IReadOnlyList<byte>> Pstore
        {
            get;
            set;
        }

        public Cereal.Map<string, IReadOnlyList<byte>> Commands
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public ulong WallTimeNanos => ctx.ReadDataULong(0UL, 0UL);
            public IReadOnlyList<byte> LastKmsgDEPRECATED => ctx.ReadList(0).CastByte();
            public IReadOnlyList<byte> LastPmsgDEPRECATED => ctx.ReadList(1).CastByte();
            public string LaunchLog => ctx.ReadText(2, null);
            public Cereal.Map<string, IReadOnlyList<byte>>.READER Pstore => ctx.ReadStruct(3, Cereal.Map<string, IReadOnlyList<byte>>.READER.create);
            public Cereal.Map<string, IReadOnlyList<byte>>.READER Commands => ctx.ReadStruct(4, Cereal.Map<string, IReadOnlyList<byte>>.READER.create);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(1, 5);
            }

            public ulong WallTimeNanos
            {
                get => this.ReadDataULong(0UL, 0UL);
                set => this.WriteData(0UL, value, 0UL);
            }

            public ListOfPrimitivesSerializer<byte> LastKmsgDEPRECATED
            {
                get => BuildPointer<ListOfPrimitivesSerializer<byte>>(0);
                set => Link(0, value);
            }

            public ListOfPrimitivesSerializer<byte> LastPmsgDEPRECATED
            {
                get => BuildPointer<ListOfPrimitivesSerializer<byte>>(1);
                set => Link(1, value);
            }

            public string LaunchLog
            {
                get => this.ReadText(2, null);
                set => this.WriteText(2, value, null);
            }

            public Cereal.Map<string, IReadOnlyList<byte>>.WRITER Pstore
            {
                get => BuildPointer<Cereal.Map<string, IReadOnlyList<byte>>.WRITER>(3);
                set => Link(3, value);
            }

            public Cereal.Map<string, IReadOnlyList<byte>>.WRITER Commands
            {
                get => BuildPointer<Cereal.Map<string, IReadOnlyList<byte>>.WRITER>(4);
                set => Link(4, value);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xd9058dcb967c2753UL)]
    public class LiveParametersData : ICapnpSerializable
    {
        public const UInt64 typeId = 0xd9058dcb967c2753UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            Valid = reader.Valid;
            GyroBias = reader.GyroBias;
            AngleOffsetDeg = reader.AngleOffsetDeg;
            AngleOffsetAverageDeg = reader.AngleOffsetAverageDeg;
            StiffnessFactor = reader.StiffnessFactor;
            SteerRatio = reader.SteerRatio;
            SensorValid = reader.SensorValid;
            YawRateDEPRECATED = reader.YawRateDEPRECATED;
            PosenetSpeed = reader.PosenetSpeed;
            PosenetValid = reader.PosenetValid;
            AngleOffsetFastStd = reader.AngleOffsetFastStd;
            AngleOffsetAverageStd = reader.AngleOffsetAverageStd;
            StiffnessFactorStd = reader.StiffnessFactorStd;
            SteerRatioStd = reader.SteerRatioStd;
            Roll = reader.Roll;
            FilterState = CapnpSerializable.Create<Cereal.LiveLocationKalman.Measurement>(reader.FilterState);
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.Valid = Valid;
            writer.GyroBias = GyroBias;
            writer.AngleOffsetDeg = AngleOffsetDeg;
            writer.AngleOffsetAverageDeg = AngleOffsetAverageDeg;
            writer.StiffnessFactor = StiffnessFactor;
            writer.SteerRatio = SteerRatio;
            writer.SensorValid = SensorValid;
            writer.YawRateDEPRECATED = YawRateDEPRECATED;
            writer.PosenetSpeed = PosenetSpeed;
            writer.PosenetValid = PosenetValid;
            writer.AngleOffsetFastStd = AngleOffsetFastStd;
            writer.AngleOffsetAverageStd = AngleOffsetAverageStd;
            writer.StiffnessFactorStd = StiffnessFactorStd;
            writer.SteerRatioStd = SteerRatioStd;
            writer.Roll = Roll;
            FilterState?.serialize(writer.FilterState);
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public bool Valid
        {
            get;
            set;
        }

        public float GyroBias
        {
            get;
            set;
        }

        public float AngleOffsetDeg
        {
            get;
            set;
        }

        public float AngleOffsetAverageDeg
        {
            get;
            set;
        }

        public float StiffnessFactor
        {
            get;
            set;
        }

        public float SteerRatio
        {
            get;
            set;
        }

        public bool SensorValid
        {
            get;
            set;
        }

        public float YawRateDEPRECATED
        {
            get;
            set;
        }

        public float PosenetSpeed
        {
            get;
            set;
        }

        public bool PosenetValid
        {
            get;
            set;
        }

        public float AngleOffsetFastStd
        {
            get;
            set;
        }

        public float AngleOffsetAverageStd
        {
            get;
            set;
        }

        public float StiffnessFactorStd
        {
            get;
            set;
        }

        public float SteerRatioStd
        {
            get;
            set;
        }

        public float Roll
        {
            get;
            set;
        }

        public Cereal.LiveLocationKalman.Measurement FilterState
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public bool Valid => ctx.ReadDataBool(0UL, false);
            public float GyroBias => ctx.ReadDataFloat(32UL, 0F);
            public float AngleOffsetDeg => ctx.ReadDataFloat(64UL, 0F);
            public float AngleOffsetAverageDeg => ctx.ReadDataFloat(96UL, 0F);
            public float StiffnessFactor => ctx.ReadDataFloat(128UL, 0F);
            public float SteerRatio => ctx.ReadDataFloat(160UL, 0F);
            public bool SensorValid => ctx.ReadDataBool(1UL, false);
            public float YawRateDEPRECATED => ctx.ReadDataFloat(192UL, 0F);
            public float PosenetSpeed => ctx.ReadDataFloat(224UL, 0F);
            public bool PosenetValid => ctx.ReadDataBool(2UL, false);
            public float AngleOffsetFastStd => ctx.ReadDataFloat(256UL, 0F);
            public float AngleOffsetAverageStd => ctx.ReadDataFloat(288UL, 0F);
            public float StiffnessFactorStd => ctx.ReadDataFloat(320UL, 0F);
            public float SteerRatioStd => ctx.ReadDataFloat(352UL, 0F);
            public float Roll => ctx.ReadDataFloat(384UL, 0F);
            public Cereal.LiveLocationKalman.Measurement.READER FilterState => ctx.ReadStruct(0, Cereal.LiveLocationKalman.Measurement.READER.create);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(7, 1);
            }

            public bool Valid
            {
                get => this.ReadDataBool(0UL, false);
                set => this.WriteData(0UL, value, false);
            }

            public float GyroBias
            {
                get => this.ReadDataFloat(32UL, 0F);
                set => this.WriteData(32UL, value, 0F);
            }

            public float AngleOffsetDeg
            {
                get => this.ReadDataFloat(64UL, 0F);
                set => this.WriteData(64UL, value, 0F);
            }

            public float AngleOffsetAverageDeg
            {
                get => this.ReadDataFloat(96UL, 0F);
                set => this.WriteData(96UL, value, 0F);
            }

            public float StiffnessFactor
            {
                get => this.ReadDataFloat(128UL, 0F);
                set => this.WriteData(128UL, value, 0F);
            }

            public float SteerRatio
            {
                get => this.ReadDataFloat(160UL, 0F);
                set => this.WriteData(160UL, value, 0F);
            }

            public bool SensorValid
            {
                get => this.ReadDataBool(1UL, false);
                set => this.WriteData(1UL, value, false);
            }

            public float YawRateDEPRECATED
            {
                get => this.ReadDataFloat(192UL, 0F);
                set => this.WriteData(192UL, value, 0F);
            }

            public float PosenetSpeed
            {
                get => this.ReadDataFloat(224UL, 0F);
                set => this.WriteData(224UL, value, 0F);
            }

            public bool PosenetValid
            {
                get => this.ReadDataBool(2UL, false);
                set => this.WriteData(2UL, value, false);
            }

            public float AngleOffsetFastStd
            {
                get => this.ReadDataFloat(256UL, 0F);
                set => this.WriteData(256UL, value, 0F);
            }

            public float AngleOffsetAverageStd
            {
                get => this.ReadDataFloat(288UL, 0F);
                set => this.WriteData(288UL, value, 0F);
            }

            public float StiffnessFactorStd
            {
                get => this.ReadDataFloat(320UL, 0F);
                set => this.WriteData(320UL, value, 0F);
            }

            public float SteerRatioStd
            {
                get => this.ReadDataFloat(352UL, 0F);
                set => this.WriteData(352UL, value, 0F);
            }

            public float Roll
            {
                get => this.ReadDataFloat(384UL, 0F);
                set => this.WriteData(384UL, value, 0F);
            }

            public Cereal.LiveLocationKalman.Measurement.WRITER FilterState
            {
                get => BuildPointer<Cereal.LiveLocationKalman.Measurement.WRITER>(0);
                set => Link(0, value);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xe61690eb0b091692UL)]
    public class LiveTorqueParametersData : ICapnpSerializable
    {
        public const UInt64 typeId = 0xe61690eb0b091692UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            LiveValid = reader.LiveValid;
            LatAccelFactorRaw = reader.LatAccelFactorRaw;
            LatAccelOffsetRaw = reader.LatAccelOffsetRaw;
            FrictionCoefficientRaw = reader.FrictionCoefficientRaw;
            LatAccelFactorFiltered = reader.LatAccelFactorFiltered;
            LatAccelOffsetFiltered = reader.LatAccelOffsetFiltered;
            FrictionCoefficientFiltered = reader.FrictionCoefficientFiltered;
            TotalBucketPoints = reader.TotalBucketPoints;
            Decay = reader.Decay;
            MaxResets = reader.MaxResets;
            Points = reader.Points;
            Version = reader.Version;
            UseParams = reader.UseParams;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.LiveValid = LiveValid;
            writer.LatAccelFactorRaw = LatAccelFactorRaw;
            writer.LatAccelOffsetRaw = LatAccelOffsetRaw;
            writer.FrictionCoefficientRaw = FrictionCoefficientRaw;
            writer.LatAccelFactorFiltered = LatAccelFactorFiltered;
            writer.LatAccelOffsetFiltered = LatAccelOffsetFiltered;
            writer.FrictionCoefficientFiltered = FrictionCoefficientFiltered;
            writer.TotalBucketPoints = TotalBucketPoints;
            writer.Decay = Decay;
            writer.MaxResets = MaxResets;
            writer.Points.Init(Points, (_s2, _v2) => _s2.Init(_v2));
            writer.Version = Version;
            writer.UseParams = UseParams;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public bool LiveValid
        {
            get;
            set;
        }

        public float LatAccelFactorRaw
        {
            get;
            set;
        }

        public float LatAccelOffsetRaw
        {
            get;
            set;
        }

        public float FrictionCoefficientRaw
        {
            get;
            set;
        }

        public float LatAccelFactorFiltered
        {
            get;
            set;
        }

        public float LatAccelOffsetFiltered
        {
            get;
            set;
        }

        public float FrictionCoefficientFiltered
        {
            get;
            set;
        }

        public float TotalBucketPoints
        {
            get;
            set;
        }

        public float Decay
        {
            get;
            set;
        }

        public float MaxResets
        {
            get;
            set;
        }

        public IReadOnlyList<IReadOnlyList<float>> Points
        {
            get;
            set;
        }

        public int Version
        {
            get;
            set;
        }

        public bool UseParams
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public bool LiveValid => ctx.ReadDataBool(0UL, false);
            public float LatAccelFactorRaw => ctx.ReadDataFloat(32UL, 0F);
            public float LatAccelOffsetRaw => ctx.ReadDataFloat(64UL, 0F);
            public float FrictionCoefficientRaw => ctx.ReadDataFloat(96UL, 0F);
            public float LatAccelFactorFiltered => ctx.ReadDataFloat(128UL, 0F);
            public float LatAccelOffsetFiltered => ctx.ReadDataFloat(160UL, 0F);
            public float FrictionCoefficientFiltered => ctx.ReadDataFloat(192UL, 0F);
            public float TotalBucketPoints => ctx.ReadDataFloat(224UL, 0F);
            public float Decay => ctx.ReadDataFloat(256UL, 0F);
            public float MaxResets => ctx.ReadDataFloat(288UL, 0F);
            public IReadOnlyList<IReadOnlyList<float>> Points => ctx.ReadList(0).Cast(_0 => _0.RequireList().CastFloat());
            public int Version => ctx.ReadDataInt(320UL, 0);
            public bool UseParams => ctx.ReadDataBool(1UL, false);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(6, 1);
            }

            public bool LiveValid
            {
                get => this.ReadDataBool(0UL, false);
                set => this.WriteData(0UL, value, false);
            }

            public float LatAccelFactorRaw
            {
                get => this.ReadDataFloat(32UL, 0F);
                set => this.WriteData(32UL, value, 0F);
            }

            public float LatAccelOffsetRaw
            {
                get => this.ReadDataFloat(64UL, 0F);
                set => this.WriteData(64UL, value, 0F);
            }

            public float FrictionCoefficientRaw
            {
                get => this.ReadDataFloat(96UL, 0F);
                set => this.WriteData(96UL, value, 0F);
            }

            public float LatAccelFactorFiltered
            {
                get => this.ReadDataFloat(128UL, 0F);
                set => this.WriteData(128UL, value, 0F);
            }

            public float LatAccelOffsetFiltered
            {
                get => this.ReadDataFloat(160UL, 0F);
                set => this.WriteData(160UL, value, 0F);
            }

            public float FrictionCoefficientFiltered
            {
                get => this.ReadDataFloat(192UL, 0F);
                set => this.WriteData(192UL, value, 0F);
            }

            public float TotalBucketPoints
            {
                get => this.ReadDataFloat(224UL, 0F);
                set => this.WriteData(224UL, value, 0F);
            }

            public float Decay
            {
                get => this.ReadDataFloat(256UL, 0F);
                set => this.WriteData(256UL, value, 0F);
            }

            public float MaxResets
            {
                get => this.ReadDataFloat(288UL, 0F);
                set => this.WriteData(288UL, value, 0F);
            }

            public ListOfPointersSerializer<ListOfPrimitivesSerializer<float>> Points
            {
                get => BuildPointer<ListOfPointersSerializer<ListOfPrimitivesSerializer<float>>>(0);
                set => Link(0, value);
            }

            public int Version
            {
                get => this.ReadDataInt(320UL, 0);
                set => this.WriteData(320UL, value, 0);
            }

            public bool UseParams
            {
                get => this.ReadDataBool(1UL, false);
                set => this.WriteData(1UL, value, false);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x943e268f93f711a6UL)]
    public class LiveMapDataDEPRECATED : ICapnpSerializable
    {
        public const UInt64 typeId = 0x943e268f93f711a6UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            SpeedLimitValid = reader.SpeedLimitValid;
            SpeedLimit = reader.SpeedLimit;
            CurvatureValid = reader.CurvatureValid;
            Curvature = reader.Curvature;
            WayId = reader.WayId;
            RoadX = reader.RoadX;
            RoadY = reader.RoadY;
            LastGps = CapnpSerializable.Create<Cereal.GpsLocationData>(reader.LastGps);
            RoadCurvatureX = reader.RoadCurvatureX;
            RoadCurvature = reader.RoadCurvature;
            DistToTurn = reader.DistToTurn;
            MapValid = reader.MapValid;
            SpeedAdvisoryValid = reader.SpeedAdvisoryValid;
            SpeedAdvisory = reader.SpeedAdvisory;
            SpeedLimitAheadValid = reader.SpeedLimitAheadValid;
            SpeedLimitAhead = reader.SpeedLimitAhead;
            SpeedLimitAheadDistance = reader.SpeedLimitAheadDistance;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.SpeedLimitValid = SpeedLimitValid;
            writer.SpeedLimit = SpeedLimit;
            writer.CurvatureValid = CurvatureValid;
            writer.Curvature = Curvature;
            writer.WayId = WayId;
            writer.RoadX.Init(RoadX);
            writer.RoadY.Init(RoadY);
            LastGps?.serialize(writer.LastGps);
            writer.RoadCurvatureX.Init(RoadCurvatureX);
            writer.RoadCurvature.Init(RoadCurvature);
            writer.DistToTurn = DistToTurn;
            writer.MapValid = MapValid;
            writer.SpeedAdvisoryValid = SpeedAdvisoryValid;
            writer.SpeedAdvisory = SpeedAdvisory;
            writer.SpeedLimitAheadValid = SpeedLimitAheadValid;
            writer.SpeedLimitAhead = SpeedLimitAhead;
            writer.SpeedLimitAheadDistance = SpeedLimitAheadDistance;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public bool SpeedLimitValid
        {
            get;
            set;
        }

        public float SpeedLimit
        {
            get;
            set;
        }

        public bool CurvatureValid
        {
            get;
            set;
        }

        public float Curvature
        {
            get;
            set;
        }

        public ulong WayId
        {
            get;
            set;
        }

        public IReadOnlyList<float> RoadX
        {
            get;
            set;
        }

        public IReadOnlyList<float> RoadY
        {
            get;
            set;
        }

        public Cereal.GpsLocationData LastGps
        {
            get;
            set;
        }

        public IReadOnlyList<float> RoadCurvatureX
        {
            get;
            set;
        }

        public IReadOnlyList<float> RoadCurvature
        {
            get;
            set;
        }

        public float DistToTurn
        {
            get;
            set;
        }

        public bool MapValid
        {
            get;
            set;
        }

        public bool SpeedAdvisoryValid
        {
            get;
            set;
        }

        public float SpeedAdvisory
        {
            get;
            set;
        }

        public bool SpeedLimitAheadValid
        {
            get;
            set;
        }

        public float SpeedLimitAhead
        {
            get;
            set;
        }

        public float SpeedLimitAheadDistance
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public bool SpeedLimitValid => ctx.ReadDataBool(0UL, false);
            public float SpeedLimit => ctx.ReadDataFloat(32UL, 0F);
            public bool CurvatureValid => ctx.ReadDataBool(1UL, false);
            public float Curvature => ctx.ReadDataFloat(64UL, 0F);
            public ulong WayId => ctx.ReadDataULong(128UL, 0UL);
            public IReadOnlyList<float> RoadX => ctx.ReadList(0).CastFloat();
            public IReadOnlyList<float> RoadY => ctx.ReadList(1).CastFloat();
            public Cereal.GpsLocationData.READER LastGps => ctx.ReadStruct(2, Cereal.GpsLocationData.READER.create);
            public IReadOnlyList<float> RoadCurvatureX => ctx.ReadList(3).CastFloat();
            public IReadOnlyList<float> RoadCurvature => ctx.ReadList(4).CastFloat();
            public float DistToTurn => ctx.ReadDataFloat(96UL, 0F);
            public bool MapValid => ctx.ReadDataBool(2UL, false);
            public bool SpeedAdvisoryValid => ctx.ReadDataBool(3UL, false);
            public float SpeedAdvisory => ctx.ReadDataFloat(192UL, 0F);
            public bool SpeedLimitAheadValid => ctx.ReadDataBool(4UL, false);
            public float SpeedLimitAhead => ctx.ReadDataFloat(224UL, 0F);
            public float SpeedLimitAheadDistance => ctx.ReadDataFloat(256UL, 0F);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(5, 5);
            }

            public bool SpeedLimitValid
            {
                get => this.ReadDataBool(0UL, false);
                set => this.WriteData(0UL, value, false);
            }

            public float SpeedLimit
            {
                get => this.ReadDataFloat(32UL, 0F);
                set => this.WriteData(32UL, value, 0F);
            }

            public bool CurvatureValid
            {
                get => this.ReadDataBool(1UL, false);
                set => this.WriteData(1UL, value, false);
            }

            public float Curvature
            {
                get => this.ReadDataFloat(64UL, 0F);
                set => this.WriteData(64UL, value, 0F);
            }

            public ulong WayId
            {
                get => this.ReadDataULong(128UL, 0UL);
                set => this.WriteData(128UL, value, 0UL);
            }

            public ListOfPrimitivesSerializer<float> RoadX
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(0);
                set => Link(0, value);
            }

            public ListOfPrimitivesSerializer<float> RoadY
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(1);
                set => Link(1, value);
            }

            public Cereal.GpsLocationData.WRITER LastGps
            {
                get => BuildPointer<Cereal.GpsLocationData.WRITER>(2);
                set => Link(2, value);
            }

            public ListOfPrimitivesSerializer<float> RoadCurvatureX
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(3);
                set => Link(3, value);
            }

            public ListOfPrimitivesSerializer<float> RoadCurvature
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(4);
                set => Link(4, value);
            }

            public float DistToTurn
            {
                get => this.ReadDataFloat(96UL, 0F);
                set => this.WriteData(96UL, value, 0F);
            }

            public bool MapValid
            {
                get => this.ReadDataBool(2UL, false);
                set => this.WriteData(2UL, value, false);
            }

            public bool SpeedAdvisoryValid
            {
                get => this.ReadDataBool(3UL, false);
                set => this.WriteData(3UL, value, false);
            }

            public float SpeedAdvisory
            {
                get => this.ReadDataFloat(192UL, 0F);
                set => this.WriteData(192UL, value, 0F);
            }

            public bool SpeedLimitAheadValid
            {
                get => this.ReadDataBool(4UL, false);
                set => this.WriteData(4UL, value, false);
            }

            public float SpeedLimitAhead
            {
                get => this.ReadDataFloat(224UL, 0F);
                set => this.WriteData(224UL, value, 0F);
            }

            public float SpeedLimitAheadDistance
            {
                get => this.ReadDataFloat(256UL, 0F);
                set => this.WriteData(256UL, value, 0F);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xfa9a296b9fd41a96UL)]
    public class CameraOdometry : ICapnpSerializable
    {
        public const UInt64 typeId = 0xfa9a296b9fd41a96UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            Trans = reader.Trans;
            Rot = reader.Rot;
            TransStd = reader.TransStd;
            RotStd = reader.RotStd;
            FrameId = reader.FrameId;
            TimestampEof = reader.TimestampEof;
            WideFromDeviceEuler = reader.WideFromDeviceEuler;
            WideFromDeviceEulerStd = reader.WideFromDeviceEulerStd;
            RoadTransformTrans = reader.RoadTransformTrans;
            RoadTransformTransStd = reader.RoadTransformTransStd;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.Trans.Init(Trans);
            writer.Rot.Init(Rot);
            writer.TransStd.Init(TransStd);
            writer.RotStd.Init(RotStd);
            writer.FrameId = FrameId;
            writer.TimestampEof = TimestampEof;
            writer.WideFromDeviceEuler.Init(WideFromDeviceEuler);
            writer.WideFromDeviceEulerStd.Init(WideFromDeviceEulerStd);
            writer.RoadTransformTrans.Init(RoadTransformTrans);
            writer.RoadTransformTransStd.Init(RoadTransformTransStd);
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public IReadOnlyList<float> Trans
        {
            get;
            set;
        }

        public IReadOnlyList<float> Rot
        {
            get;
            set;
        }

        public IReadOnlyList<float> TransStd
        {
            get;
            set;
        }

        public IReadOnlyList<float> RotStd
        {
            get;
            set;
        }

        public uint FrameId
        {
            get;
            set;
        }

        public ulong TimestampEof
        {
            get;
            set;
        }

        public IReadOnlyList<float> WideFromDeviceEuler
        {
            get;
            set;
        }

        public IReadOnlyList<float> WideFromDeviceEulerStd
        {
            get;
            set;
        }

        public IReadOnlyList<float> RoadTransformTrans
        {
            get;
            set;
        }

        public IReadOnlyList<float> RoadTransformTransStd
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public IReadOnlyList<float> Trans => ctx.ReadList(0).CastFloat();
            public IReadOnlyList<float> Rot => ctx.ReadList(1).CastFloat();
            public IReadOnlyList<float> TransStd => ctx.ReadList(2).CastFloat();
            public IReadOnlyList<float> RotStd => ctx.ReadList(3).CastFloat();
            public uint FrameId => ctx.ReadDataUInt(0UL, 0U);
            public ulong TimestampEof => ctx.ReadDataULong(64UL, 0UL);
            public IReadOnlyList<float> WideFromDeviceEuler => ctx.ReadList(4).CastFloat();
            public IReadOnlyList<float> WideFromDeviceEulerStd => ctx.ReadList(5).CastFloat();
            public IReadOnlyList<float> RoadTransformTrans => ctx.ReadList(6).CastFloat();
            public IReadOnlyList<float> RoadTransformTransStd => ctx.ReadList(7).CastFloat();
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(2, 8);
            }

            public ListOfPrimitivesSerializer<float> Trans
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(0);
                set => Link(0, value);
            }

            public ListOfPrimitivesSerializer<float> Rot
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(1);
                set => Link(1, value);
            }

            public ListOfPrimitivesSerializer<float> TransStd
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(2);
                set => Link(2, value);
            }

            public ListOfPrimitivesSerializer<float> RotStd
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(3);
                set => Link(3, value);
            }

            public uint FrameId
            {
                get => this.ReadDataUInt(0UL, 0U);
                set => this.WriteData(0UL, value, 0U);
            }

            public ulong TimestampEof
            {
                get => this.ReadDataULong(64UL, 0UL);
                set => this.WriteData(64UL, value, 0UL);
            }

            public ListOfPrimitivesSerializer<float> WideFromDeviceEuler
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(4);
                set => Link(4, value);
            }

            public ListOfPrimitivesSerializer<float> WideFromDeviceEulerStd
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(5);
                set => Link(5, value);
            }

            public ListOfPrimitivesSerializer<float> RoadTransformTrans
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(6);
                set => Link(6, value);
            }

            public ListOfPrimitivesSerializer<float> RoadTransformTransStd
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(7);
                set => Link(7, value);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xef0382d244f56e38UL)]
    public class Sentinel : ICapnpSerializable
    {
        public const UInt64 typeId = 0xef0382d244f56e38UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            Type = reader.Type;
            Signal = reader.Signal;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.Type = Type;
            writer.Signal = Signal;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public Cereal.Sentinel.SentinelType Type
        {
            get;
            set;
        }

        public int Signal
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public Cereal.Sentinel.SentinelType Type => (Cereal.Sentinel.SentinelType)ctx.ReadDataUShort(0UL, (ushort)0);
            public int Signal => ctx.ReadDataInt(32UL, 0);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(1, 0);
            }

            public Cereal.Sentinel.SentinelType Type
            {
                get => (Cereal.Sentinel.SentinelType)this.ReadDataUShort(0UL, (ushort)0);
                set => this.WriteData(0UL, (ushort)value, (ushort)0);
            }

            public int Signal
            {
                get => this.ReadDataInt(32UL, 0);
                set => this.WriteData(32UL, value, 0);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xa2d8e61eb6f7031aUL)]
        public enum SentinelType : ushort
        {
            endOfSegment,
            endOfRoute,
            startOfSegment,
            startOfRoute
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xfe35ad896ffaeacfUL)]
    public class UIDebug : ICapnpSerializable
    {
        public const UInt64 typeId = 0xfe35ad896ffaeacfUL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            DrawTimeMillis = reader.DrawTimeMillis;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.DrawTimeMillis = DrawTimeMillis;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public float DrawTimeMillis
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public float DrawTimeMillis => ctx.ReadDataFloat(0UL, 0F);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(1, 0);
            }

            public float DrawTimeMillis
            {
                get => this.ReadDataFloat(0UL, 0F);
                set => this.WriteData(0UL, value, 0F);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xcf7154b31a69635bUL)]
    public class ManagerState : ICapnpSerializable
    {
        public const UInt64 typeId = 0xcf7154b31a69635bUL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            Processes = reader.Processes?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.ManagerState.ProcessState>(_));
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.Processes.Init(Processes, (_s1, _v1) => _v1?.serialize(_s1));
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public IReadOnlyList<Cereal.ManagerState.ProcessState> Processes
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public IReadOnlyList<Cereal.ManagerState.ProcessState.READER> Processes => ctx.ReadList(0).Cast(Cereal.ManagerState.ProcessState.READER.create);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(0, 1);
            }

            public ListOfStructsSerializer<Cereal.ManagerState.ProcessState.WRITER> Processes
            {
                get => BuildPointer<ListOfStructsSerializer<Cereal.ManagerState.ProcessState.WRITER>>(0);
                set => Link(0, value);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0x869a54d2708469eaUL)]
        public class ProcessState : ICapnpSerializable
        {
            public const UInt64 typeId = 0x869a54d2708469eaUL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Name = reader.Name;
                Pid = reader.Pid;
                Running = reader.Running;
                ExitCode = reader.ExitCode;
                ShouldBeRunning = reader.ShouldBeRunning;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Name = Name;
                writer.Pid = Pid;
                writer.Running = Running;
                writer.ExitCode = ExitCode;
                writer.ShouldBeRunning = ShouldBeRunning;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public string Name
            {
                get;
                set;
            }

            public int Pid
            {
                get;
                set;
            }

            public bool Running
            {
                get;
                set;
            }

            public int ExitCode
            {
                get;
                set;
            }

            public bool ShouldBeRunning
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public string Name => ctx.ReadText(0, null);
                public int Pid => ctx.ReadDataInt(0UL, 0);
                public bool Running => ctx.ReadDataBool(32UL, false);
                public int ExitCode => ctx.ReadDataInt(64UL, 0);
                public bool ShouldBeRunning => ctx.ReadDataBool(33UL, false);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(2, 1);
                }

                public string Name
                {
                    get => this.ReadText(0, null);
                    set => this.WriteText(0, value, null);
                }

                public int Pid
                {
                    get => this.ReadDataInt(0UL, 0);
                    set => this.WriteData(0UL, value, 0);
                }

                public bool Running
                {
                    get => this.ReadDataBool(32UL, false);
                    set => this.WriteData(32UL, value, false);
                }

                public int ExitCode
                {
                    get => this.ReadDataInt(64UL, 0);
                    set => this.WriteData(64UL, value, 0);
                }

                public bool ShouldBeRunning
                {
                    get => this.ReadDataBool(33UL, false);
                    set => this.WriteData(33UL, value, false);
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xde266b39b76b461eUL)]
    public class UploaderState : ICapnpSerializable
    {
        public const UInt64 typeId = 0xde266b39b76b461eUL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            ImmediateQueueSize = reader.ImmediateQueueSize;
            ImmediateQueueCount = reader.ImmediateQueueCount;
            RawQueueSize = reader.RawQueueSize;
            RawQueueCount = reader.RawQueueCount;
            LastTime = reader.LastTime;
            LastSpeed = reader.LastSpeed;
            LastFilename = reader.LastFilename;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.ImmediateQueueSize = ImmediateQueueSize;
            writer.ImmediateQueueCount = ImmediateQueueCount;
            writer.RawQueueSize = RawQueueSize;
            writer.RawQueueCount = RawQueueCount;
            writer.LastTime = LastTime;
            writer.LastSpeed = LastSpeed;
            writer.LastFilename = LastFilename;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public uint ImmediateQueueSize
        {
            get;
            set;
        }

        public uint ImmediateQueueCount
        {
            get;
            set;
        }

        public uint RawQueueSize
        {
            get;
            set;
        }

        public uint RawQueueCount
        {
            get;
            set;
        }

        public float LastTime
        {
            get;
            set;
        }

        public float LastSpeed
        {
            get;
            set;
        }

        public string LastFilename
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public uint ImmediateQueueSize => ctx.ReadDataUInt(0UL, 0U);
            public uint ImmediateQueueCount => ctx.ReadDataUInt(32UL, 0U);
            public uint RawQueueSize => ctx.ReadDataUInt(64UL, 0U);
            public uint RawQueueCount => ctx.ReadDataUInt(96UL, 0U);
            public float LastTime => ctx.ReadDataFloat(128UL, 0F);
            public float LastSpeed => ctx.ReadDataFloat(160UL, 0F);
            public string LastFilename => ctx.ReadText(0, null);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(3, 1);
            }

            public uint ImmediateQueueSize
            {
                get => this.ReadDataUInt(0UL, 0U);
                set => this.WriteData(0UL, value, 0U);
            }

            public uint ImmediateQueueCount
            {
                get => this.ReadDataUInt(32UL, 0U);
                set => this.WriteData(32UL, value, 0U);
            }

            public uint RawQueueSize
            {
                get => this.ReadDataUInt(64UL, 0U);
                set => this.WriteData(64UL, value, 0U);
            }

            public uint RawQueueCount
            {
                get => this.ReadDataUInt(96UL, 0U);
                set => this.WriteData(96UL, value, 0U);
            }

            public float LastTime
            {
                get => this.ReadDataFloat(128UL, 0F);
                set => this.WriteData(128UL, value, 0F);
            }

            public float LastSpeed
            {
                get => this.ReadDataFloat(160UL, 0F);
                set => this.WriteData(160UL, value, 0F);
            }

            public string LastFilename
            {
                get => this.ReadText(0, null);
                set => this.WriteText(0, value, null);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xc18216b27f8602afUL)]
    public class NavInstruction : ICapnpSerializable
    {
        public const UInt64 typeId = 0xc18216b27f8602afUL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            ManeuverPrimaryText = reader.ManeuverPrimaryText;
            ManeuverSecondaryText = reader.ManeuverSecondaryText;
            ManeuverDistance = reader.ManeuverDistance;
            ManeuverType = reader.ManeuverType;
            ManeuverModifier = reader.ManeuverModifier;
            DistanceRemaining = reader.DistanceRemaining;
            TimeRemaining = reader.TimeRemaining;
            TimeRemainingTypical = reader.TimeRemainingTypical;
            Lanes = reader.Lanes?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.NavInstruction.Lane>(_));
            ShowFull = reader.ShowFull;
            SpeedLimit = reader.SpeedLimit;
            TheSpeedLimitSign = reader.TheSpeedLimitSign;
            AllManeuvers = reader.AllManeuvers?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.NavInstruction.Maneuver>(_));
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.ManeuverPrimaryText = ManeuverPrimaryText;
            writer.ManeuverSecondaryText = ManeuverSecondaryText;
            writer.ManeuverDistance = ManeuverDistance;
            writer.ManeuverType = ManeuverType;
            writer.ManeuverModifier = ManeuverModifier;
            writer.DistanceRemaining = DistanceRemaining;
            writer.TimeRemaining = TimeRemaining;
            writer.TimeRemainingTypical = TimeRemainingTypical;
            writer.Lanes.Init(Lanes, (_s1, _v1) => _v1?.serialize(_s1));
            writer.ShowFull = ShowFull;
            writer.SpeedLimit = SpeedLimit;
            writer.TheSpeedLimitSign = TheSpeedLimitSign;
            writer.AllManeuvers.Init(AllManeuvers, (_s1, _v1) => _v1?.serialize(_s1));
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public string ManeuverPrimaryText
        {
            get;
            set;
        }

        public string ManeuverSecondaryText
        {
            get;
            set;
        }

        public float ManeuverDistance
        {
            get;
            set;
        }

        public string ManeuverType
        {
            get;
            set;
        }

        public string ManeuverModifier
        {
            get;
            set;
        }

        public float DistanceRemaining
        {
            get;
            set;
        }

        public float TimeRemaining
        {
            get;
            set;
        }

        public float TimeRemainingTypical
        {
            get;
            set;
        }

        public IReadOnlyList<Cereal.NavInstruction.Lane> Lanes
        {
            get;
            set;
        }

        public bool ShowFull
        {
            get;
            set;
        }

        public float SpeedLimit
        {
            get;
            set;
        }

        public Cereal.NavInstruction.SpeedLimitSign TheSpeedLimitSign
        {
            get;
            set;
        }

        public IReadOnlyList<Cereal.NavInstruction.Maneuver> AllManeuvers
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public string ManeuverPrimaryText => ctx.ReadText(0, null);
            public string ManeuverSecondaryText => ctx.ReadText(1, null);
            public float ManeuverDistance => ctx.ReadDataFloat(0UL, 0F);
            public string ManeuverType => ctx.ReadText(2, null);
            public string ManeuverModifier => ctx.ReadText(3, null);
            public float DistanceRemaining => ctx.ReadDataFloat(32UL, 0F);
            public float TimeRemaining => ctx.ReadDataFloat(64UL, 0F);
            public float TimeRemainingTypical => ctx.ReadDataFloat(96UL, 0F);
            public IReadOnlyList<Cereal.NavInstruction.Lane.READER> Lanes => ctx.ReadList(4).Cast(Cereal.NavInstruction.Lane.READER.create);
            public bool ShowFull => ctx.ReadDataBool(128UL, false);
            public float SpeedLimit => ctx.ReadDataFloat(160UL, 0F);
            public Cereal.NavInstruction.SpeedLimitSign TheSpeedLimitSign => (Cereal.NavInstruction.SpeedLimitSign)ctx.ReadDataUShort(144UL, (ushort)0);
            public IReadOnlyList<Cereal.NavInstruction.Maneuver.READER> AllManeuvers => ctx.ReadList(5).Cast(Cereal.NavInstruction.Maneuver.READER.create);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(3, 6);
            }

            public string ManeuverPrimaryText
            {
                get => this.ReadText(0, null);
                set => this.WriteText(0, value, null);
            }

            public string ManeuverSecondaryText
            {
                get => this.ReadText(1, null);
                set => this.WriteText(1, value, null);
            }

            public float ManeuverDistance
            {
                get => this.ReadDataFloat(0UL, 0F);
                set => this.WriteData(0UL, value, 0F);
            }

            public string ManeuverType
            {
                get => this.ReadText(2, null);
                set => this.WriteText(2, value, null);
            }

            public string ManeuverModifier
            {
                get => this.ReadText(3, null);
                set => this.WriteText(3, value, null);
            }

            public float DistanceRemaining
            {
                get => this.ReadDataFloat(32UL, 0F);
                set => this.WriteData(32UL, value, 0F);
            }

            public float TimeRemaining
            {
                get => this.ReadDataFloat(64UL, 0F);
                set => this.WriteData(64UL, value, 0F);
            }

            public float TimeRemainingTypical
            {
                get => this.ReadDataFloat(96UL, 0F);
                set => this.WriteData(96UL, value, 0F);
            }

            public ListOfStructsSerializer<Cereal.NavInstruction.Lane.WRITER> Lanes
            {
                get => BuildPointer<ListOfStructsSerializer<Cereal.NavInstruction.Lane.WRITER>>(4);
                set => Link(4, value);
            }

            public bool ShowFull
            {
                get => this.ReadDataBool(128UL, false);
                set => this.WriteData(128UL, value, false);
            }

            public float SpeedLimit
            {
                get => this.ReadDataFloat(160UL, 0F);
                set => this.WriteData(160UL, value, 0F);
            }

            public Cereal.NavInstruction.SpeedLimitSign TheSpeedLimitSign
            {
                get => (Cereal.NavInstruction.SpeedLimitSign)this.ReadDataUShort(144UL, (ushort)0);
                set => this.WriteData(144UL, (ushort)value, (ushort)0);
            }

            public ListOfStructsSerializer<Cereal.NavInstruction.Maneuver.WRITER> AllManeuvers
            {
                get => BuildPointer<ListOfStructsSerializer<Cereal.NavInstruction.Maneuver.WRITER>>(5);
                set => Link(5, value);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xa4cd1689c0a439d9UL)]
        public class Lane : ICapnpSerializable
        {
            public const UInt64 typeId = 0xa4cd1689c0a439d9UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Directions = reader.Directions;
                Active = reader.Active;
                ActiveDirection = reader.ActiveDirection;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Directions.Init(Directions);
                writer.Active = Active;
                writer.ActiveDirection = ActiveDirection;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public IReadOnlyList<Cereal.NavInstruction.Direction> Directions
            {
                get;
                set;
            }

            public bool Active
            {
                get;
                set;
            }

            public Cereal.NavInstruction.Direction ActiveDirection
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public IReadOnlyList<Cereal.NavInstruction.Direction> Directions => ctx.ReadList(0).CastEnums(_0 => (Cereal.NavInstruction.Direction)_0);
                public bool Active => ctx.ReadDataBool(0UL, false);
                public Cereal.NavInstruction.Direction ActiveDirection => (Cereal.NavInstruction.Direction)ctx.ReadDataUShort(16UL, (ushort)0);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(1, 1);
                }

                public ListOfPrimitivesSerializer<Cereal.NavInstruction.Direction> Directions
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<Cereal.NavInstruction.Direction>>(0);
                    set => Link(0, value);
                }

                public bool Active
                {
                    get => this.ReadDataBool(0UL, false);
                    set => this.WriteData(0UL, value, false);
                }

                public Cereal.NavInstruction.Direction ActiveDirection
                {
                    get => (Cereal.NavInstruction.Direction)this.ReadDataUShort(16UL, (ushort)0);
                    set => this.WriteData(16UL, (ushort)value, (ushort)0);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xeea5b9d8c9e5c192UL)]
        public enum Direction : ushort
        {
            none,
            left,
            right,
            straight,
            slightLeft,
            slightRight
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xb66e0aa568d09c66UL)]
        public enum SpeedLimitSign : ushort
        {
            mutcd,
            vienna
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xb3ec4a1a6ce20a45UL)]
        public class Maneuver : ICapnpSerializable
        {
            public const UInt64 typeId = 0xb3ec4a1a6ce20a45UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Distance = reader.Distance;
                Type = reader.Type;
                Modifier = reader.Modifier;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Distance = Distance;
                writer.Type = Type;
                writer.Modifier = Modifier;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public float Distance
            {
                get;
                set;
            }

            public string Type
            {
                get;
                set;
            }

            public string Modifier
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public float Distance => ctx.ReadDataFloat(0UL, 0F);
                public string Type => ctx.ReadText(0, null);
                public string Modifier => ctx.ReadText(1, null);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(1, 2);
                }

                public float Distance
                {
                    get => this.ReadDataFloat(0UL, 0F);
                    set => this.WriteData(0UL, value, 0F);
                }

                public string Type
                {
                    get => this.ReadText(0, null);
                    set => this.WriteText(0, value, null);
                }

                public string Modifier
                {
                    get => this.ReadText(1, null);
                    set => this.WriteText(1, value, null);
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xa61452f6440d97d3UL)]
    public class NavRoute : ICapnpSerializable
    {
        public const UInt64 typeId = 0xa61452f6440d97d3UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            Coordinates = reader.Coordinates?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.NavRoute.Coordinate>(_));
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.Coordinates.Init(Coordinates, (_s1, _v1) => _v1?.serialize(_s1));
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public IReadOnlyList<Cereal.NavRoute.Coordinate> Coordinates
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public IReadOnlyList<Cereal.NavRoute.Coordinate.READER> Coordinates => ctx.ReadList(0).Cast(Cereal.NavRoute.Coordinate.READER.create);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(0, 1);
            }

            public ListOfStructsSerializer<Cereal.NavRoute.Coordinate.WRITER> Coordinates
            {
                get => BuildPointer<ListOfStructsSerializer<Cereal.NavRoute.Coordinate.WRITER>>(0);
                set => Link(0, value);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xc4c96f53ad1e7485UL)]
        public class Coordinate : ICapnpSerializable
        {
            public const UInt64 typeId = 0xc4c96f53ad1e7485UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Latitude = reader.Latitude;
                Longitude = reader.Longitude;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Latitude = Latitude;
                writer.Longitude = Longitude;
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public float Latitude
            {
                get;
                set;
            }

            public float Longitude
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public float Latitude => ctx.ReadDataFloat(0UL, 0F);
                public float Longitude => ctx.ReadDataFloat(32UL, 0F);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(1, 0);
                }

                public float Latitude
                {
                    get => this.ReadDataFloat(0UL, 0F);
                    set => this.WriteData(0UL, value, 0F);
                }

                public float Longitude
                {
                    get => this.ReadDataFloat(32UL, 0F);
                    set => this.WriteData(32UL, value, 0F);
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xa158dd2a4cfaa81bUL)]
    public class MapRenderState : ICapnpSerializable
    {
        public const UInt64 typeId = 0xa158dd2a4cfaa81bUL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            LocationMonoTime = reader.LocationMonoTime;
            RenderTime = reader.RenderTime;
            FrameId = reader.FrameId;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.LocationMonoTime = LocationMonoTime;
            writer.RenderTime = RenderTime;
            writer.FrameId = FrameId;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public ulong LocationMonoTime
        {
            get;
            set;
        }

        public float RenderTime
        {
            get;
            set;
        }

        public uint FrameId
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public ulong LocationMonoTime => ctx.ReadDataULong(0UL, 0UL);
            public float RenderTime => ctx.ReadDataFloat(64UL, 0F);
            public uint FrameId => ctx.ReadDataUInt(96UL, 0U);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(2, 0);
            }

            public ulong LocationMonoTime
            {
                get => this.ReadDataULong(0UL, 0UL);
                set => this.WriteData(0UL, value, 0UL);
            }

            public float RenderTime
            {
                get => this.ReadDataFloat(64UL, 0F);
                set => this.WriteData(64UL, value, 0F);
            }

            public uint FrameId
            {
                get => this.ReadDataUInt(96UL, 0U);
                set => this.WriteData(96UL, value, 0U);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xac3de5c437be057aUL)]
    public class NavModelData : ICapnpSerializable
    {
        public const UInt64 typeId = 0xac3de5c437be057aUL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            FrameId = reader.FrameId;
            ModelExecutionTime = reader.ModelExecutionTime;
            DspExecutionTime = reader.DspExecutionTime;
            Features = reader.Features;
            Position = CapnpSerializable.Create<Cereal.NavModelData.XYData>(reader.Position);
            DesirePrediction = reader.DesirePrediction;
            LocationMonoTime = reader.LocationMonoTime;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.FrameId = FrameId;
            writer.ModelExecutionTime = ModelExecutionTime;
            writer.DspExecutionTime = DspExecutionTime;
            writer.Features.Init(Features);
            Position?.serialize(writer.Position);
            writer.DesirePrediction.Init(DesirePrediction);
            writer.LocationMonoTime = LocationMonoTime;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public uint FrameId
        {
            get;
            set;
        }

        public float ModelExecutionTime
        {
            get;
            set;
        }

        public float DspExecutionTime
        {
            get;
            set;
        }

        public IReadOnlyList<float> Features
        {
            get;
            set;
        }

        public Cereal.NavModelData.XYData Position
        {
            get;
            set;
        }

        public IReadOnlyList<float> DesirePrediction
        {
            get;
            set;
        }

        public ulong LocationMonoTime
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public uint FrameId => ctx.ReadDataUInt(0UL, 0U);
            public float ModelExecutionTime => ctx.ReadDataFloat(32UL, 0F);
            public float DspExecutionTime => ctx.ReadDataFloat(64UL, 0F);
            public IReadOnlyList<float> Features => ctx.ReadList(0).CastFloat();
            public Cereal.NavModelData.XYData.READER Position => ctx.ReadStruct(1, Cereal.NavModelData.XYData.READER.create);
            public IReadOnlyList<float> DesirePrediction => ctx.ReadList(2).CastFloat();
            public ulong LocationMonoTime => ctx.ReadDataULong(128UL, 0UL);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(3, 3);
            }

            public uint FrameId
            {
                get => this.ReadDataUInt(0UL, 0U);
                set => this.WriteData(0UL, value, 0U);
            }

            public float ModelExecutionTime
            {
                get => this.ReadDataFloat(32UL, 0F);
                set => this.WriteData(32UL, value, 0F);
            }

            public float DspExecutionTime
            {
                get => this.ReadDataFloat(64UL, 0F);
                set => this.WriteData(64UL, value, 0F);
            }

            public ListOfPrimitivesSerializer<float> Features
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(0);
                set => Link(0, value);
            }

            public Cereal.NavModelData.XYData.WRITER Position
            {
                get => BuildPointer<Cereal.NavModelData.XYData.WRITER>(1);
                set => Link(1, value);
            }

            public ListOfPrimitivesSerializer<float> DesirePrediction
            {
                get => BuildPointer<ListOfPrimitivesSerializer<float>>(2);
                set => Link(2, value);
            }

            public ulong LocationMonoTime
            {
                get => this.ReadDataULong(128UL, 0UL);
                set => this.WriteData(128UL, value, 0UL);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xbe09e615b2507e26UL)]
        public class XYData : ICapnpSerializable
        {
            public const UInt64 typeId = 0xbe09e615b2507e26UL;
            void ICapnpSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                X = reader.X;
                Y = reader.Y;
                XStd = reader.XStd;
                YStd = reader.YStd;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.X.Init(X);
                writer.Y.Init(Y);
                writer.XStd.Init(XStd);
                writer.YStd.Init(YStd);
            }

            void ICapnpSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public IReadOnlyList<float> X
            {
                get;
                set;
            }

            public IReadOnlyList<float> Y
            {
                get;
                set;
            }

            public IReadOnlyList<float> XStd
            {
                get;
                set;
            }

            public IReadOnlyList<float> YStd
            {
                get;
                set;
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public IReadOnlyList<float> X => ctx.ReadList(0).CastFloat();
                public IReadOnlyList<float> Y => ctx.ReadList(1).CastFloat();
                public IReadOnlyList<float> XStd => ctx.ReadList(2).CastFloat();
                public IReadOnlyList<float> YStd => ctx.ReadList(3).CastFloat();
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 4);
                }

                public ListOfPrimitivesSerializer<float> X
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(0);
                    set => Link(0, value);
                }

                public ListOfPrimitivesSerializer<float> Y
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(1);
                    set => Link(1, value);
                }

                public ListOfPrimitivesSerializer<float> XStd
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(2);
                    set => Link(2, value);
                }

                public ListOfPrimitivesSerializer<float> YStd
                {
                    get => BuildPointer<ListOfPrimitivesSerializer<float>>(3);
                    set => Link(3, value);
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xcf9aeab355dd85f0UL)]
    public class EncodeData : ICapnpSerializable
    {
        public const UInt64 typeId = 0xcf9aeab355dd85f0UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            Idx = CapnpSerializable.Create<Cereal.EncodeIndex>(reader.Idx);
            Data = reader.Data;
            Header = reader.Header;
            UnixTimestampNanos = reader.UnixTimestampNanos;
            Width = reader.Width;
            Height = reader.Height;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            Idx?.serialize(writer.Idx);
            writer.Data.Init(Data);
            writer.Header.Init(Header);
            writer.UnixTimestampNanos = UnixTimestampNanos;
            writer.Width = Width;
            writer.Height = Height;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public Cereal.EncodeIndex Idx
        {
            get;
            set;
        }

        public IReadOnlyList<byte> Data
        {
            get;
            set;
        }

        public IReadOnlyList<byte> Header
        {
            get;
            set;
        }

        public ulong UnixTimestampNanos
        {
            get;
            set;
        }

        public uint Width
        {
            get;
            set;
        }

        public uint Height
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public Cereal.EncodeIndex.READER Idx => ctx.ReadStruct(0, Cereal.EncodeIndex.READER.create);
            public IReadOnlyList<byte> Data => ctx.ReadList(1).CastByte();
            public IReadOnlyList<byte> Header => ctx.ReadList(2).CastByte();
            public ulong UnixTimestampNanos => ctx.ReadDataULong(0UL, 0UL);
            public uint Width => ctx.ReadDataUInt(64UL, 0U);
            public uint Height => ctx.ReadDataUInt(96UL, 0U);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(2, 3);
            }

            public Cereal.EncodeIndex.WRITER Idx
            {
                get => BuildPointer<Cereal.EncodeIndex.WRITER>(0);
                set => Link(0, value);
            }

            public ListOfPrimitivesSerializer<byte> Data
            {
                get => BuildPointer<ListOfPrimitivesSerializer<byte>>(1);
                set => Link(1, value);
            }

            public ListOfPrimitivesSerializer<byte> Header
            {
                get => BuildPointer<ListOfPrimitivesSerializer<byte>>(2);
                set => Link(2, value);
            }

            public ulong UnixTimestampNanos
            {
                get => this.ReadDataULong(0UL, 0UL);
                set => this.WriteData(0UL, value, 0UL);
            }

            public uint Width
            {
                get => this.ReadDataUInt(64UL, 0U);
                set => this.WriteData(64UL, value, 0U);
            }

            public uint Height
            {
                get => this.ReadDataUInt(96UL, 0U);
                set => this.WriteData(96UL, value, 0U);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xfe346a9de48d9b50UL)]
    public class UserFlag : ICapnpSerializable
    {
        public const UInt64 typeId = 0xfe346a9de48d9b50UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(0, 0);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xdc24138990726023UL)]
    public class Microphone : ICapnpSerializable
    {
        public const UInt64 typeId = 0xdc24138990726023UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            SoundPressure = reader.SoundPressure;
            SoundPressureWeightedDb = reader.SoundPressureWeightedDb;
            FilteredSoundPressureWeightedDb = reader.FilteredSoundPressureWeightedDb;
            SoundPressureWeighted = reader.SoundPressureWeighted;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.SoundPressure = SoundPressure;
            writer.SoundPressureWeightedDb = SoundPressureWeightedDb;
            writer.FilteredSoundPressureWeightedDb = FilteredSoundPressureWeightedDb;
            writer.SoundPressureWeighted = SoundPressureWeighted;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public float SoundPressure
        {
            get;
            set;
        }

        public float SoundPressureWeightedDb
        {
            get;
            set;
        }

        public float FilteredSoundPressureWeightedDb
        {
            get;
            set;
        }

        public float SoundPressureWeighted
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public float SoundPressure => ctx.ReadDataFloat(0UL, 0F);
            public float SoundPressureWeightedDb => ctx.ReadDataFloat(32UL, 0F);
            public float FilteredSoundPressureWeightedDb => ctx.ReadDataFloat(64UL, 0F);
            public float SoundPressureWeighted => ctx.ReadDataFloat(96UL, 0F);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(2, 0);
            }

            public float SoundPressure
            {
                get => this.ReadDataFloat(0UL, 0F);
                set => this.WriteData(0UL, value, 0F);
            }

            public float SoundPressureWeightedDb
            {
                get => this.ReadDataFloat(32UL, 0F);
                set => this.WriteData(32UL, value, 0F);
            }

            public float FilteredSoundPressureWeightedDb
            {
                get => this.ReadDataFloat(64UL, 0F);
                set => this.WriteData(64UL, value, 0F);
            }

            public float SoundPressureWeighted
            {
                get => this.ReadDataFloat(96UL, 0F);
                set => this.WriteData(96UL, value, 0F);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("capnpc-csharp", "1.3.0.0"), TypeId(0xd314cfd957229c11UL)]
    public class Event : ICapnpSerializable
    {
        public const UInt64 typeId = 0xd314cfd957229c11UL;
        public enum WHICH : ushort
        {
            InitData = 0,
            RoadCameraState = 1,
            GpsNMEA = 2,
            SensorEventDEPRECATED = 3,
            Can = 4,
            DeviceState = 5,
            ControlsState = 6,
            LiveEventDEPRECATED = 7,
            Model = 8,
            FeaturesDEPRECATED = 9,
            SensorEventsDEPRECATED = 10,
            PandaStateDEPRECATED = 11,
            RadarState = 12,
            LiveUIDEPRECATED = 13,
            RoadEncodeIdx = 14,
            LiveTracks = 15,
            Sendcan = 16,
            LogMessage = 17,
            LiveCalibration = 18,
            AndroidLog = 19,
            GpsLocation = 20,
            CarState = 21,
            CarControl = 22,
            LongitudinalPlan = 23,
            LiveLocationDEPRECATED = 24,
            EthernetDataDEPRECATED = 25,
            NavUpdateDEPRECATED = 26,
            CellInfoDEPRECATED = 27,
            WifiScanDEPRECATED = 28,
            AndroidGnssDEPRECATED = 29,
            QcomGnss = 30,
            LidarPtsDEPRECATED = 31,
            ProcLog = 32,
            UbloxGnss = 33,
            Clocks = 34,
            LiveMpcDEPRECATED = 35,
            LiveLongitudinalMpcDEPRECATED = 36,
            NavStatusDEPRECATED = 37,
            UbloxRaw = 38,
            GpsPlannerPointsDEPRECATED = 39,
            GpsPlannerPlanDEPRECATED = 40,
            ApplanixRawDEPRECATED = 41,
            TrafficEventsDEPRECATED = 42,
            LiveLocationTimingDEPRECATED = 43,
            OrbslamCorrectionDEPRECATED = 44,
            LiveLocationCorrectedDEPRECATED = 45,
            OrbObservationDEPRECATED = 46,
            GpsLocationExternal = 47,
            LocationDEPRECATED = 48,
            UiNavigationEventDEPRECATED = 49,
            LiveLocationKalmanDEPRECATED = 50,
            TestJoystick = 51,
            OrbOdometryDEPRECATED = 52,
            OrbFeaturesDEPRECATED = 53,
            ApplanixLocationDEPRECATED = 54,
            OrbKeyFrameDEPRECATED = 55,
            UiLayoutStateDEPRECATED = 56,
            OrbFeaturesSummaryDEPRECATED = 57,
            DriverStateDEPRECATED = 58,
            Boot = 59,
            LiveParameters = 60,
            LiveMapDataDEPRECATED = 61,
            CameraOdometry = 62,
            LateralPlanDEPRECATED = 63,
            KalmanOdometryDEPRECATED = 64,
            Thumbnail = 65,
            OnroadEvents = 66,
            CarParams = 67,
            DriverCameraState = 68,
            DriverMonitoringState = 69,
            LiveLocationKalman = 70,
            Sentinel = 71,
            WideRoadCameraState = 72,
            ModelV2 = 73,
            DriverEncodeIdx = 74,
            WideRoadEncodeIdx = 75,
            ManagerState = 76,
            UploaderState = 77,
            PeripheralState = 78,
            PandaStates = 79,
            NavInstruction = 80,
            NavRoute = 81,
            NavThumbnail = 82,
            ErrorLogMessage = 83,
            RoadEncodeData = 84,
            DriverEncodeData = 85,
            WideRoadEncodeData = 86,
            QRoadEncodeData = 87,
            QRoadEncodeIdx = 88,
            GnssMeasurements = 89,
            DriverStateV2 = 90,
            UserFlag = 91,
            LiveTorqueParameters = 92,
            Magnetometer = 93,
            LightSensor = 94,
            TemperatureSensor = 95,
            Accelerometer = 96,
            Gyroscope = 97,
            Gyroscope2 = 98,
            Accelerometer2 = 99,
            UiDebug = 100,
            Microphone = 101,
            NavModel = 102,
            MapRenderState = 103,
            UiPlan = 104,
            CustomReserved0 = 105,
            CustomReserved1 = 106,
            CustomReserved2 = 107,
            CustomReserved3 = 108,
            CustomReserved4 = 109,
            CustomReserved5 = 110,
            CustomReserved6 = 111,
            CustomReserved7 = 112,
            CustomReserved8 = 113,
            CustomReserved9 = 114,
            LivestreamRoadEncodeIdx = 115,
            LivestreamWideRoadEncodeIdx = 116,
            LivestreamDriverEncodeIdx = 117,
            LivestreamRoadEncodeData = 118,
            LivestreamWideRoadEncodeData = 119,
            LivestreamDriverEncodeData = 120,
            TemperatureSensor2 = 121,
            CustomReservedRawData0 = 122,
            CustomReservedRawData1 = 123,
            CustomReservedRawData2 = 124,
            undefined = 65535
        }

        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            switch (reader.which)
            {
                case WHICH.InitData:
                    InitData = CapnpSerializable.Create<Cereal.InitData>(reader.InitData);
                    break;
                case WHICH.RoadCameraState:
                    RoadCameraState = CapnpSerializable.Create<Cereal.FrameData>(reader.RoadCameraState);
                    break;
                case WHICH.GpsNMEA:
                    GpsNMEA = CapnpSerializable.Create<Cereal.GPSNMEAData>(reader.GpsNMEA);
                    break;
                case WHICH.SensorEventDEPRECATED:
                    SensorEventDEPRECATED = CapnpSerializable.Create<Cereal.SensorEventData>(reader.SensorEventDEPRECATED);
                    break;
                case WHICH.Can:
                    Can = reader.Can?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.CanData>(_));
                    break;
                case WHICH.DeviceState:
                    DeviceState = CapnpSerializable.Create<Cereal.DeviceState>(reader.DeviceState);
                    break;
                case WHICH.ControlsState:
                    ControlsState = CapnpSerializable.Create<Cereal.ControlsState>(reader.ControlsState);
                    break;
                case WHICH.LiveEventDEPRECATED:
                    LiveEventDEPRECATED = reader.LiveEventDEPRECATED?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.LiveEventData>(_));
                    break;
                case WHICH.Model:
                    Model = CapnpSerializable.Create<Cereal.ModelData>(reader.Model);
                    break;
                case WHICH.FeaturesDEPRECATED:
                    FeaturesDEPRECATED = CapnpSerializable.Create<Cereal.CalibrationFeatures>(reader.FeaturesDEPRECATED);
                    break;
                case WHICH.SensorEventsDEPRECATED:
                    SensorEventsDEPRECATED = reader.SensorEventsDEPRECATED?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.SensorEventData>(_));
                    break;
                case WHICH.PandaStateDEPRECATED:
                    PandaStateDEPRECATED = CapnpSerializable.Create<Cereal.PandaState>(reader.PandaStateDEPRECATED);
                    break;
                case WHICH.RadarState:
                    RadarState = CapnpSerializable.Create<Cereal.RadarState>(reader.RadarState);
                    break;
                case WHICH.LiveUIDEPRECATED:
                    LiveUIDEPRECATED = CapnpSerializable.Create<Cereal.LiveUI>(reader.LiveUIDEPRECATED);
                    break;
                case WHICH.RoadEncodeIdx:
                    RoadEncodeIdx = CapnpSerializable.Create<Cereal.EncodeIndex>(reader.RoadEncodeIdx);
                    break;
                case WHICH.LiveTracks:
                    LiveTracks = reader.LiveTracks?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.LiveTracks>(_));
                    break;
                case WHICH.Sendcan:
                    Sendcan = reader.Sendcan?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.CanData>(_));
                    break;
                case WHICH.LogMessage:
                    LogMessage = reader.LogMessage;
                    break;
                case WHICH.LiveCalibration:
                    LiveCalibration = CapnpSerializable.Create<Cereal.LiveCalibrationData>(reader.LiveCalibration);
                    break;
                case WHICH.AndroidLog:
                    AndroidLog = CapnpSerializable.Create<Cereal.AndroidLogEntry>(reader.AndroidLog);
                    break;
                case WHICH.GpsLocation:
                    GpsLocation = CapnpSerializable.Create<Cereal.GpsLocationData>(reader.GpsLocation);
                    break;
                case WHICH.CarState:
                    CarState = CapnpSerializable.Create<Cereal.CarState>(reader.CarState);
                    break;
                case WHICH.CarControl:
                    CarControl = CapnpSerializable.Create<Cereal.CarControl>(reader.CarControl);
                    break;
                case WHICH.LongitudinalPlan:
                    LongitudinalPlan = CapnpSerializable.Create<Cereal.LongitudinalPlan>(reader.LongitudinalPlan);
                    break;
                case WHICH.LiveLocationDEPRECATED:
                    LiveLocationDEPRECATED = CapnpSerializable.Create<Cereal.LiveLocationData>(reader.LiveLocationDEPRECATED);
                    break;
                case WHICH.EthernetDataDEPRECATED:
                    EthernetDataDEPRECATED = reader.EthernetDataDEPRECATED?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.EthernetPacket>(_));
                    break;
                case WHICH.NavUpdateDEPRECATED:
                    NavUpdateDEPRECATED = CapnpSerializable.Create<Cereal.NavUpdate>(reader.NavUpdateDEPRECATED);
                    break;
                case WHICH.CellInfoDEPRECATED:
                    CellInfoDEPRECATED = reader.CellInfoDEPRECATED?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.CellInfo>(_));
                    break;
                case WHICH.WifiScanDEPRECATED:
                    WifiScanDEPRECATED = reader.WifiScanDEPRECATED?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.WifiScan>(_));
                    break;
                case WHICH.AndroidGnssDEPRECATED:
                    AndroidGnssDEPRECATED = CapnpSerializable.Create<Cereal.AndroidGnss>(reader.AndroidGnssDEPRECATED);
                    break;
                case WHICH.QcomGnss:
                    QcomGnss = CapnpSerializable.Create<Cereal.QcomGnss>(reader.QcomGnss);
                    break;
                case WHICH.LidarPtsDEPRECATED:
                    LidarPtsDEPRECATED = CapnpSerializable.Create<Cereal.LidarPts>(reader.LidarPtsDEPRECATED);
                    break;
                case WHICH.ProcLog:
                    ProcLog = CapnpSerializable.Create<Cereal.ProcLog>(reader.ProcLog);
                    break;
                case WHICH.UbloxGnss:
                    UbloxGnss = CapnpSerializable.Create<Cereal.UbloxGnss>(reader.UbloxGnss);
                    break;
                case WHICH.Clocks:
                    Clocks = CapnpSerializable.Create<Cereal.Clocks>(reader.Clocks);
                    break;
                case WHICH.LiveMpcDEPRECATED:
                    LiveMpcDEPRECATED = CapnpSerializable.Create<Cereal.LiveMpcData>(reader.LiveMpcDEPRECATED);
                    break;
                case WHICH.LiveLongitudinalMpcDEPRECATED:
                    LiveLongitudinalMpcDEPRECATED = CapnpSerializable.Create<Cereal.LiveLongitudinalMpcData>(reader.LiveLongitudinalMpcDEPRECATED);
                    break;
                case WHICH.NavStatusDEPRECATED:
                    NavStatusDEPRECATED = CapnpSerializable.Create<Cereal.NavStatus>(reader.NavStatusDEPRECATED);
                    break;
                case WHICH.UbloxRaw:
                    UbloxRaw = reader.UbloxRaw;
                    break;
                case WHICH.GpsPlannerPointsDEPRECATED:
                    GpsPlannerPointsDEPRECATED = CapnpSerializable.Create<Cereal.GPSPlannerPoints>(reader.GpsPlannerPointsDEPRECATED);
                    break;
                case WHICH.GpsPlannerPlanDEPRECATED:
                    GpsPlannerPlanDEPRECATED = CapnpSerializable.Create<Cereal.GPSPlannerPlan>(reader.GpsPlannerPlanDEPRECATED);
                    break;
                case WHICH.ApplanixRawDEPRECATED:
                    ApplanixRawDEPRECATED = reader.ApplanixRawDEPRECATED;
                    break;
                case WHICH.TrafficEventsDEPRECATED:
                    TrafficEventsDEPRECATED = reader.TrafficEventsDEPRECATED?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.TrafficEvent>(_));
                    break;
                case WHICH.LiveLocationTimingDEPRECATED:
                    LiveLocationTimingDEPRECATED = CapnpSerializable.Create<Cereal.LiveLocationData>(reader.LiveLocationTimingDEPRECATED);
                    break;
                case WHICH.OrbslamCorrectionDEPRECATED:
                    OrbslamCorrectionDEPRECATED = CapnpSerializable.Create<Cereal.OrbslamCorrection>(reader.OrbslamCorrectionDEPRECATED);
                    break;
                case WHICH.LiveLocationCorrectedDEPRECATED:
                    LiveLocationCorrectedDEPRECATED = CapnpSerializable.Create<Cereal.LiveLocationData>(reader.LiveLocationCorrectedDEPRECATED);
                    break;
                case WHICH.OrbObservationDEPRECATED:
                    OrbObservationDEPRECATED = reader.OrbObservationDEPRECATED?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.OrbObservation>(_));
                    break;
                case WHICH.GpsLocationExternal:
                    GpsLocationExternal = CapnpSerializable.Create<Cereal.GpsLocationData>(reader.GpsLocationExternal);
                    break;
                case WHICH.LocationDEPRECATED:
                    LocationDEPRECATED = CapnpSerializable.Create<Cereal.LiveLocationData>(reader.LocationDEPRECATED);
                    break;
                case WHICH.UiNavigationEventDEPRECATED:
                    UiNavigationEventDEPRECATED = CapnpSerializable.Create<Cereal.UiNavigationEvent>(reader.UiNavigationEventDEPRECATED);
                    break;
                case WHICH.LiveLocationKalmanDEPRECATED:
                    LiveLocationKalmanDEPRECATED = CapnpSerializable.Create<Cereal.LiveLocationData>(reader.LiveLocationKalmanDEPRECATED);
                    break;
                case WHICH.TestJoystick:
                    TestJoystick = CapnpSerializable.Create<Cereal.Joystick>(reader.TestJoystick);
                    break;
                case WHICH.OrbOdometryDEPRECATED:
                    OrbOdometryDEPRECATED = CapnpSerializable.Create<Cereal.OrbOdometry>(reader.OrbOdometryDEPRECATED);
                    break;
                case WHICH.OrbFeaturesDEPRECATED:
                    OrbFeaturesDEPRECATED = CapnpSerializable.Create<Cereal.OrbFeatures>(reader.OrbFeaturesDEPRECATED);
                    break;
                case WHICH.ApplanixLocationDEPRECATED:
                    ApplanixLocationDEPRECATED = CapnpSerializable.Create<Cereal.LiveLocationData>(reader.ApplanixLocationDEPRECATED);
                    break;
                case WHICH.OrbKeyFrameDEPRECATED:
                    OrbKeyFrameDEPRECATED = CapnpSerializable.Create<Cereal.OrbKeyFrame>(reader.OrbKeyFrameDEPRECATED);
                    break;
                case WHICH.UiLayoutStateDEPRECATED:
                    UiLayoutStateDEPRECATED = CapnpSerializable.Create<Cereal.UiLayoutState>(reader.UiLayoutStateDEPRECATED);
                    break;
                case WHICH.OrbFeaturesSummaryDEPRECATED:
                    OrbFeaturesSummaryDEPRECATED = CapnpSerializable.Create<Cereal.OrbFeaturesSummary>(reader.OrbFeaturesSummaryDEPRECATED);
                    break;
                case WHICH.DriverStateDEPRECATED:
                    DriverStateDEPRECATED = CapnpSerializable.Create<Cereal.DriverStateDEPRECATED>(reader.DriverStateDEPRECATED);
                    break;
                case WHICH.Boot:
                    Boot = CapnpSerializable.Create<Cereal.Boot>(reader.Boot);
                    break;
                case WHICH.LiveParameters:
                    LiveParameters = CapnpSerializable.Create<Cereal.LiveParametersData>(reader.LiveParameters);
                    break;
                case WHICH.LiveMapDataDEPRECATED:
                    LiveMapDataDEPRECATED = CapnpSerializable.Create<Cereal.LiveMapDataDEPRECATED>(reader.LiveMapDataDEPRECATED);
                    break;
                case WHICH.CameraOdometry:
                    CameraOdometry = CapnpSerializable.Create<Cereal.CameraOdometry>(reader.CameraOdometry);
                    break;
                case WHICH.LateralPlanDEPRECATED:
                    LateralPlanDEPRECATED = CapnpSerializable.Create<Cereal.LateralPlan>(reader.LateralPlanDEPRECATED);
                    break;
                case WHICH.KalmanOdometryDEPRECATED:
                    KalmanOdometryDEPRECATED = CapnpSerializable.Create<Cereal.KalmanOdometry>(reader.KalmanOdometryDEPRECATED);
                    break;
                case WHICH.Thumbnail:
                    Thumbnail = CapnpSerializable.Create<Cereal.Thumbnail>(reader.Thumbnail);
                    break;
                case WHICH.OnroadEvents:
                    OnroadEvents = reader.OnroadEvents?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.CarEvent>(_));
                    break;
                case WHICH.CarParams:
                    CarParams = CapnpSerializable.Create<Cereal.CarParams>(reader.CarParams);
                    break;
                case WHICH.DriverCameraState:
                    DriverCameraState = CapnpSerializable.Create<Cereal.FrameData>(reader.DriverCameraState);
                    break;
                case WHICH.DriverMonitoringState:
                    DriverMonitoringState = CapnpSerializable.Create<Cereal.DriverMonitoringState>(reader.DriverMonitoringState);
                    break;
                case WHICH.LiveLocationKalman:
                    LiveLocationKalman = CapnpSerializable.Create<Cereal.LiveLocationKalman>(reader.LiveLocationKalman);
                    break;
                case WHICH.Sentinel:
                    Sentinel = CapnpSerializable.Create<Cereal.Sentinel>(reader.Sentinel);
                    break;
                case WHICH.WideRoadCameraState:
                    WideRoadCameraState = CapnpSerializable.Create<Cereal.FrameData>(reader.WideRoadCameraState);
                    break;
                case WHICH.ModelV2:
                    ModelV2 = CapnpSerializable.Create<Cereal.ModelDataV2>(reader.ModelV2);
                    break;
                case WHICH.DriverEncodeIdx:
                    DriverEncodeIdx = CapnpSerializable.Create<Cereal.EncodeIndex>(reader.DriverEncodeIdx);
                    break;
                case WHICH.WideRoadEncodeIdx:
                    WideRoadEncodeIdx = CapnpSerializable.Create<Cereal.EncodeIndex>(reader.WideRoadEncodeIdx);
                    break;
                case WHICH.ManagerState:
                    ManagerState = CapnpSerializable.Create<Cereal.ManagerState>(reader.ManagerState);
                    break;
                case WHICH.UploaderState:
                    UploaderState = CapnpSerializable.Create<Cereal.UploaderState>(reader.UploaderState);
                    break;
                case WHICH.PeripheralState:
                    PeripheralState = CapnpSerializable.Create<Cereal.PeripheralState>(reader.PeripheralState);
                    break;
                case WHICH.PandaStates:
                    PandaStates = reader.PandaStates?.ToReadOnlyList(_ => CapnpSerializable.Create<Cereal.PandaState>(_));
                    break;
                case WHICH.NavInstruction:
                    NavInstruction = CapnpSerializable.Create<Cereal.NavInstruction>(reader.NavInstruction);
                    break;
                case WHICH.NavRoute:
                    NavRoute = CapnpSerializable.Create<Cereal.NavRoute>(reader.NavRoute);
                    break;
                case WHICH.NavThumbnail:
                    NavThumbnail = CapnpSerializable.Create<Cereal.Thumbnail>(reader.NavThumbnail);
                    break;
                case WHICH.ErrorLogMessage:
                    ErrorLogMessage = reader.ErrorLogMessage;
                    break;
                case WHICH.RoadEncodeData:
                    RoadEncodeData = CapnpSerializable.Create<Cereal.EncodeData>(reader.RoadEncodeData);
                    break;
                case WHICH.DriverEncodeData:
                    DriverEncodeData = CapnpSerializable.Create<Cereal.EncodeData>(reader.DriverEncodeData);
                    break;
                case WHICH.WideRoadEncodeData:
                    WideRoadEncodeData = CapnpSerializable.Create<Cereal.EncodeData>(reader.WideRoadEncodeData);
                    break;
                case WHICH.QRoadEncodeData:
                    QRoadEncodeData = CapnpSerializable.Create<Cereal.EncodeData>(reader.QRoadEncodeData);
                    break;
                case WHICH.QRoadEncodeIdx:
                    QRoadEncodeIdx = CapnpSerializable.Create<Cereal.EncodeIndex>(reader.QRoadEncodeIdx);
                    break;
                case WHICH.GnssMeasurements:
                    GnssMeasurements = CapnpSerializable.Create<Cereal.GnssMeasurements>(reader.GnssMeasurements);
                    break;
                case WHICH.DriverStateV2:
                    DriverStateV2 = CapnpSerializable.Create<Cereal.DriverStateV2>(reader.DriverStateV2);
                    break;
                case WHICH.UserFlag:
                    UserFlag = CapnpSerializable.Create<Cereal.UserFlag>(reader.UserFlag);
                    break;
                case WHICH.LiveTorqueParameters:
                    LiveTorqueParameters = CapnpSerializable.Create<Cereal.LiveTorqueParametersData>(reader.LiveTorqueParameters);
                    break;
                case WHICH.Magnetometer:
                    Magnetometer = CapnpSerializable.Create<Cereal.SensorEventData>(reader.Magnetometer);
                    break;
                case WHICH.LightSensor:
                    LightSensor = CapnpSerializable.Create<Cereal.SensorEventData>(reader.LightSensor);
                    break;
                case WHICH.TemperatureSensor:
                    TemperatureSensor = CapnpSerializable.Create<Cereal.SensorEventData>(reader.TemperatureSensor);
                    break;
                case WHICH.Accelerometer:
                    Accelerometer = CapnpSerializable.Create<Cereal.SensorEventData>(reader.Accelerometer);
                    break;
                case WHICH.Gyroscope:
                    Gyroscope = CapnpSerializable.Create<Cereal.SensorEventData>(reader.Gyroscope);
                    break;
                case WHICH.Gyroscope2:
                    Gyroscope2 = CapnpSerializable.Create<Cereal.SensorEventData>(reader.Gyroscope2);
                    break;
                case WHICH.Accelerometer2:
                    Accelerometer2 = CapnpSerializable.Create<Cereal.SensorEventData>(reader.Accelerometer2);
                    break;
                case WHICH.UiDebug:
                    UiDebug = CapnpSerializable.Create<Cereal.UIDebug>(reader.UiDebug);
                    break;
                case WHICH.Microphone:
                    Microphone = CapnpSerializable.Create<Cereal.Microphone>(reader.Microphone);
                    break;
                case WHICH.NavModel:
                    NavModel = CapnpSerializable.Create<Cereal.NavModelData>(reader.NavModel);
                    break;
                case WHICH.MapRenderState:
                    MapRenderState = CapnpSerializable.Create<Cereal.MapRenderState>(reader.MapRenderState);
                    break;
                case WHICH.UiPlan:
                    UiPlan = CapnpSerializable.Create<Cereal.UiPlan>(reader.UiPlan);
                    break;
                case WHICH.CustomReserved0:
                    CustomReserved0 = CapnpSerializable.Create<Cereal.CustomReserved0>(reader.CustomReserved0);
                    break;
                case WHICH.CustomReserved1:
                    CustomReserved1 = CapnpSerializable.Create<Cereal.CustomReserved1>(reader.CustomReserved1);
                    break;
                case WHICH.CustomReserved2:
                    CustomReserved2 = CapnpSerializable.Create<Cereal.CustomReserved2>(reader.CustomReserved2);
                    break;
                case WHICH.CustomReserved3:
                    CustomReserved3 = CapnpSerializable.Create<Cereal.CustomReserved3>(reader.CustomReserved3);
                    break;
                case WHICH.CustomReserved4:
                    CustomReserved4 = CapnpSerializable.Create<Cereal.CustomReserved4>(reader.CustomReserved4);
                    break;
                case WHICH.CustomReserved5:
                    CustomReserved5 = CapnpSerializable.Create<Cereal.CustomReserved5>(reader.CustomReserved5);
                    break;
                case WHICH.CustomReserved6:
                    CustomReserved6 = CapnpSerializable.Create<Cereal.CustomReserved6>(reader.CustomReserved6);
                    break;
                case WHICH.CustomReserved7:
                    CustomReserved7 = CapnpSerializable.Create<Cereal.CustomReserved7>(reader.CustomReserved7);
                    break;
                case WHICH.CustomReserved8:
                    CustomReserved8 = CapnpSerializable.Create<Cereal.CustomReserved8>(reader.CustomReserved8);
                    break;
                case WHICH.CustomReserved9:
                    CustomReserved9 = CapnpSerializable.Create<Cereal.CustomReserved9>(reader.CustomReserved9);
                    break;
                case WHICH.LivestreamRoadEncodeIdx:
                    LivestreamRoadEncodeIdx = CapnpSerializable.Create<Cereal.EncodeIndex>(reader.LivestreamRoadEncodeIdx);
                    break;
                case WHICH.LivestreamWideRoadEncodeIdx:
                    LivestreamWideRoadEncodeIdx = CapnpSerializable.Create<Cereal.EncodeIndex>(reader.LivestreamWideRoadEncodeIdx);
                    break;
                case WHICH.LivestreamDriverEncodeIdx:
                    LivestreamDriverEncodeIdx = CapnpSerializable.Create<Cereal.EncodeIndex>(reader.LivestreamDriverEncodeIdx);
                    break;
                case WHICH.LivestreamRoadEncodeData:
                    LivestreamRoadEncodeData = CapnpSerializable.Create<Cereal.EncodeData>(reader.LivestreamRoadEncodeData);
                    break;
                case WHICH.LivestreamWideRoadEncodeData:
                    LivestreamWideRoadEncodeData = CapnpSerializable.Create<Cereal.EncodeData>(reader.LivestreamWideRoadEncodeData);
                    break;
                case WHICH.LivestreamDriverEncodeData:
                    LivestreamDriverEncodeData = CapnpSerializable.Create<Cereal.EncodeData>(reader.LivestreamDriverEncodeData);
                    break;
                case WHICH.TemperatureSensor2:
                    TemperatureSensor2 = CapnpSerializable.Create<Cereal.SensorEventData>(reader.TemperatureSensor2);
                    break;
                case WHICH.CustomReservedRawData0:
                    CustomReservedRawData0 = reader.CustomReservedRawData0;
                    break;
                case WHICH.CustomReservedRawData1:
                    CustomReservedRawData1 = reader.CustomReservedRawData1;
                    break;
                case WHICH.CustomReservedRawData2:
                    CustomReservedRawData2 = reader.CustomReservedRawData2;
                    break;
            }

            LogMonoTime = reader.LogMonoTime;
            Valid = reader.Valid;
            applyDefaults();
        }

        private WHICH _which = WHICH.undefined;
        private object _content;
        public WHICH which
        {
            get => _which;
            set
            {
                if (value == _which)
                    return;
                _which = value;
                switch (value)
                {
                    case WHICH.InitData:
                        _content = null;
                        break;
                    case WHICH.RoadCameraState:
                        _content = null;
                        break;
                    case WHICH.GpsNMEA:
                        _content = null;
                        break;
                    case WHICH.SensorEventDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.Can:
                        _content = null;
                        break;
                    case WHICH.DeviceState:
                        _content = null;
                        break;
                    case WHICH.ControlsState:
                        _content = null;
                        break;
                    case WHICH.LiveEventDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.Model:
                        _content = null;
                        break;
                    case WHICH.FeaturesDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.SensorEventsDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.PandaStateDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.RadarState:
                        _content = null;
                        break;
                    case WHICH.LiveUIDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.RoadEncodeIdx:
                        _content = null;
                        break;
                    case WHICH.LiveTracks:
                        _content = null;
                        break;
                    case WHICH.Sendcan:
                        _content = null;
                        break;
                    case WHICH.LogMessage:
                        _content = null;
                        break;
                    case WHICH.LiveCalibration:
                        _content = null;
                        break;
                    case WHICH.AndroidLog:
                        _content = null;
                        break;
                    case WHICH.GpsLocation:
                        _content = null;
                        break;
                    case WHICH.CarState:
                        _content = null;
                        break;
                    case WHICH.CarControl:
                        _content = null;
                        break;
                    case WHICH.LongitudinalPlan:
                        _content = null;
                        break;
                    case WHICH.LiveLocationDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.EthernetDataDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.NavUpdateDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.CellInfoDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.WifiScanDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.AndroidGnssDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.QcomGnss:
                        _content = null;
                        break;
                    case WHICH.LidarPtsDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.ProcLog:
                        _content = null;
                        break;
                    case WHICH.UbloxGnss:
                        _content = null;
                        break;
                    case WHICH.Clocks:
                        _content = null;
                        break;
                    case WHICH.LiveMpcDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.LiveLongitudinalMpcDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.NavStatusDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.UbloxRaw:
                        _content = null;
                        break;
                    case WHICH.GpsPlannerPointsDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.GpsPlannerPlanDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.ApplanixRawDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.TrafficEventsDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.LiveLocationTimingDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.OrbslamCorrectionDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.LiveLocationCorrectedDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.OrbObservationDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.GpsLocationExternal:
                        _content = null;
                        break;
                    case WHICH.LocationDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.UiNavigationEventDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.LiveLocationKalmanDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.TestJoystick:
                        _content = null;
                        break;
                    case WHICH.OrbOdometryDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.OrbFeaturesDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.ApplanixLocationDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.OrbKeyFrameDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.UiLayoutStateDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.OrbFeaturesSummaryDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.DriverStateDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.Boot:
                        _content = null;
                        break;
                    case WHICH.LiveParameters:
                        _content = null;
                        break;
                    case WHICH.LiveMapDataDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.CameraOdometry:
                        _content = null;
                        break;
                    case WHICH.LateralPlanDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.KalmanOdometryDEPRECATED:
                        _content = null;
                        break;
                    case WHICH.Thumbnail:
                        _content = null;
                        break;
                    case WHICH.OnroadEvents:
                        _content = null;
                        break;
                    case WHICH.CarParams:
                        _content = null;
                        break;
                    case WHICH.DriverCameraState:
                        _content = null;
                        break;
                    case WHICH.DriverMonitoringState:
                        _content = null;
                        break;
                    case WHICH.LiveLocationKalman:
                        _content = null;
                        break;
                    case WHICH.Sentinel:
                        _content = null;
                        break;
                    case WHICH.WideRoadCameraState:
                        _content = null;
                        break;
                    case WHICH.ModelV2:
                        _content = null;
                        break;
                    case WHICH.DriverEncodeIdx:
                        _content = null;
                        break;
                    case WHICH.WideRoadEncodeIdx:
                        _content = null;
                        break;
                    case WHICH.ManagerState:
                        _content = null;
                        break;
                    case WHICH.UploaderState:
                        _content = null;
                        break;
                    case WHICH.PeripheralState:
                        _content = null;
                        break;
                    case WHICH.PandaStates:
                        _content = null;
                        break;
                    case WHICH.NavInstruction:
                        _content = null;
                        break;
                    case WHICH.NavRoute:
                        _content = null;
                        break;
                    case WHICH.NavThumbnail:
                        _content = null;
                        break;
                    case WHICH.ErrorLogMessage:
                        _content = null;
                        break;
                    case WHICH.RoadEncodeData:
                        _content = null;
                        break;
                    case WHICH.DriverEncodeData:
                        _content = null;
                        break;
                    case WHICH.WideRoadEncodeData:
                        _content = null;
                        break;
                    case WHICH.QRoadEncodeData:
                        _content = null;
                        break;
                    case WHICH.QRoadEncodeIdx:
                        _content = null;
                        break;
                    case WHICH.GnssMeasurements:
                        _content = null;
                        break;
                    case WHICH.DriverStateV2:
                        _content = null;
                        break;
                    case WHICH.UserFlag:
                        _content = null;
                        break;
                    case WHICH.LiveTorqueParameters:
                        _content = null;
                        break;
                    case WHICH.Magnetometer:
                        _content = null;
                        break;
                    case WHICH.LightSensor:
                        _content = null;
                        break;
                    case WHICH.TemperatureSensor:
                        _content = null;
                        break;
                    case WHICH.Accelerometer:
                        _content = null;
                        break;
                    case WHICH.Gyroscope:
                        _content = null;
                        break;
                    case WHICH.Gyroscope2:
                        _content = null;
                        break;
                    case WHICH.Accelerometer2:
                        _content = null;
                        break;
                    case WHICH.UiDebug:
                        _content = null;
                        break;
                    case WHICH.Microphone:
                        _content = null;
                        break;
                    case WHICH.NavModel:
                        _content = null;
                        break;
                    case WHICH.MapRenderState:
                        _content = null;
                        break;
                    case WHICH.UiPlan:
                        _content = null;
                        break;
                    case WHICH.CustomReserved0:
                        _content = null;
                        break;
                    case WHICH.CustomReserved1:
                        _content = null;
                        break;
                    case WHICH.CustomReserved2:
                        _content = null;
                        break;
                    case WHICH.CustomReserved3:
                        _content = null;
                        break;
                    case WHICH.CustomReserved4:
                        _content = null;
                        break;
                    case WHICH.CustomReserved5:
                        _content = null;
                        break;
                    case WHICH.CustomReserved6:
                        _content = null;
                        break;
                    case WHICH.CustomReserved7:
                        _content = null;
                        break;
                    case WHICH.CustomReserved8:
                        _content = null;
                        break;
                    case WHICH.CustomReserved9:
                        _content = null;
                        break;
                    case WHICH.LivestreamRoadEncodeIdx:
                        _content = null;
                        break;
                    case WHICH.LivestreamWideRoadEncodeIdx:
                        _content = null;
                        break;
                    case WHICH.LivestreamDriverEncodeIdx:
                        _content = null;
                        break;
                    case WHICH.LivestreamRoadEncodeData:
                        _content = null;
                        break;
                    case WHICH.LivestreamWideRoadEncodeData:
                        _content = null;
                        break;
                    case WHICH.LivestreamDriverEncodeData:
                        _content = null;
                        break;
                    case WHICH.TemperatureSensor2:
                        _content = null;
                        break;
                    case WHICH.CustomReservedRawData0:
                        _content = null;
                        break;
                    case WHICH.CustomReservedRawData1:
                        _content = null;
                        break;
                    case WHICH.CustomReservedRawData2:
                        _content = null;
                        break;
                }
            }
        }

        public void serialize(WRITER writer)
        {
            writer.which = which;
            switch (which)
            {
                case WHICH.InitData:
                    InitData?.serialize(writer.InitData);
                    break;
                case WHICH.RoadCameraState:
                    RoadCameraState?.serialize(writer.RoadCameraState);
                    break;
                case WHICH.GpsNMEA:
                    GpsNMEA?.serialize(writer.GpsNMEA);
                    break;
                case WHICH.SensorEventDEPRECATED:
                    SensorEventDEPRECATED?.serialize(writer.SensorEventDEPRECATED);
                    break;
                case WHICH.Can:
                    writer.Can.Init(Can, (_s1, _v1) => _v1?.serialize(_s1));
                    break;
                case WHICH.DeviceState:
                    DeviceState?.serialize(writer.DeviceState);
                    break;
                case WHICH.ControlsState:
                    ControlsState?.serialize(writer.ControlsState);
                    break;
                case WHICH.LiveEventDEPRECATED:
                    writer.LiveEventDEPRECATED.Init(LiveEventDEPRECATED, (_s1, _v1) => _v1?.serialize(_s1));
                    break;
                case WHICH.Model:
                    Model?.serialize(writer.Model);
                    break;
                case WHICH.FeaturesDEPRECATED:
                    FeaturesDEPRECATED?.serialize(writer.FeaturesDEPRECATED);
                    break;
                case WHICH.SensorEventsDEPRECATED:
                    writer.SensorEventsDEPRECATED.Init(SensorEventsDEPRECATED, (_s1, _v1) => _v1?.serialize(_s1));
                    break;
                case WHICH.PandaStateDEPRECATED:
                    PandaStateDEPRECATED?.serialize(writer.PandaStateDEPRECATED);
                    break;
                case WHICH.RadarState:
                    RadarState?.serialize(writer.RadarState);
                    break;
                case WHICH.LiveUIDEPRECATED:
                    LiveUIDEPRECATED?.serialize(writer.LiveUIDEPRECATED);
                    break;
                case WHICH.RoadEncodeIdx:
                    RoadEncodeIdx?.serialize(writer.RoadEncodeIdx);
                    break;
                case WHICH.LiveTracks:
                    writer.LiveTracks.Init(LiveTracks, (_s1, _v1) => _v1?.serialize(_s1));
                    break;
                case WHICH.Sendcan:
                    writer.Sendcan.Init(Sendcan, (_s1, _v1) => _v1?.serialize(_s1));
                    break;
                case WHICH.LogMessage:
                    writer.LogMessage = LogMessage;
                    break;
                case WHICH.LiveCalibration:
                    LiveCalibration?.serialize(writer.LiveCalibration);
                    break;
                case WHICH.AndroidLog:
                    AndroidLog?.serialize(writer.AndroidLog);
                    break;
                case WHICH.GpsLocation:
                    GpsLocation?.serialize(writer.GpsLocation);
                    break;
                case WHICH.CarState:
                    CarState?.serialize(writer.CarState);
                    break;
                case WHICH.CarControl:
                    CarControl?.serialize(writer.CarControl);
                    break;
                case WHICH.LongitudinalPlan:
                    LongitudinalPlan?.serialize(writer.LongitudinalPlan);
                    break;
                case WHICH.LiveLocationDEPRECATED:
                    LiveLocationDEPRECATED?.serialize(writer.LiveLocationDEPRECATED);
                    break;
                case WHICH.EthernetDataDEPRECATED:
                    writer.EthernetDataDEPRECATED.Init(EthernetDataDEPRECATED, (_s1, _v1) => _v1?.serialize(_s1));
                    break;
                case WHICH.NavUpdateDEPRECATED:
                    NavUpdateDEPRECATED?.serialize(writer.NavUpdateDEPRECATED);
                    break;
                case WHICH.CellInfoDEPRECATED:
                    writer.CellInfoDEPRECATED.Init(CellInfoDEPRECATED, (_s1, _v1) => _v1?.serialize(_s1));
                    break;
                case WHICH.WifiScanDEPRECATED:
                    writer.WifiScanDEPRECATED.Init(WifiScanDEPRECATED, (_s1, _v1) => _v1?.serialize(_s1));
                    break;
                case WHICH.AndroidGnssDEPRECATED:
                    AndroidGnssDEPRECATED?.serialize(writer.AndroidGnssDEPRECATED);
                    break;
                case WHICH.QcomGnss:
                    QcomGnss?.serialize(writer.QcomGnss);
                    break;
                case WHICH.LidarPtsDEPRECATED:
                    LidarPtsDEPRECATED?.serialize(writer.LidarPtsDEPRECATED);
                    break;
                case WHICH.ProcLog:
                    ProcLog?.serialize(writer.ProcLog);
                    break;
                case WHICH.UbloxGnss:
                    UbloxGnss?.serialize(writer.UbloxGnss);
                    break;
                case WHICH.Clocks:
                    Clocks?.serialize(writer.Clocks);
                    break;
                case WHICH.LiveMpcDEPRECATED:
                    LiveMpcDEPRECATED?.serialize(writer.LiveMpcDEPRECATED);
                    break;
                case WHICH.LiveLongitudinalMpcDEPRECATED:
                    LiveLongitudinalMpcDEPRECATED?.serialize(writer.LiveLongitudinalMpcDEPRECATED);
                    break;
                case WHICH.NavStatusDEPRECATED:
                    NavStatusDEPRECATED?.serialize(writer.NavStatusDEPRECATED);
                    break;
                case WHICH.UbloxRaw:
                    writer.UbloxRaw.Init(UbloxRaw);
                    break;
                case WHICH.GpsPlannerPointsDEPRECATED:
                    GpsPlannerPointsDEPRECATED?.serialize(writer.GpsPlannerPointsDEPRECATED);
                    break;
                case WHICH.GpsPlannerPlanDEPRECATED:
                    GpsPlannerPlanDEPRECATED?.serialize(writer.GpsPlannerPlanDEPRECATED);
                    break;
                case WHICH.ApplanixRawDEPRECATED:
                    writer.ApplanixRawDEPRECATED.Init(ApplanixRawDEPRECATED);
                    break;
                case WHICH.TrafficEventsDEPRECATED:
                    writer.TrafficEventsDEPRECATED.Init(TrafficEventsDEPRECATED, (_s1, _v1) => _v1?.serialize(_s1));
                    break;
                case WHICH.LiveLocationTimingDEPRECATED:
                    LiveLocationTimingDEPRECATED?.serialize(writer.LiveLocationTimingDEPRECATED);
                    break;
                case WHICH.OrbslamCorrectionDEPRECATED:
                    OrbslamCorrectionDEPRECATED?.serialize(writer.OrbslamCorrectionDEPRECATED);
                    break;
                case WHICH.LiveLocationCorrectedDEPRECATED:
                    LiveLocationCorrectedDEPRECATED?.serialize(writer.LiveLocationCorrectedDEPRECATED);
                    break;
                case WHICH.OrbObservationDEPRECATED:
                    writer.OrbObservationDEPRECATED.Init(OrbObservationDEPRECATED, (_s1, _v1) => _v1?.serialize(_s1));
                    break;
                case WHICH.GpsLocationExternal:
                    GpsLocationExternal?.serialize(writer.GpsLocationExternal);
                    break;
                case WHICH.LocationDEPRECATED:
                    LocationDEPRECATED?.serialize(writer.LocationDEPRECATED);
                    break;
                case WHICH.UiNavigationEventDEPRECATED:
                    UiNavigationEventDEPRECATED?.serialize(writer.UiNavigationEventDEPRECATED);
                    break;
                case WHICH.LiveLocationKalmanDEPRECATED:
                    LiveLocationKalmanDEPRECATED?.serialize(writer.LiveLocationKalmanDEPRECATED);
                    break;
                case WHICH.TestJoystick:
                    TestJoystick?.serialize(writer.TestJoystick);
                    break;
                case WHICH.OrbOdometryDEPRECATED:
                    OrbOdometryDEPRECATED?.serialize(writer.OrbOdometryDEPRECATED);
                    break;
                case WHICH.OrbFeaturesDEPRECATED:
                    OrbFeaturesDEPRECATED?.serialize(writer.OrbFeaturesDEPRECATED);
                    break;
                case WHICH.ApplanixLocationDEPRECATED:
                    ApplanixLocationDEPRECATED?.serialize(writer.ApplanixLocationDEPRECATED);
                    break;
                case WHICH.OrbKeyFrameDEPRECATED:
                    OrbKeyFrameDEPRECATED?.serialize(writer.OrbKeyFrameDEPRECATED);
                    break;
                case WHICH.UiLayoutStateDEPRECATED:
                    UiLayoutStateDEPRECATED?.serialize(writer.UiLayoutStateDEPRECATED);
                    break;
                case WHICH.OrbFeaturesSummaryDEPRECATED:
                    OrbFeaturesSummaryDEPRECATED?.serialize(writer.OrbFeaturesSummaryDEPRECATED);
                    break;
                case WHICH.DriverStateDEPRECATED:
                    DriverStateDEPRECATED?.serialize(writer.DriverStateDEPRECATED);
                    break;
                case WHICH.Boot:
                    Boot?.serialize(writer.Boot);
                    break;
                case WHICH.LiveParameters:
                    LiveParameters?.serialize(writer.LiveParameters);
                    break;
                case WHICH.LiveMapDataDEPRECATED:
                    LiveMapDataDEPRECATED?.serialize(writer.LiveMapDataDEPRECATED);
                    break;
                case WHICH.CameraOdometry:
                    CameraOdometry?.serialize(writer.CameraOdometry);
                    break;
                case WHICH.LateralPlanDEPRECATED:
                    LateralPlanDEPRECATED?.serialize(writer.LateralPlanDEPRECATED);
                    break;
                case WHICH.KalmanOdometryDEPRECATED:
                    KalmanOdometryDEPRECATED?.serialize(writer.KalmanOdometryDEPRECATED);
                    break;
                case WHICH.Thumbnail:
                    Thumbnail?.serialize(writer.Thumbnail);
                    break;
                case WHICH.OnroadEvents:
                    writer.OnroadEvents.Init(OnroadEvents, (_s1, _v1) => _v1?.serialize(_s1));
                    break;
                case WHICH.CarParams:
                    CarParams?.serialize(writer.CarParams);
                    break;
                case WHICH.DriverCameraState:
                    DriverCameraState?.serialize(writer.DriverCameraState);
                    break;
                case WHICH.DriverMonitoringState:
                    DriverMonitoringState?.serialize(writer.DriverMonitoringState);
                    break;
                case WHICH.LiveLocationKalman:
                    LiveLocationKalman?.serialize(writer.LiveLocationKalman);
                    break;
                case WHICH.Sentinel:
                    Sentinel?.serialize(writer.Sentinel);
                    break;
                case WHICH.WideRoadCameraState:
                    WideRoadCameraState?.serialize(writer.WideRoadCameraState);
                    break;
                case WHICH.ModelV2:
                    ModelV2?.serialize(writer.ModelV2);
                    break;
                case WHICH.DriverEncodeIdx:
                    DriverEncodeIdx?.serialize(writer.DriverEncodeIdx);
                    break;
                case WHICH.WideRoadEncodeIdx:
                    WideRoadEncodeIdx?.serialize(writer.WideRoadEncodeIdx);
                    break;
                case WHICH.ManagerState:
                    ManagerState?.serialize(writer.ManagerState);
                    break;
                case WHICH.UploaderState:
                    UploaderState?.serialize(writer.UploaderState);
                    break;
                case WHICH.PeripheralState:
                    PeripheralState?.serialize(writer.PeripheralState);
                    break;
                case WHICH.PandaStates:
                    writer.PandaStates.Init(PandaStates, (_s1, _v1) => _v1?.serialize(_s1));
                    break;
                case WHICH.NavInstruction:
                    NavInstruction?.serialize(writer.NavInstruction);
                    break;
                case WHICH.NavRoute:
                    NavRoute?.serialize(writer.NavRoute);
                    break;
                case WHICH.NavThumbnail:
                    NavThumbnail?.serialize(writer.NavThumbnail);
                    break;
                case WHICH.ErrorLogMessage:
                    writer.ErrorLogMessage = ErrorLogMessage;
                    break;
                case WHICH.RoadEncodeData:
                    RoadEncodeData?.serialize(writer.RoadEncodeData);
                    break;
                case WHICH.DriverEncodeData:
                    DriverEncodeData?.serialize(writer.DriverEncodeData);
                    break;
                case WHICH.WideRoadEncodeData:
                    WideRoadEncodeData?.serialize(writer.WideRoadEncodeData);
                    break;
                case WHICH.QRoadEncodeData:
                    QRoadEncodeData?.serialize(writer.QRoadEncodeData);
                    break;
                case WHICH.QRoadEncodeIdx:
                    QRoadEncodeIdx?.serialize(writer.QRoadEncodeIdx);
                    break;
                case WHICH.GnssMeasurements:
                    GnssMeasurements?.serialize(writer.GnssMeasurements);
                    break;
                case WHICH.DriverStateV2:
                    DriverStateV2?.serialize(writer.DriverStateV2);
                    break;
                case WHICH.UserFlag:
                    UserFlag?.serialize(writer.UserFlag);
                    break;
                case WHICH.LiveTorqueParameters:
                    LiveTorqueParameters?.serialize(writer.LiveTorqueParameters);
                    break;
                case WHICH.Magnetometer:
                    Magnetometer?.serialize(writer.Magnetometer);
                    break;
                case WHICH.LightSensor:
                    LightSensor?.serialize(writer.LightSensor);
                    break;
                case WHICH.TemperatureSensor:
                    TemperatureSensor?.serialize(writer.TemperatureSensor);
                    break;
                case WHICH.Accelerometer:
                    Accelerometer?.serialize(writer.Accelerometer);
                    break;
                case WHICH.Gyroscope:
                    Gyroscope?.serialize(writer.Gyroscope);
                    break;
                case WHICH.Gyroscope2:
                    Gyroscope2?.serialize(writer.Gyroscope2);
                    break;
                case WHICH.Accelerometer2:
                    Accelerometer2?.serialize(writer.Accelerometer2);
                    break;
                case WHICH.UiDebug:
                    UiDebug?.serialize(writer.UiDebug);
                    break;
                case WHICH.Microphone:
                    Microphone?.serialize(writer.Microphone);
                    break;
                case WHICH.NavModel:
                    NavModel?.serialize(writer.NavModel);
                    break;
                case WHICH.MapRenderState:
                    MapRenderState?.serialize(writer.MapRenderState);
                    break;
                case WHICH.UiPlan:
                    UiPlan?.serialize(writer.UiPlan);
                    break;
                case WHICH.CustomReserved0:
                    CustomReserved0?.serialize(writer.CustomReserved0);
                    break;
                case WHICH.CustomReserved1:
                    CustomReserved1?.serialize(writer.CustomReserved1);
                    break;
                case WHICH.CustomReserved2:
                    CustomReserved2?.serialize(writer.CustomReserved2);
                    break;
                case WHICH.CustomReserved3:
                    CustomReserved3?.serialize(writer.CustomReserved3);
                    break;
                case WHICH.CustomReserved4:
                    CustomReserved4?.serialize(writer.CustomReserved4);
                    break;
                case WHICH.CustomReserved5:
                    CustomReserved5?.serialize(writer.CustomReserved5);
                    break;
                case WHICH.CustomReserved6:
                    CustomReserved6?.serialize(writer.CustomReserved6);
                    break;
                case WHICH.CustomReserved7:
                    CustomReserved7?.serialize(writer.CustomReserved7);
                    break;
                case WHICH.CustomReserved8:
                    CustomReserved8?.serialize(writer.CustomReserved8);
                    break;
                case WHICH.CustomReserved9:
                    CustomReserved9?.serialize(writer.CustomReserved9);
                    break;
                case WHICH.LivestreamRoadEncodeIdx:
                    LivestreamRoadEncodeIdx?.serialize(writer.LivestreamRoadEncodeIdx);
                    break;
                case WHICH.LivestreamWideRoadEncodeIdx:
                    LivestreamWideRoadEncodeIdx?.serialize(writer.LivestreamWideRoadEncodeIdx);
                    break;
                case WHICH.LivestreamDriverEncodeIdx:
                    LivestreamDriverEncodeIdx?.serialize(writer.LivestreamDriverEncodeIdx);
                    break;
                case WHICH.LivestreamRoadEncodeData:
                    LivestreamRoadEncodeData?.serialize(writer.LivestreamRoadEncodeData);
                    break;
                case WHICH.LivestreamWideRoadEncodeData:
                    LivestreamWideRoadEncodeData?.serialize(writer.LivestreamWideRoadEncodeData);
                    break;
                case WHICH.LivestreamDriverEncodeData:
                    LivestreamDriverEncodeData?.serialize(writer.LivestreamDriverEncodeData);
                    break;
                case WHICH.TemperatureSensor2:
                    TemperatureSensor2?.serialize(writer.TemperatureSensor2);
                    break;
                case WHICH.CustomReservedRawData0:
                    writer.CustomReservedRawData0.Init(CustomReservedRawData0);
                    break;
                case WHICH.CustomReservedRawData1:
                    writer.CustomReservedRawData1.Init(CustomReservedRawData1);
                    break;
                case WHICH.CustomReservedRawData2:
                    writer.CustomReservedRawData2.Init(CustomReservedRawData2);
                    break;
            }

            writer.LogMonoTime = LogMonoTime;
            writer.Valid = Valid;
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public ulong LogMonoTime
        {
            get;
            set;
        }

        public Cereal.InitData InitData
        {
            get => _which == WHICH.InitData ? (Cereal.InitData)_content : null;
            set
            {
                _which = WHICH.InitData;
                _content = value;
            }
        }

        public Cereal.FrameData RoadCameraState
        {
            get => _which == WHICH.RoadCameraState ? (Cereal.FrameData)_content : null;
            set
            {
                _which = WHICH.RoadCameraState;
                _content = value;
            }
        }

        public Cereal.GPSNMEAData GpsNMEA
        {
            get => _which == WHICH.GpsNMEA ? (Cereal.GPSNMEAData)_content : null;
            set
            {
                _which = WHICH.GpsNMEA;
                _content = value;
            }
        }

        public Cereal.SensorEventData SensorEventDEPRECATED
        {
            get => _which == WHICH.SensorEventDEPRECATED ? (Cereal.SensorEventData)_content : null;
            set
            {
                _which = WHICH.SensorEventDEPRECATED;
                _content = value;
            }
        }

        public IReadOnlyList<Cereal.CanData> Can
        {
            get => _which == WHICH.Can ? (IReadOnlyList<Cereal.CanData>)_content : null;
            set
            {
                _which = WHICH.Can;
                _content = value;
            }
        }

        public Cereal.DeviceState DeviceState
        {
            get => _which == WHICH.DeviceState ? (Cereal.DeviceState)_content : null;
            set
            {
                _which = WHICH.DeviceState;
                _content = value;
            }
        }

        public Cereal.ControlsState ControlsState
        {
            get => _which == WHICH.ControlsState ? (Cereal.ControlsState)_content : null;
            set
            {
                _which = WHICH.ControlsState;
                _content = value;
            }
        }

        public IReadOnlyList<Cereal.LiveEventData> LiveEventDEPRECATED
        {
            get => _which == WHICH.LiveEventDEPRECATED ? (IReadOnlyList<Cereal.LiveEventData>)_content : null;
            set
            {
                _which = WHICH.LiveEventDEPRECATED;
                _content = value;
            }
        }

        public Cereal.ModelData Model
        {
            get => _which == WHICH.Model ? (Cereal.ModelData)_content : null;
            set
            {
                _which = WHICH.Model;
                _content = value;
            }
        }

        public Cereal.CalibrationFeatures FeaturesDEPRECATED
        {
            get => _which == WHICH.FeaturesDEPRECATED ? (Cereal.CalibrationFeatures)_content : null;
            set
            {
                _which = WHICH.FeaturesDEPRECATED;
                _content = value;
            }
        }

        public IReadOnlyList<Cereal.SensorEventData> SensorEventsDEPRECATED
        {
            get => _which == WHICH.SensorEventsDEPRECATED ? (IReadOnlyList<Cereal.SensorEventData>)_content : null;
            set
            {
                _which = WHICH.SensorEventsDEPRECATED;
                _content = value;
            }
        }

        public Cereal.PandaState PandaStateDEPRECATED
        {
            get => _which == WHICH.PandaStateDEPRECATED ? (Cereal.PandaState)_content : null;
            set
            {
                _which = WHICH.PandaStateDEPRECATED;
                _content = value;
            }
        }

        public Cereal.RadarState RadarState
        {
            get => _which == WHICH.RadarState ? (Cereal.RadarState)_content : null;
            set
            {
                _which = WHICH.RadarState;
                _content = value;
            }
        }

        public Cereal.LiveUI LiveUIDEPRECATED
        {
            get => _which == WHICH.LiveUIDEPRECATED ? (Cereal.LiveUI)_content : null;
            set
            {
                _which = WHICH.LiveUIDEPRECATED;
                _content = value;
            }
        }

        public Cereal.EncodeIndex RoadEncodeIdx
        {
            get => _which == WHICH.RoadEncodeIdx ? (Cereal.EncodeIndex)_content : null;
            set
            {
                _which = WHICH.RoadEncodeIdx;
                _content = value;
            }
        }

        public IReadOnlyList<Cereal.LiveTracks> LiveTracks
        {
            get => _which == WHICH.LiveTracks ? (IReadOnlyList<Cereal.LiveTracks>)_content : null;
            set
            {
                _which = WHICH.LiveTracks;
                _content = value;
            }
        }

        public IReadOnlyList<Cereal.CanData> Sendcan
        {
            get => _which == WHICH.Sendcan ? (IReadOnlyList<Cereal.CanData>)_content : null;
            set
            {
                _which = WHICH.Sendcan;
                _content = value;
            }
        }

        public string LogMessage
        {
            get => _which == WHICH.LogMessage ? (string)_content : null;
            set
            {
                _which = WHICH.LogMessage;
                _content = value;
            }
        }

        public Cereal.LiveCalibrationData LiveCalibration
        {
            get => _which == WHICH.LiveCalibration ? (Cereal.LiveCalibrationData)_content : null;
            set
            {
                _which = WHICH.LiveCalibration;
                _content = value;
            }
        }

        public Cereal.AndroidLogEntry AndroidLog
        {
            get => _which == WHICH.AndroidLog ? (Cereal.AndroidLogEntry)_content : null;
            set
            {
                _which = WHICH.AndroidLog;
                _content = value;
            }
        }

        public Cereal.GpsLocationData GpsLocation
        {
            get => _which == WHICH.GpsLocation ? (Cereal.GpsLocationData)_content : null;
            set
            {
                _which = WHICH.GpsLocation;
                _content = value;
            }
        }

        public Cereal.CarState CarState
        {
            get => _which == WHICH.CarState ? (Cereal.CarState)_content : null;
            set
            {
                _which = WHICH.CarState;
                _content = value;
            }
        }

        public Cereal.CarControl CarControl
        {
            get => _which == WHICH.CarControl ? (Cereal.CarControl)_content : null;
            set
            {
                _which = WHICH.CarControl;
                _content = value;
            }
        }

        public Cereal.LongitudinalPlan LongitudinalPlan
        {
            get => _which == WHICH.LongitudinalPlan ? (Cereal.LongitudinalPlan)_content : null;
            set
            {
                _which = WHICH.LongitudinalPlan;
                _content = value;
            }
        }

        public Cereal.LiveLocationData LiveLocationDEPRECATED
        {
            get => _which == WHICH.LiveLocationDEPRECATED ? (Cereal.LiveLocationData)_content : null;
            set
            {
                _which = WHICH.LiveLocationDEPRECATED;
                _content = value;
            }
        }

        public IReadOnlyList<Cereal.EthernetPacket> EthernetDataDEPRECATED
        {
            get => _which == WHICH.EthernetDataDEPRECATED ? (IReadOnlyList<Cereal.EthernetPacket>)_content : null;
            set
            {
                _which = WHICH.EthernetDataDEPRECATED;
                _content = value;
            }
        }

        public Cereal.NavUpdate NavUpdateDEPRECATED
        {
            get => _which == WHICH.NavUpdateDEPRECATED ? (Cereal.NavUpdate)_content : null;
            set
            {
                _which = WHICH.NavUpdateDEPRECATED;
                _content = value;
            }
        }

        public IReadOnlyList<Cereal.CellInfo> CellInfoDEPRECATED
        {
            get => _which == WHICH.CellInfoDEPRECATED ? (IReadOnlyList<Cereal.CellInfo>)_content : null;
            set
            {
                _which = WHICH.CellInfoDEPRECATED;
                _content = value;
            }
        }

        public IReadOnlyList<Cereal.WifiScan> WifiScanDEPRECATED
        {
            get => _which == WHICH.WifiScanDEPRECATED ? (IReadOnlyList<Cereal.WifiScan>)_content : null;
            set
            {
                _which = WHICH.WifiScanDEPRECATED;
                _content = value;
            }
        }

        public Cereal.AndroidGnss AndroidGnssDEPRECATED
        {
            get => _which == WHICH.AndroidGnssDEPRECATED ? (Cereal.AndroidGnss)_content : null;
            set
            {
                _which = WHICH.AndroidGnssDEPRECATED;
                _content = value;
            }
        }

        public Cereal.QcomGnss QcomGnss
        {
            get => _which == WHICH.QcomGnss ? (Cereal.QcomGnss)_content : null;
            set
            {
                _which = WHICH.QcomGnss;
                _content = value;
            }
        }

        public Cereal.LidarPts LidarPtsDEPRECATED
        {
            get => _which == WHICH.LidarPtsDEPRECATED ? (Cereal.LidarPts)_content : null;
            set
            {
                _which = WHICH.LidarPtsDEPRECATED;
                _content = value;
            }
        }

        public Cereal.ProcLog ProcLog
        {
            get => _which == WHICH.ProcLog ? (Cereal.ProcLog)_content : null;
            set
            {
                _which = WHICH.ProcLog;
                _content = value;
            }
        }

        public Cereal.UbloxGnss UbloxGnss
        {
            get => _which == WHICH.UbloxGnss ? (Cereal.UbloxGnss)_content : null;
            set
            {
                _which = WHICH.UbloxGnss;
                _content = value;
            }
        }

        public Cereal.Clocks Clocks
        {
            get => _which == WHICH.Clocks ? (Cereal.Clocks)_content : null;
            set
            {
                _which = WHICH.Clocks;
                _content = value;
            }
        }

        public Cereal.LiveMpcData LiveMpcDEPRECATED
        {
            get => _which == WHICH.LiveMpcDEPRECATED ? (Cereal.LiveMpcData)_content : null;
            set
            {
                _which = WHICH.LiveMpcDEPRECATED;
                _content = value;
            }
        }

        public Cereal.LiveLongitudinalMpcData LiveLongitudinalMpcDEPRECATED
        {
            get => _which == WHICH.LiveLongitudinalMpcDEPRECATED ? (Cereal.LiveLongitudinalMpcData)_content : null;
            set
            {
                _which = WHICH.LiveLongitudinalMpcDEPRECATED;
                _content = value;
            }
        }

        public Cereal.NavStatus NavStatusDEPRECATED
        {
            get => _which == WHICH.NavStatusDEPRECATED ? (Cereal.NavStatus)_content : null;
            set
            {
                _which = WHICH.NavStatusDEPRECATED;
                _content = value;
            }
        }

        public IReadOnlyList<byte> UbloxRaw
        {
            get => _which == WHICH.UbloxRaw ? (IReadOnlyList<byte>)_content : null;
            set
            {
                _which = WHICH.UbloxRaw;
                _content = value;
            }
        }

        public Cereal.GPSPlannerPoints GpsPlannerPointsDEPRECATED
        {
            get => _which == WHICH.GpsPlannerPointsDEPRECATED ? (Cereal.GPSPlannerPoints)_content : null;
            set
            {
                _which = WHICH.GpsPlannerPointsDEPRECATED;
                _content = value;
            }
        }

        public Cereal.GPSPlannerPlan GpsPlannerPlanDEPRECATED
        {
            get => _which == WHICH.GpsPlannerPlanDEPRECATED ? (Cereal.GPSPlannerPlan)_content : null;
            set
            {
                _which = WHICH.GpsPlannerPlanDEPRECATED;
                _content = value;
            }
        }

        public IReadOnlyList<byte> ApplanixRawDEPRECATED
        {
            get => _which == WHICH.ApplanixRawDEPRECATED ? (IReadOnlyList<byte>)_content : null;
            set
            {
                _which = WHICH.ApplanixRawDEPRECATED;
                _content = value;
            }
        }

        public IReadOnlyList<Cereal.TrafficEvent> TrafficEventsDEPRECATED
        {
            get => _which == WHICH.TrafficEventsDEPRECATED ? (IReadOnlyList<Cereal.TrafficEvent>)_content : null;
            set
            {
                _which = WHICH.TrafficEventsDEPRECATED;
                _content = value;
            }
        }

        public Cereal.LiveLocationData LiveLocationTimingDEPRECATED
        {
            get => _which == WHICH.LiveLocationTimingDEPRECATED ? (Cereal.LiveLocationData)_content : null;
            set
            {
                _which = WHICH.LiveLocationTimingDEPRECATED;
                _content = value;
            }
        }

        public Cereal.OrbslamCorrection OrbslamCorrectionDEPRECATED
        {
            get => _which == WHICH.OrbslamCorrectionDEPRECATED ? (Cereal.OrbslamCorrection)_content : null;
            set
            {
                _which = WHICH.OrbslamCorrectionDEPRECATED;
                _content = value;
            }
        }

        public Cereal.LiveLocationData LiveLocationCorrectedDEPRECATED
        {
            get => _which == WHICH.LiveLocationCorrectedDEPRECATED ? (Cereal.LiveLocationData)_content : null;
            set
            {
                _which = WHICH.LiveLocationCorrectedDEPRECATED;
                _content = value;
            }
        }

        public IReadOnlyList<Cereal.OrbObservation> OrbObservationDEPRECATED
        {
            get => _which == WHICH.OrbObservationDEPRECATED ? (IReadOnlyList<Cereal.OrbObservation>)_content : null;
            set
            {
                _which = WHICH.OrbObservationDEPRECATED;
                _content = value;
            }
        }

        public Cereal.GpsLocationData GpsLocationExternal
        {
            get => _which == WHICH.GpsLocationExternal ? (Cereal.GpsLocationData)_content : null;
            set
            {
                _which = WHICH.GpsLocationExternal;
                _content = value;
            }
        }

        public Cereal.LiveLocationData LocationDEPRECATED
        {
            get => _which == WHICH.LocationDEPRECATED ? (Cereal.LiveLocationData)_content : null;
            set
            {
                _which = WHICH.LocationDEPRECATED;
                _content = value;
            }
        }

        public Cereal.UiNavigationEvent UiNavigationEventDEPRECATED
        {
            get => _which == WHICH.UiNavigationEventDEPRECATED ? (Cereal.UiNavigationEvent)_content : null;
            set
            {
                _which = WHICH.UiNavigationEventDEPRECATED;
                _content = value;
            }
        }

        public Cereal.LiveLocationData LiveLocationKalmanDEPRECATED
        {
            get => _which == WHICH.LiveLocationKalmanDEPRECATED ? (Cereal.LiveLocationData)_content : null;
            set
            {
                _which = WHICH.LiveLocationKalmanDEPRECATED;
                _content = value;
            }
        }

        public Cereal.Joystick TestJoystick
        {
            get => _which == WHICH.TestJoystick ? (Cereal.Joystick)_content : null;
            set
            {
                _which = WHICH.TestJoystick;
                _content = value;
            }
        }

        public Cereal.OrbOdometry OrbOdometryDEPRECATED
        {
            get => _which == WHICH.OrbOdometryDEPRECATED ? (Cereal.OrbOdometry)_content : null;
            set
            {
                _which = WHICH.OrbOdometryDEPRECATED;
                _content = value;
            }
        }

        public Cereal.OrbFeatures OrbFeaturesDEPRECATED
        {
            get => _which == WHICH.OrbFeaturesDEPRECATED ? (Cereal.OrbFeatures)_content : null;
            set
            {
                _which = WHICH.OrbFeaturesDEPRECATED;
                _content = value;
            }
        }

        public Cereal.LiveLocationData ApplanixLocationDEPRECATED
        {
            get => _which == WHICH.ApplanixLocationDEPRECATED ? (Cereal.LiveLocationData)_content : null;
            set
            {
                _which = WHICH.ApplanixLocationDEPRECATED;
                _content = value;
            }
        }

        public Cereal.OrbKeyFrame OrbKeyFrameDEPRECATED
        {
            get => _which == WHICH.OrbKeyFrameDEPRECATED ? (Cereal.OrbKeyFrame)_content : null;
            set
            {
                _which = WHICH.OrbKeyFrameDEPRECATED;
                _content = value;
            }
        }

        public Cereal.UiLayoutState UiLayoutStateDEPRECATED
        {
            get => _which == WHICH.UiLayoutStateDEPRECATED ? (Cereal.UiLayoutState)_content : null;
            set
            {
                _which = WHICH.UiLayoutStateDEPRECATED;
                _content = value;
            }
        }

        public Cereal.OrbFeaturesSummary OrbFeaturesSummaryDEPRECATED
        {
            get => _which == WHICH.OrbFeaturesSummaryDEPRECATED ? (Cereal.OrbFeaturesSummary)_content : null;
            set
            {
                _which = WHICH.OrbFeaturesSummaryDEPRECATED;
                _content = value;
            }
        }

        public Cereal.DriverStateDEPRECATED DriverStateDEPRECATED
        {
            get => _which == WHICH.DriverStateDEPRECATED ? (Cereal.DriverStateDEPRECATED)_content : null;
            set
            {
                _which = WHICH.DriverStateDEPRECATED;
                _content = value;
            }
        }

        public Cereal.Boot Boot
        {
            get => _which == WHICH.Boot ? (Cereal.Boot)_content : null;
            set
            {
                _which = WHICH.Boot;
                _content = value;
            }
        }

        public Cereal.LiveParametersData LiveParameters
        {
            get => _which == WHICH.LiveParameters ? (Cereal.LiveParametersData)_content : null;
            set
            {
                _which = WHICH.LiveParameters;
                _content = value;
            }
        }

        public Cereal.LiveMapDataDEPRECATED LiveMapDataDEPRECATED
        {
            get => _which == WHICH.LiveMapDataDEPRECATED ? (Cereal.LiveMapDataDEPRECATED)_content : null;
            set
            {
                _which = WHICH.LiveMapDataDEPRECATED;
                _content = value;
            }
        }

        public Cereal.CameraOdometry CameraOdometry
        {
            get => _which == WHICH.CameraOdometry ? (Cereal.CameraOdometry)_content : null;
            set
            {
                _which = WHICH.CameraOdometry;
                _content = value;
            }
        }

        public Cereal.LateralPlan LateralPlanDEPRECATED
        {
            get => _which == WHICH.LateralPlanDEPRECATED ? (Cereal.LateralPlan)_content : null;
            set
            {
                _which = WHICH.LateralPlanDEPRECATED;
                _content = value;
            }
        }

        public Cereal.KalmanOdometry KalmanOdometryDEPRECATED
        {
            get => _which == WHICH.KalmanOdometryDEPRECATED ? (Cereal.KalmanOdometry)_content : null;
            set
            {
                _which = WHICH.KalmanOdometryDEPRECATED;
                _content = value;
            }
        }

        public Cereal.Thumbnail Thumbnail
        {
            get => _which == WHICH.Thumbnail ? (Cereal.Thumbnail)_content : null;
            set
            {
                _which = WHICH.Thumbnail;
                _content = value;
            }
        }

        public bool Valid
        {
            get;
            set;
        }

        = true;
        public IReadOnlyList<Cereal.CarEvent> OnroadEvents
        {
            get => _which == WHICH.OnroadEvents ? (IReadOnlyList<Cereal.CarEvent>)_content : null;
            set
            {
                _which = WHICH.OnroadEvents;
                _content = value;
            }
        }

        public Cereal.CarParams CarParams
        {
            get => _which == WHICH.CarParams ? (Cereal.CarParams)_content : null;
            set
            {
                _which = WHICH.CarParams;
                _content = value;
            }
        }

        public Cereal.FrameData DriverCameraState
        {
            get => _which == WHICH.DriverCameraState ? (Cereal.FrameData)_content : null;
            set
            {
                _which = WHICH.DriverCameraState;
                _content = value;
            }
        }

        public Cereal.DriverMonitoringState DriverMonitoringState
        {
            get => _which == WHICH.DriverMonitoringState ? (Cereal.DriverMonitoringState)_content : null;
            set
            {
                _which = WHICH.DriverMonitoringState;
                _content = value;
            }
        }

        public Cereal.LiveLocationKalman LiveLocationKalman
        {
            get => _which == WHICH.LiveLocationKalman ? (Cereal.LiveLocationKalman)_content : null;
            set
            {
                _which = WHICH.LiveLocationKalman;
                _content = value;
            }
        }

        public Cereal.Sentinel Sentinel
        {
            get => _which == WHICH.Sentinel ? (Cereal.Sentinel)_content : null;
            set
            {
                _which = WHICH.Sentinel;
                _content = value;
            }
        }

        public Cereal.FrameData WideRoadCameraState
        {
            get => _which == WHICH.WideRoadCameraState ? (Cereal.FrameData)_content : null;
            set
            {
                _which = WHICH.WideRoadCameraState;
                _content = value;
            }
        }

        public Cereal.ModelDataV2 ModelV2
        {
            get => _which == WHICH.ModelV2 ? (Cereal.ModelDataV2)_content : null;
            set
            {
                _which = WHICH.ModelV2;
                _content = value;
            }
        }

        public Cereal.EncodeIndex DriverEncodeIdx
        {
            get => _which == WHICH.DriverEncodeIdx ? (Cereal.EncodeIndex)_content : null;
            set
            {
                _which = WHICH.DriverEncodeIdx;
                _content = value;
            }
        }

        public Cereal.EncodeIndex WideRoadEncodeIdx
        {
            get => _which == WHICH.WideRoadEncodeIdx ? (Cereal.EncodeIndex)_content : null;
            set
            {
                _which = WHICH.WideRoadEncodeIdx;
                _content = value;
            }
        }

        public Cereal.ManagerState ManagerState
        {
            get => _which == WHICH.ManagerState ? (Cereal.ManagerState)_content : null;
            set
            {
                _which = WHICH.ManagerState;
                _content = value;
            }
        }

        public Cereal.UploaderState UploaderState
        {
            get => _which == WHICH.UploaderState ? (Cereal.UploaderState)_content : null;
            set
            {
                _which = WHICH.UploaderState;
                _content = value;
            }
        }

        public Cereal.PeripheralState PeripheralState
        {
            get => _which == WHICH.PeripheralState ? (Cereal.PeripheralState)_content : null;
            set
            {
                _which = WHICH.PeripheralState;
                _content = value;
            }
        }

        public IReadOnlyList<Cereal.PandaState> PandaStates
        {
            get => _which == WHICH.PandaStates ? (IReadOnlyList<Cereal.PandaState>)_content : null;
            set
            {
                _which = WHICH.PandaStates;
                _content = value;
            }
        }

        public Cereal.NavInstruction NavInstruction
        {
            get => _which == WHICH.NavInstruction ? (Cereal.NavInstruction)_content : null;
            set
            {
                _which = WHICH.NavInstruction;
                _content = value;
            }
        }

        public Cereal.NavRoute NavRoute
        {
            get => _which == WHICH.NavRoute ? (Cereal.NavRoute)_content : null;
            set
            {
                _which = WHICH.NavRoute;
                _content = value;
            }
        }

        public Cereal.Thumbnail NavThumbnail
        {
            get => _which == WHICH.NavThumbnail ? (Cereal.Thumbnail)_content : null;
            set
            {
                _which = WHICH.NavThumbnail;
                _content = value;
            }
        }

        public string ErrorLogMessage
        {
            get => _which == WHICH.ErrorLogMessage ? (string)_content : null;
            set
            {
                _which = WHICH.ErrorLogMessage;
                _content = value;
            }
        }

        public Cereal.EncodeData RoadEncodeData
        {
            get => _which == WHICH.RoadEncodeData ? (Cereal.EncodeData)_content : null;
            set
            {
                _which = WHICH.RoadEncodeData;
                _content = value;
            }
        }

        public Cereal.EncodeData DriverEncodeData
        {
            get => _which == WHICH.DriverEncodeData ? (Cereal.EncodeData)_content : null;
            set
            {
                _which = WHICH.DriverEncodeData;
                _content = value;
            }
        }

        public Cereal.EncodeData WideRoadEncodeData
        {
            get => _which == WHICH.WideRoadEncodeData ? (Cereal.EncodeData)_content : null;
            set
            {
                _which = WHICH.WideRoadEncodeData;
                _content = value;
            }
        }

        public Cereal.EncodeData QRoadEncodeData
        {
            get => _which == WHICH.QRoadEncodeData ? (Cereal.EncodeData)_content : null;
            set
            {
                _which = WHICH.QRoadEncodeData;
                _content = value;
            }
        }

        public Cereal.EncodeIndex QRoadEncodeIdx
        {
            get => _which == WHICH.QRoadEncodeIdx ? (Cereal.EncodeIndex)_content : null;
            set
            {
                _which = WHICH.QRoadEncodeIdx;
                _content = value;
            }
        }

        public Cereal.GnssMeasurements GnssMeasurements
        {
            get => _which == WHICH.GnssMeasurements ? (Cereal.GnssMeasurements)_content : null;
            set
            {
                _which = WHICH.GnssMeasurements;
                _content = value;
            }
        }

        public Cereal.DriverStateV2 DriverStateV2
        {
            get => _which == WHICH.DriverStateV2 ? (Cereal.DriverStateV2)_content : null;
            set
            {
                _which = WHICH.DriverStateV2;
                _content = value;
            }
        }

        public Cereal.UserFlag UserFlag
        {
            get => _which == WHICH.UserFlag ? (Cereal.UserFlag)_content : null;
            set
            {
                _which = WHICH.UserFlag;
                _content = value;
            }
        }

        public Cereal.LiveTorqueParametersData LiveTorqueParameters
        {
            get => _which == WHICH.LiveTorqueParameters ? (Cereal.LiveTorqueParametersData)_content : null;
            set
            {
                _which = WHICH.LiveTorqueParameters;
                _content = value;
            }
        }

        public Cereal.SensorEventData Magnetometer
        {
            get => _which == WHICH.Magnetometer ? (Cereal.SensorEventData)_content : null;
            set
            {
                _which = WHICH.Magnetometer;
                _content = value;
            }
        }

        public Cereal.SensorEventData LightSensor
        {
            get => _which == WHICH.LightSensor ? (Cereal.SensorEventData)_content : null;
            set
            {
                _which = WHICH.LightSensor;
                _content = value;
            }
        }

        public Cereal.SensorEventData TemperatureSensor
        {
            get => _which == WHICH.TemperatureSensor ? (Cereal.SensorEventData)_content : null;
            set
            {
                _which = WHICH.TemperatureSensor;
                _content = value;
            }
        }

        public Cereal.SensorEventData Accelerometer
        {
            get => _which == WHICH.Accelerometer ? (Cereal.SensorEventData)_content : null;
            set
            {
                _which = WHICH.Accelerometer;
                _content = value;
            }
        }

        public Cereal.SensorEventData Gyroscope
        {
            get => _which == WHICH.Gyroscope ? (Cereal.SensorEventData)_content : null;
            set
            {
                _which = WHICH.Gyroscope;
                _content = value;
            }
        }

        public Cereal.SensorEventData Gyroscope2
        {
            get => _which == WHICH.Gyroscope2 ? (Cereal.SensorEventData)_content : null;
            set
            {
                _which = WHICH.Gyroscope2;
                _content = value;
            }
        }

        public Cereal.SensorEventData Accelerometer2
        {
            get => _which == WHICH.Accelerometer2 ? (Cereal.SensorEventData)_content : null;
            set
            {
                _which = WHICH.Accelerometer2;
                _content = value;
            }
        }

        public Cereal.UIDebug UiDebug
        {
            get => _which == WHICH.UiDebug ? (Cereal.UIDebug)_content : null;
            set
            {
                _which = WHICH.UiDebug;
                _content = value;
            }
        }

        public Cereal.Microphone Microphone
        {
            get => _which == WHICH.Microphone ? (Cereal.Microphone)_content : null;
            set
            {
                _which = WHICH.Microphone;
                _content = value;
            }
        }

        public Cereal.NavModelData NavModel
        {
            get => _which == WHICH.NavModel ? (Cereal.NavModelData)_content : null;
            set
            {
                _which = WHICH.NavModel;
                _content = value;
            }
        }

        public Cereal.MapRenderState MapRenderState
        {
            get => _which == WHICH.MapRenderState ? (Cereal.MapRenderState)_content : null;
            set
            {
                _which = WHICH.MapRenderState;
                _content = value;
            }
        }

        public Cereal.UiPlan UiPlan
        {
            get => _which == WHICH.UiPlan ? (Cereal.UiPlan)_content : null;
            set
            {
                _which = WHICH.UiPlan;
                _content = value;
            }
        }

        public Cereal.CustomReserved0 CustomReserved0
        {
            get => _which == WHICH.CustomReserved0 ? (Cereal.CustomReserved0)_content : null;
            set
            {
                _which = WHICH.CustomReserved0;
                _content = value;
            }
        }

        public Cereal.CustomReserved1 CustomReserved1
        {
            get => _which == WHICH.CustomReserved1 ? (Cereal.CustomReserved1)_content : null;
            set
            {
                _which = WHICH.CustomReserved1;
                _content = value;
            }
        }

        public Cereal.CustomReserved2 CustomReserved2
        {
            get => _which == WHICH.CustomReserved2 ? (Cereal.CustomReserved2)_content : null;
            set
            {
                _which = WHICH.CustomReserved2;
                _content = value;
            }
        }

        public Cereal.CustomReserved3 CustomReserved3
        {
            get => _which == WHICH.CustomReserved3 ? (Cereal.CustomReserved3)_content : null;
            set
            {
                _which = WHICH.CustomReserved3;
                _content = value;
            }
        }

        public Cereal.CustomReserved4 CustomReserved4
        {
            get => _which == WHICH.CustomReserved4 ? (Cereal.CustomReserved4)_content : null;
            set
            {
                _which = WHICH.CustomReserved4;
                _content = value;
            }
        }

        public Cereal.CustomReserved5 CustomReserved5
        {
            get => _which == WHICH.CustomReserved5 ? (Cereal.CustomReserved5)_content : null;
            set
            {
                _which = WHICH.CustomReserved5;
                _content = value;
            }
        }

        public Cereal.CustomReserved6 CustomReserved6
        {
            get => _which == WHICH.CustomReserved6 ? (Cereal.CustomReserved6)_content : null;
            set
            {
                _which = WHICH.CustomReserved6;
                _content = value;
            }
        }

        public Cereal.CustomReserved7 CustomReserved7
        {
            get => _which == WHICH.CustomReserved7 ? (Cereal.CustomReserved7)_content : null;
            set
            {
                _which = WHICH.CustomReserved7;
                _content = value;
            }
        }

        public Cereal.CustomReserved8 CustomReserved8
        {
            get => _which == WHICH.CustomReserved8 ? (Cereal.CustomReserved8)_content : null;
            set
            {
                _which = WHICH.CustomReserved8;
                _content = value;
            }
        }

        public Cereal.CustomReserved9 CustomReserved9
        {
            get => _which == WHICH.CustomReserved9 ? (Cereal.CustomReserved9)_content : null;
            set
            {
                _which = WHICH.CustomReserved9;
                _content = value;
            }
        }

        public Cereal.EncodeIndex LivestreamRoadEncodeIdx
        {
            get => _which == WHICH.LivestreamRoadEncodeIdx ? (Cereal.EncodeIndex)_content : null;
            set
            {
                _which = WHICH.LivestreamRoadEncodeIdx;
                _content = value;
            }
        }

        public Cereal.EncodeIndex LivestreamWideRoadEncodeIdx
        {
            get => _which == WHICH.LivestreamWideRoadEncodeIdx ? (Cereal.EncodeIndex)_content : null;
            set
            {
                _which = WHICH.LivestreamWideRoadEncodeIdx;
                _content = value;
            }
        }

        public Cereal.EncodeIndex LivestreamDriverEncodeIdx
        {
            get => _which == WHICH.LivestreamDriverEncodeIdx ? (Cereal.EncodeIndex)_content : null;
            set
            {
                _which = WHICH.LivestreamDriverEncodeIdx;
                _content = value;
            }
        }

        public Cereal.EncodeData LivestreamRoadEncodeData
        {
            get => _which == WHICH.LivestreamRoadEncodeData ? (Cereal.EncodeData)_content : null;
            set
            {
                _which = WHICH.LivestreamRoadEncodeData;
                _content = value;
            }
        }

        public Cereal.EncodeData LivestreamWideRoadEncodeData
        {
            get => _which == WHICH.LivestreamWideRoadEncodeData ? (Cereal.EncodeData)_content : null;
            set
            {
                _which = WHICH.LivestreamWideRoadEncodeData;
                _content = value;
            }
        }

        public Cereal.EncodeData LivestreamDriverEncodeData
        {
            get => _which == WHICH.LivestreamDriverEncodeData ? (Cereal.EncodeData)_content : null;
            set
            {
                _which = WHICH.LivestreamDriverEncodeData;
                _content = value;
            }
        }

        public Cereal.SensorEventData TemperatureSensor2
        {
            get => _which == WHICH.TemperatureSensor2 ? (Cereal.SensorEventData)_content : null;
            set
            {
                _which = WHICH.TemperatureSensor2;
                _content = value;
            }
        }

        public IReadOnlyList<byte> CustomReservedRawData0
        {
            get => _which == WHICH.CustomReservedRawData0 ? (IReadOnlyList<byte>)_content : null;
            set
            {
                _which = WHICH.CustomReservedRawData0;
                _content = value;
            }
        }

        public IReadOnlyList<byte> CustomReservedRawData1
        {
            get => _which == WHICH.CustomReservedRawData1 ? (IReadOnlyList<byte>)_content : null;
            set
            {
                _which = WHICH.CustomReservedRawData1;
                _content = value;
            }
        }

        public IReadOnlyList<byte> CustomReservedRawData2
        {
            get => _which == WHICH.CustomReservedRawData2 ? (IReadOnlyList<byte>)_content : null;
            set
            {
                _which = WHICH.CustomReservedRawData2;
                _content = value;
            }
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public WHICH which => (WHICH)ctx.ReadDataUShort(64U, (ushort)0);
            public ulong LogMonoTime => ctx.ReadDataULong(0UL, 0UL);
            public Cereal.InitData.READER InitData => which == WHICH.InitData ? ctx.ReadStruct(0, Cereal.InitData.READER.create) : default;
            public Cereal.FrameData.READER RoadCameraState => which == WHICH.RoadCameraState ? ctx.ReadStruct(0, Cereal.FrameData.READER.create) : default;
            public Cereal.GPSNMEAData.READER GpsNMEA => which == WHICH.GpsNMEA ? ctx.ReadStruct(0, Cereal.GPSNMEAData.READER.create) : default;
            public Cereal.SensorEventData.READER SensorEventDEPRECATED => which == WHICH.SensorEventDEPRECATED ? ctx.ReadStruct(0, Cereal.SensorEventData.READER.create) : default;
            public IReadOnlyList<Cereal.CanData.READER> Can => which == WHICH.Can ? ctx.ReadList(0).Cast(Cereal.CanData.READER.create) : default;
            public Cereal.DeviceState.READER DeviceState => which == WHICH.DeviceState ? ctx.ReadStruct(0, Cereal.DeviceState.READER.create) : default;
            public Cereal.ControlsState.READER ControlsState => which == WHICH.ControlsState ? ctx.ReadStruct(0, Cereal.ControlsState.READER.create) : default;
            public IReadOnlyList<Cereal.LiveEventData.READER> LiveEventDEPRECATED => which == WHICH.LiveEventDEPRECATED ? ctx.ReadList(0).Cast(Cereal.LiveEventData.READER.create) : default;
            public Cereal.ModelData.READER Model => which == WHICH.Model ? ctx.ReadStruct(0, Cereal.ModelData.READER.create) : default;
            public Cereal.CalibrationFeatures.READER FeaturesDEPRECATED => which == WHICH.FeaturesDEPRECATED ? ctx.ReadStruct(0, Cereal.CalibrationFeatures.READER.create) : default;
            public IReadOnlyList<Cereal.SensorEventData.READER> SensorEventsDEPRECATED => which == WHICH.SensorEventsDEPRECATED ? ctx.ReadList(0).Cast(Cereal.SensorEventData.READER.create) : default;
            public Cereal.PandaState.READER PandaStateDEPRECATED => which == WHICH.PandaStateDEPRECATED ? ctx.ReadStruct(0, Cereal.PandaState.READER.create) : default;
            public Cereal.RadarState.READER RadarState => which == WHICH.RadarState ? ctx.ReadStruct(0, Cereal.RadarState.READER.create) : default;
            public Cereal.LiveUI.READER LiveUIDEPRECATED => which == WHICH.LiveUIDEPRECATED ? ctx.ReadStruct(0, Cereal.LiveUI.READER.create) : default;
            public Cereal.EncodeIndex.READER RoadEncodeIdx => which == WHICH.RoadEncodeIdx ? ctx.ReadStruct(0, Cereal.EncodeIndex.READER.create) : default;
            public IReadOnlyList<Cereal.LiveTracks.READER> LiveTracks => which == WHICH.LiveTracks ? ctx.ReadList(0).Cast(Cereal.LiveTracks.READER.create) : default;
            public IReadOnlyList<Cereal.CanData.READER> Sendcan => which == WHICH.Sendcan ? ctx.ReadList(0).Cast(Cereal.CanData.READER.create) : default;
            public string LogMessage => which == WHICH.LogMessage ? ctx.ReadText(0, null) : default;
            public Cereal.LiveCalibrationData.READER LiveCalibration => which == WHICH.LiveCalibration ? ctx.ReadStruct(0, Cereal.LiveCalibrationData.READER.create) : default;
            public Cereal.AndroidLogEntry.READER AndroidLog => which == WHICH.AndroidLog ? ctx.ReadStruct(0, Cereal.AndroidLogEntry.READER.create) : default;
            public Cereal.GpsLocationData.READER GpsLocation => which == WHICH.GpsLocation ? ctx.ReadStruct(0, Cereal.GpsLocationData.READER.create) : default;
            public Cereal.CarState.READER CarState => which == WHICH.CarState ? ctx.ReadStruct(0, Cereal.CarState.READER.create) : default;
            public Cereal.CarControl.READER CarControl => which == WHICH.CarControl ? ctx.ReadStruct(0, Cereal.CarControl.READER.create) : default;
            public Cereal.LongitudinalPlan.READER LongitudinalPlan => which == WHICH.LongitudinalPlan ? ctx.ReadStruct(0, Cereal.LongitudinalPlan.READER.create) : default;
            public Cereal.LiveLocationData.READER LiveLocationDEPRECATED => which == WHICH.LiveLocationDEPRECATED ? ctx.ReadStruct(0, Cereal.LiveLocationData.READER.create) : default;
            public IReadOnlyList<Cereal.EthernetPacket.READER> EthernetDataDEPRECATED => which == WHICH.EthernetDataDEPRECATED ? ctx.ReadList(0).Cast(Cereal.EthernetPacket.READER.create) : default;
            public Cereal.NavUpdate.READER NavUpdateDEPRECATED => which == WHICH.NavUpdateDEPRECATED ? ctx.ReadStruct(0, Cereal.NavUpdate.READER.create) : default;
            public IReadOnlyList<Cereal.CellInfo.READER> CellInfoDEPRECATED => which == WHICH.CellInfoDEPRECATED ? ctx.ReadList(0).Cast(Cereal.CellInfo.READER.create) : default;
            public IReadOnlyList<Cereal.WifiScan.READER> WifiScanDEPRECATED => which == WHICH.WifiScanDEPRECATED ? ctx.ReadList(0).Cast(Cereal.WifiScan.READER.create) : default;
            public Cereal.AndroidGnss.READER AndroidGnssDEPRECATED => which == WHICH.AndroidGnssDEPRECATED ? ctx.ReadStruct(0, Cereal.AndroidGnss.READER.create) : default;
            public Cereal.QcomGnss.READER QcomGnss => which == WHICH.QcomGnss ? ctx.ReadStruct(0, Cereal.QcomGnss.READER.create) : default;
            public Cereal.LidarPts.READER LidarPtsDEPRECATED => which == WHICH.LidarPtsDEPRECATED ? ctx.ReadStruct(0, Cereal.LidarPts.READER.create) : default;
            public Cereal.ProcLog.READER ProcLog => which == WHICH.ProcLog ? ctx.ReadStruct(0, Cereal.ProcLog.READER.create) : default;
            public Cereal.UbloxGnss.READER UbloxGnss => which == WHICH.UbloxGnss ? ctx.ReadStruct(0, Cereal.UbloxGnss.READER.create) : default;
            public Cereal.Clocks.READER Clocks => which == WHICH.Clocks ? ctx.ReadStruct(0, Cereal.Clocks.READER.create) : default;
            public Cereal.LiveMpcData.READER LiveMpcDEPRECATED => which == WHICH.LiveMpcDEPRECATED ? ctx.ReadStruct(0, Cereal.LiveMpcData.READER.create) : default;
            public Cereal.LiveLongitudinalMpcData.READER LiveLongitudinalMpcDEPRECATED => which == WHICH.LiveLongitudinalMpcDEPRECATED ? ctx.ReadStruct(0, Cereal.LiveLongitudinalMpcData.READER.create) : default;
            public Cereal.NavStatus.READER NavStatusDEPRECATED => which == WHICH.NavStatusDEPRECATED ? ctx.ReadStruct(0, Cereal.NavStatus.READER.create) : default;
            public IReadOnlyList<byte> UbloxRaw => which == WHICH.UbloxRaw ? ctx.ReadList(0).CastByte() : default;
            public Cereal.GPSPlannerPoints.READER GpsPlannerPointsDEPRECATED => which == WHICH.GpsPlannerPointsDEPRECATED ? ctx.ReadStruct(0, Cereal.GPSPlannerPoints.READER.create) : default;
            public Cereal.GPSPlannerPlan.READER GpsPlannerPlanDEPRECATED => which == WHICH.GpsPlannerPlanDEPRECATED ? ctx.ReadStruct(0, Cereal.GPSPlannerPlan.READER.create) : default;
            public IReadOnlyList<byte> ApplanixRawDEPRECATED => which == WHICH.ApplanixRawDEPRECATED ? ctx.ReadList(0).CastByte() : default;
            public IReadOnlyList<Cereal.TrafficEvent.READER> TrafficEventsDEPRECATED => which == WHICH.TrafficEventsDEPRECATED ? ctx.ReadList(0).Cast(Cereal.TrafficEvent.READER.create) : default;
            public Cereal.LiveLocationData.READER LiveLocationTimingDEPRECATED => which == WHICH.LiveLocationTimingDEPRECATED ? ctx.ReadStruct(0, Cereal.LiveLocationData.READER.create) : default;
            public Cereal.OrbslamCorrection.READER OrbslamCorrectionDEPRECATED => which == WHICH.OrbslamCorrectionDEPRECATED ? ctx.ReadStruct(0, Cereal.OrbslamCorrection.READER.create) : default;
            public Cereal.LiveLocationData.READER LiveLocationCorrectedDEPRECATED => which == WHICH.LiveLocationCorrectedDEPRECATED ? ctx.ReadStruct(0, Cereal.LiveLocationData.READER.create) : default;
            public IReadOnlyList<Cereal.OrbObservation.READER> OrbObservationDEPRECATED => which == WHICH.OrbObservationDEPRECATED ? ctx.ReadList(0).Cast(Cereal.OrbObservation.READER.create) : default;
            public Cereal.GpsLocationData.READER GpsLocationExternal => which == WHICH.GpsLocationExternal ? ctx.ReadStruct(0, Cereal.GpsLocationData.READER.create) : default;
            public Cereal.LiveLocationData.READER LocationDEPRECATED => which == WHICH.LocationDEPRECATED ? ctx.ReadStruct(0, Cereal.LiveLocationData.READER.create) : default;
            public Cereal.UiNavigationEvent.READER UiNavigationEventDEPRECATED => which == WHICH.UiNavigationEventDEPRECATED ? ctx.ReadStruct(0, Cereal.UiNavigationEvent.READER.create) : default;
            public Cereal.LiveLocationData.READER LiveLocationKalmanDEPRECATED => which == WHICH.LiveLocationKalmanDEPRECATED ? ctx.ReadStruct(0, Cereal.LiveLocationData.READER.create) : default;
            public Cereal.Joystick.READER TestJoystick => which == WHICH.TestJoystick ? ctx.ReadStruct(0, Cereal.Joystick.READER.create) : default;
            public Cereal.OrbOdometry.READER OrbOdometryDEPRECATED => which == WHICH.OrbOdometryDEPRECATED ? ctx.ReadStruct(0, Cereal.OrbOdometry.READER.create) : default;
            public Cereal.OrbFeatures.READER OrbFeaturesDEPRECATED => which == WHICH.OrbFeaturesDEPRECATED ? ctx.ReadStruct(0, Cereal.OrbFeatures.READER.create) : default;
            public Cereal.LiveLocationData.READER ApplanixLocationDEPRECATED => which == WHICH.ApplanixLocationDEPRECATED ? ctx.ReadStruct(0, Cereal.LiveLocationData.READER.create) : default;
            public Cereal.OrbKeyFrame.READER OrbKeyFrameDEPRECATED => which == WHICH.OrbKeyFrameDEPRECATED ? ctx.ReadStruct(0, Cereal.OrbKeyFrame.READER.create) : default;
            public Cereal.UiLayoutState.READER UiLayoutStateDEPRECATED => which == WHICH.UiLayoutStateDEPRECATED ? ctx.ReadStruct(0, Cereal.UiLayoutState.READER.create) : default;
            public Cereal.OrbFeaturesSummary.READER OrbFeaturesSummaryDEPRECATED => which == WHICH.OrbFeaturesSummaryDEPRECATED ? ctx.ReadStruct(0, Cereal.OrbFeaturesSummary.READER.create) : default;
            public Cereal.DriverStateDEPRECATED.READER DriverStateDEPRECATED => which == WHICH.DriverStateDEPRECATED ? ctx.ReadStruct(0, Cereal.DriverStateDEPRECATED.READER.create) : default;
            public Cereal.Boot.READER Boot => which == WHICH.Boot ? ctx.ReadStruct(0, Cereal.Boot.READER.create) : default;
            public Cereal.LiveParametersData.READER LiveParameters => which == WHICH.LiveParameters ? ctx.ReadStruct(0, Cereal.LiveParametersData.READER.create) : default;
            public Cereal.LiveMapDataDEPRECATED.READER LiveMapDataDEPRECATED => which == WHICH.LiveMapDataDEPRECATED ? ctx.ReadStruct(0, Cereal.LiveMapDataDEPRECATED.READER.create) : default;
            public Cereal.CameraOdometry.READER CameraOdometry => which == WHICH.CameraOdometry ? ctx.ReadStruct(0, Cereal.CameraOdometry.READER.create) : default;
            public Cereal.LateralPlan.READER LateralPlanDEPRECATED => which == WHICH.LateralPlanDEPRECATED ? ctx.ReadStruct(0, Cereal.LateralPlan.READER.create) : default;
            public Cereal.KalmanOdometry.READER KalmanOdometryDEPRECATED => which == WHICH.KalmanOdometryDEPRECATED ? ctx.ReadStruct(0, Cereal.KalmanOdometry.READER.create) : default;
            public Cereal.Thumbnail.READER Thumbnail => which == WHICH.Thumbnail ? ctx.ReadStruct(0, Cereal.Thumbnail.READER.create) : default;
            public bool Valid => ctx.ReadDataBool(80UL, true);
            public IReadOnlyList<Cereal.CarEvent.READER> OnroadEvents => which == WHICH.OnroadEvents ? ctx.ReadList(0).Cast(Cereal.CarEvent.READER.create) : default;
            public Cereal.CarParams.READER CarParams => which == WHICH.CarParams ? ctx.ReadStruct(0, Cereal.CarParams.READER.create) : default;
            public Cereal.FrameData.READER DriverCameraState => which == WHICH.DriverCameraState ? ctx.ReadStruct(0, Cereal.FrameData.READER.create) : default;
            public Cereal.DriverMonitoringState.READER DriverMonitoringState => which == WHICH.DriverMonitoringState ? ctx.ReadStruct(0, Cereal.DriverMonitoringState.READER.create) : default;
            public Cereal.LiveLocationKalman.READER LiveLocationKalman => which == WHICH.LiveLocationKalman ? ctx.ReadStruct(0, Cereal.LiveLocationKalman.READER.create) : default;
            public Cereal.Sentinel.READER Sentinel => which == WHICH.Sentinel ? ctx.ReadStruct(0, Cereal.Sentinel.READER.create) : default;
            public Cereal.FrameData.READER WideRoadCameraState => which == WHICH.WideRoadCameraState ? ctx.ReadStruct(0, Cereal.FrameData.READER.create) : default;
            public Cereal.ModelDataV2.READER ModelV2 => which == WHICH.ModelV2 ? ctx.ReadStruct(0, Cereal.ModelDataV2.READER.create) : default;
            public Cereal.EncodeIndex.READER DriverEncodeIdx => which == WHICH.DriverEncodeIdx ? ctx.ReadStruct(0, Cereal.EncodeIndex.READER.create) : default;
            public Cereal.EncodeIndex.READER WideRoadEncodeIdx => which == WHICH.WideRoadEncodeIdx ? ctx.ReadStruct(0, Cereal.EncodeIndex.READER.create) : default;
            public Cereal.ManagerState.READER ManagerState => which == WHICH.ManagerState ? ctx.ReadStruct(0, Cereal.ManagerState.READER.create) : default;
            public Cereal.UploaderState.READER UploaderState => which == WHICH.UploaderState ? ctx.ReadStruct(0, Cereal.UploaderState.READER.create) : default;
            public Cereal.PeripheralState.READER PeripheralState => which == WHICH.PeripheralState ? ctx.ReadStruct(0, Cereal.PeripheralState.READER.create) : default;
            public IReadOnlyList<Cereal.PandaState.READER> PandaStates => which == WHICH.PandaStates ? ctx.ReadList(0).Cast(Cereal.PandaState.READER.create) : default;
            public Cereal.NavInstruction.READER NavInstruction => which == WHICH.NavInstruction ? ctx.ReadStruct(0, Cereal.NavInstruction.READER.create) : default;
            public Cereal.NavRoute.READER NavRoute => which == WHICH.NavRoute ? ctx.ReadStruct(0, Cereal.NavRoute.READER.create) : default;
            public Cereal.Thumbnail.READER NavThumbnail => which == WHICH.NavThumbnail ? ctx.ReadStruct(0, Cereal.Thumbnail.READER.create) : default;
            public string ErrorLogMessage => which == WHICH.ErrorLogMessage ? ctx.ReadText(0, null) : default;
            public Cereal.EncodeData.READER RoadEncodeData => which == WHICH.RoadEncodeData ? ctx.ReadStruct(0, Cereal.EncodeData.READER.create) : default;
            public Cereal.EncodeData.READER DriverEncodeData => which == WHICH.DriverEncodeData ? ctx.ReadStruct(0, Cereal.EncodeData.READER.create) : default;
            public Cereal.EncodeData.READER WideRoadEncodeData => which == WHICH.WideRoadEncodeData ? ctx.ReadStruct(0, Cereal.EncodeData.READER.create) : default;
            public Cereal.EncodeData.READER QRoadEncodeData => which == WHICH.QRoadEncodeData ? ctx.ReadStruct(0, Cereal.EncodeData.READER.create) : default;
            public Cereal.EncodeIndex.READER QRoadEncodeIdx => which == WHICH.QRoadEncodeIdx ? ctx.ReadStruct(0, Cereal.EncodeIndex.READER.create) : default;
            public Cereal.GnssMeasurements.READER GnssMeasurements => which == WHICH.GnssMeasurements ? ctx.ReadStruct(0, Cereal.GnssMeasurements.READER.create) : default;
            public Cereal.DriverStateV2.READER DriverStateV2 => which == WHICH.DriverStateV2 ? ctx.ReadStruct(0, Cereal.DriverStateV2.READER.create) : default;
            public Cereal.UserFlag.READER UserFlag => which == WHICH.UserFlag ? ctx.ReadStruct(0, Cereal.UserFlag.READER.create) : default;
            public Cereal.LiveTorqueParametersData.READER LiveTorqueParameters => which == WHICH.LiveTorqueParameters ? ctx.ReadStruct(0, Cereal.LiveTorqueParametersData.READER.create) : default;
            public Cereal.SensorEventData.READER Magnetometer => which == WHICH.Magnetometer ? ctx.ReadStruct(0, Cereal.SensorEventData.READER.create) : default;
            public Cereal.SensorEventData.READER LightSensor => which == WHICH.LightSensor ? ctx.ReadStruct(0, Cereal.SensorEventData.READER.create) : default;
            public Cereal.SensorEventData.READER TemperatureSensor => which == WHICH.TemperatureSensor ? ctx.ReadStruct(0, Cereal.SensorEventData.READER.create) : default;
            public Cereal.SensorEventData.READER Accelerometer => which == WHICH.Accelerometer ? ctx.ReadStruct(0, Cereal.SensorEventData.READER.create) : default;
            public Cereal.SensorEventData.READER Gyroscope => which == WHICH.Gyroscope ? ctx.ReadStruct(0, Cereal.SensorEventData.READER.create) : default;
            public Cereal.SensorEventData.READER Gyroscope2 => which == WHICH.Gyroscope2 ? ctx.ReadStruct(0, Cereal.SensorEventData.READER.create) : default;
            public Cereal.SensorEventData.READER Accelerometer2 => which == WHICH.Accelerometer2 ? ctx.ReadStruct(0, Cereal.SensorEventData.READER.create) : default;
            public Cereal.UIDebug.READER UiDebug => which == WHICH.UiDebug ? ctx.ReadStruct(0, Cereal.UIDebug.READER.create) : default;
            public Cereal.Microphone.READER Microphone => which == WHICH.Microphone ? ctx.ReadStruct(0, Cereal.Microphone.READER.create) : default;
            public Cereal.NavModelData.READER NavModel => which == WHICH.NavModel ? ctx.ReadStruct(0, Cereal.NavModelData.READER.create) : default;
            public Cereal.MapRenderState.READER MapRenderState => which == WHICH.MapRenderState ? ctx.ReadStruct(0, Cereal.MapRenderState.READER.create) : default;
            public Cereal.UiPlan.READER UiPlan => which == WHICH.UiPlan ? ctx.ReadStruct(0, Cereal.UiPlan.READER.create) : default;
            public Cereal.CustomReserved0.READER CustomReserved0 => which == WHICH.CustomReserved0 ? ctx.ReadStruct(0, Cereal.CustomReserved0.READER.create) : default;
            public Cereal.CustomReserved1.READER CustomReserved1 => which == WHICH.CustomReserved1 ? ctx.ReadStruct(0, Cereal.CustomReserved1.READER.create) : default;
            public Cereal.CustomReserved2.READER CustomReserved2 => which == WHICH.CustomReserved2 ? ctx.ReadStruct(0, Cereal.CustomReserved2.READER.create) : default;
            public Cereal.CustomReserved3.READER CustomReserved3 => which == WHICH.CustomReserved3 ? ctx.ReadStruct(0, Cereal.CustomReserved3.READER.create) : default;
            public Cereal.CustomReserved4.READER CustomReserved4 => which == WHICH.CustomReserved4 ? ctx.ReadStruct(0, Cereal.CustomReserved4.READER.create) : default;
            public Cereal.CustomReserved5.READER CustomReserved5 => which == WHICH.CustomReserved5 ? ctx.ReadStruct(0, Cereal.CustomReserved5.READER.create) : default;
            public Cereal.CustomReserved6.READER CustomReserved6 => which == WHICH.CustomReserved6 ? ctx.ReadStruct(0, Cereal.CustomReserved6.READER.create) : default;
            public Cereal.CustomReserved7.READER CustomReserved7 => which == WHICH.CustomReserved7 ? ctx.ReadStruct(0, Cereal.CustomReserved7.READER.create) : default;
            public Cereal.CustomReserved8.READER CustomReserved8 => which == WHICH.CustomReserved8 ? ctx.ReadStruct(0, Cereal.CustomReserved8.READER.create) : default;
            public Cereal.CustomReserved9.READER CustomReserved9 => which == WHICH.CustomReserved9 ? ctx.ReadStruct(0, Cereal.CustomReserved9.READER.create) : default;
            public Cereal.EncodeIndex.READER LivestreamRoadEncodeIdx => which == WHICH.LivestreamRoadEncodeIdx ? ctx.ReadStruct(0, Cereal.EncodeIndex.READER.create) : default;
            public Cereal.EncodeIndex.READER LivestreamWideRoadEncodeIdx => which == WHICH.LivestreamWideRoadEncodeIdx ? ctx.ReadStruct(0, Cereal.EncodeIndex.READER.create) : default;
            public Cereal.EncodeIndex.READER LivestreamDriverEncodeIdx => which == WHICH.LivestreamDriverEncodeIdx ? ctx.ReadStruct(0, Cereal.EncodeIndex.READER.create) : default;
            public Cereal.EncodeData.READER LivestreamRoadEncodeData => which == WHICH.LivestreamRoadEncodeData ? ctx.ReadStruct(0, Cereal.EncodeData.READER.create) : default;
            public Cereal.EncodeData.READER LivestreamWideRoadEncodeData => which == WHICH.LivestreamWideRoadEncodeData ? ctx.ReadStruct(0, Cereal.EncodeData.READER.create) : default;
            public Cereal.EncodeData.READER LivestreamDriverEncodeData => which == WHICH.LivestreamDriverEncodeData ? ctx.ReadStruct(0, Cereal.EncodeData.READER.create) : default;
            public Cereal.SensorEventData.READER TemperatureSensor2 => which == WHICH.TemperatureSensor2 ? ctx.ReadStruct(0, Cereal.SensorEventData.READER.create) : default;
            public IReadOnlyList<byte> CustomReservedRawData0 => which == WHICH.CustomReservedRawData0 ? ctx.ReadList(0).CastByte() : default;
            public IReadOnlyList<byte> CustomReservedRawData1 => which == WHICH.CustomReservedRawData1 ? ctx.ReadList(0).CastByte() : default;
            public IReadOnlyList<byte> CustomReservedRawData2 => which == WHICH.CustomReservedRawData2 ? ctx.ReadList(0).CastByte() : default;
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(2, 1);
            }

            public WHICH which
            {
                get => (WHICH)this.ReadDataUShort(64U, (ushort)0);
                set => this.WriteData(64U, (ushort)value, (ushort)0);
            }

            public ulong LogMonoTime
            {
                get => this.ReadDataULong(0UL, 0UL);
                set => this.WriteData(0UL, value, 0UL);
            }

            public Cereal.InitData.WRITER InitData
            {
                get => which == WHICH.InitData ? BuildPointer<Cereal.InitData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.FrameData.WRITER RoadCameraState
            {
                get => which == WHICH.RoadCameraState ? BuildPointer<Cereal.FrameData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.GPSNMEAData.WRITER GpsNMEA
            {
                get => which == WHICH.GpsNMEA ? BuildPointer<Cereal.GPSNMEAData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.SensorEventData.WRITER SensorEventDEPRECATED
            {
                get => which == WHICH.SensorEventDEPRECATED ? BuildPointer<Cereal.SensorEventData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public ListOfStructsSerializer<Cereal.CanData.WRITER> Can
            {
                get => which == WHICH.Can ? BuildPointer<ListOfStructsSerializer<Cereal.CanData.WRITER>>(0) : default;
                set => Link(0, value);
            }

            public Cereal.DeviceState.WRITER DeviceState
            {
                get => which == WHICH.DeviceState ? BuildPointer<Cereal.DeviceState.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.ControlsState.WRITER ControlsState
            {
                get => which == WHICH.ControlsState ? BuildPointer<Cereal.ControlsState.WRITER>(0) : default;
                set => Link(0, value);
            }

            public ListOfStructsSerializer<Cereal.LiveEventData.WRITER> LiveEventDEPRECATED
            {
                get => which == WHICH.LiveEventDEPRECATED ? BuildPointer<ListOfStructsSerializer<Cereal.LiveEventData.WRITER>>(0) : default;
                set => Link(0, value);
            }

            public Cereal.ModelData.WRITER Model
            {
                get => which == WHICH.Model ? BuildPointer<Cereal.ModelData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.CalibrationFeatures.WRITER FeaturesDEPRECATED
            {
                get => which == WHICH.FeaturesDEPRECATED ? BuildPointer<Cereal.CalibrationFeatures.WRITER>(0) : default;
                set => Link(0, value);
            }

            public ListOfStructsSerializer<Cereal.SensorEventData.WRITER> SensorEventsDEPRECATED
            {
                get => which == WHICH.SensorEventsDEPRECATED ? BuildPointer<ListOfStructsSerializer<Cereal.SensorEventData.WRITER>>(0) : default;
                set => Link(0, value);
            }

            public Cereal.PandaState.WRITER PandaStateDEPRECATED
            {
                get => which == WHICH.PandaStateDEPRECATED ? BuildPointer<Cereal.PandaState.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.RadarState.WRITER RadarState
            {
                get => which == WHICH.RadarState ? BuildPointer<Cereal.RadarState.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.LiveUI.WRITER LiveUIDEPRECATED
            {
                get => which == WHICH.LiveUIDEPRECATED ? BuildPointer<Cereal.LiveUI.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.EncodeIndex.WRITER RoadEncodeIdx
            {
                get => which == WHICH.RoadEncodeIdx ? BuildPointer<Cereal.EncodeIndex.WRITER>(0) : default;
                set => Link(0, value);
            }

            public ListOfStructsSerializer<Cereal.LiveTracks.WRITER> LiveTracks
            {
                get => which == WHICH.LiveTracks ? BuildPointer<ListOfStructsSerializer<Cereal.LiveTracks.WRITER>>(0) : default;
                set => Link(0, value);
            }

            public ListOfStructsSerializer<Cereal.CanData.WRITER> Sendcan
            {
                get => which == WHICH.Sendcan ? BuildPointer<ListOfStructsSerializer<Cereal.CanData.WRITER>>(0) : default;
                set => Link(0, value);
            }

            public string LogMessage
            {
                get => which == WHICH.LogMessage ? this.ReadText(0, null) : default;
                set => this.WriteText(0, value, null);
            }

            public Cereal.LiveCalibrationData.WRITER LiveCalibration
            {
                get => which == WHICH.LiveCalibration ? BuildPointer<Cereal.LiveCalibrationData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.AndroidLogEntry.WRITER AndroidLog
            {
                get => which == WHICH.AndroidLog ? BuildPointer<Cereal.AndroidLogEntry.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.GpsLocationData.WRITER GpsLocation
            {
                get => which == WHICH.GpsLocation ? BuildPointer<Cereal.GpsLocationData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.CarState.WRITER CarState
            {
                get => which == WHICH.CarState ? BuildPointer<Cereal.CarState.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.CarControl.WRITER CarControl
            {
                get => which == WHICH.CarControl ? BuildPointer<Cereal.CarControl.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.LongitudinalPlan.WRITER LongitudinalPlan
            {
                get => which == WHICH.LongitudinalPlan ? BuildPointer<Cereal.LongitudinalPlan.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.LiveLocationData.WRITER LiveLocationDEPRECATED
            {
                get => which == WHICH.LiveLocationDEPRECATED ? BuildPointer<Cereal.LiveLocationData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public ListOfStructsSerializer<Cereal.EthernetPacket.WRITER> EthernetDataDEPRECATED
            {
                get => which == WHICH.EthernetDataDEPRECATED ? BuildPointer<ListOfStructsSerializer<Cereal.EthernetPacket.WRITER>>(0) : default;
                set => Link(0, value);
            }

            public Cereal.NavUpdate.WRITER NavUpdateDEPRECATED
            {
                get => which == WHICH.NavUpdateDEPRECATED ? BuildPointer<Cereal.NavUpdate.WRITER>(0) : default;
                set => Link(0, value);
            }

            public ListOfStructsSerializer<Cereal.CellInfo.WRITER> CellInfoDEPRECATED
            {
                get => which == WHICH.CellInfoDEPRECATED ? BuildPointer<ListOfStructsSerializer<Cereal.CellInfo.WRITER>>(0) : default;
                set => Link(0, value);
            }

            public ListOfStructsSerializer<Cereal.WifiScan.WRITER> WifiScanDEPRECATED
            {
                get => which == WHICH.WifiScanDEPRECATED ? BuildPointer<ListOfStructsSerializer<Cereal.WifiScan.WRITER>>(0) : default;
                set => Link(0, value);
            }

            public Cereal.AndroidGnss.WRITER AndroidGnssDEPRECATED
            {
                get => which == WHICH.AndroidGnssDEPRECATED ? BuildPointer<Cereal.AndroidGnss.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.QcomGnss.WRITER QcomGnss
            {
                get => which == WHICH.QcomGnss ? BuildPointer<Cereal.QcomGnss.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.LidarPts.WRITER LidarPtsDEPRECATED
            {
                get => which == WHICH.LidarPtsDEPRECATED ? BuildPointer<Cereal.LidarPts.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.ProcLog.WRITER ProcLog
            {
                get => which == WHICH.ProcLog ? BuildPointer<Cereal.ProcLog.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.UbloxGnss.WRITER UbloxGnss
            {
                get => which == WHICH.UbloxGnss ? BuildPointer<Cereal.UbloxGnss.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.Clocks.WRITER Clocks
            {
                get => which == WHICH.Clocks ? BuildPointer<Cereal.Clocks.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.LiveMpcData.WRITER LiveMpcDEPRECATED
            {
                get => which == WHICH.LiveMpcDEPRECATED ? BuildPointer<Cereal.LiveMpcData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.LiveLongitudinalMpcData.WRITER LiveLongitudinalMpcDEPRECATED
            {
                get => which == WHICH.LiveLongitudinalMpcDEPRECATED ? BuildPointer<Cereal.LiveLongitudinalMpcData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.NavStatus.WRITER NavStatusDEPRECATED
            {
                get => which == WHICH.NavStatusDEPRECATED ? BuildPointer<Cereal.NavStatus.WRITER>(0) : default;
                set => Link(0, value);
            }

            public ListOfPrimitivesSerializer<byte> UbloxRaw
            {
                get => which == WHICH.UbloxRaw ? BuildPointer<ListOfPrimitivesSerializer<byte>>(0) : default;
                set => Link(0, value);
            }

            public Cereal.GPSPlannerPoints.WRITER GpsPlannerPointsDEPRECATED
            {
                get => which == WHICH.GpsPlannerPointsDEPRECATED ? BuildPointer<Cereal.GPSPlannerPoints.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.GPSPlannerPlan.WRITER GpsPlannerPlanDEPRECATED
            {
                get => which == WHICH.GpsPlannerPlanDEPRECATED ? BuildPointer<Cereal.GPSPlannerPlan.WRITER>(0) : default;
                set => Link(0, value);
            }

            public ListOfPrimitivesSerializer<byte> ApplanixRawDEPRECATED
            {
                get => which == WHICH.ApplanixRawDEPRECATED ? BuildPointer<ListOfPrimitivesSerializer<byte>>(0) : default;
                set => Link(0, value);
            }

            public ListOfStructsSerializer<Cereal.TrafficEvent.WRITER> TrafficEventsDEPRECATED
            {
                get => which == WHICH.TrafficEventsDEPRECATED ? BuildPointer<ListOfStructsSerializer<Cereal.TrafficEvent.WRITER>>(0) : default;
                set => Link(0, value);
            }

            public Cereal.LiveLocationData.WRITER LiveLocationTimingDEPRECATED
            {
                get => which == WHICH.LiveLocationTimingDEPRECATED ? BuildPointer<Cereal.LiveLocationData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.OrbslamCorrection.WRITER OrbslamCorrectionDEPRECATED
            {
                get => which == WHICH.OrbslamCorrectionDEPRECATED ? BuildPointer<Cereal.OrbslamCorrection.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.LiveLocationData.WRITER LiveLocationCorrectedDEPRECATED
            {
                get => which == WHICH.LiveLocationCorrectedDEPRECATED ? BuildPointer<Cereal.LiveLocationData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public ListOfStructsSerializer<Cereal.OrbObservation.WRITER> OrbObservationDEPRECATED
            {
                get => which == WHICH.OrbObservationDEPRECATED ? BuildPointer<ListOfStructsSerializer<Cereal.OrbObservation.WRITER>>(0) : default;
                set => Link(0, value);
            }

            public Cereal.GpsLocationData.WRITER GpsLocationExternal
            {
                get => which == WHICH.GpsLocationExternal ? BuildPointer<Cereal.GpsLocationData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.LiveLocationData.WRITER LocationDEPRECATED
            {
                get => which == WHICH.LocationDEPRECATED ? BuildPointer<Cereal.LiveLocationData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.UiNavigationEvent.WRITER UiNavigationEventDEPRECATED
            {
                get => which == WHICH.UiNavigationEventDEPRECATED ? BuildPointer<Cereal.UiNavigationEvent.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.LiveLocationData.WRITER LiveLocationKalmanDEPRECATED
            {
                get => which == WHICH.LiveLocationKalmanDEPRECATED ? BuildPointer<Cereal.LiveLocationData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.Joystick.WRITER TestJoystick
            {
                get => which == WHICH.TestJoystick ? BuildPointer<Cereal.Joystick.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.OrbOdometry.WRITER OrbOdometryDEPRECATED
            {
                get => which == WHICH.OrbOdometryDEPRECATED ? BuildPointer<Cereal.OrbOdometry.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.OrbFeatures.WRITER OrbFeaturesDEPRECATED
            {
                get => which == WHICH.OrbFeaturesDEPRECATED ? BuildPointer<Cereal.OrbFeatures.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.LiveLocationData.WRITER ApplanixLocationDEPRECATED
            {
                get => which == WHICH.ApplanixLocationDEPRECATED ? BuildPointer<Cereal.LiveLocationData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.OrbKeyFrame.WRITER OrbKeyFrameDEPRECATED
            {
                get => which == WHICH.OrbKeyFrameDEPRECATED ? BuildPointer<Cereal.OrbKeyFrame.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.UiLayoutState.WRITER UiLayoutStateDEPRECATED
            {
                get => which == WHICH.UiLayoutStateDEPRECATED ? BuildPointer<Cereal.UiLayoutState.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.OrbFeaturesSummary.WRITER OrbFeaturesSummaryDEPRECATED
            {
                get => which == WHICH.OrbFeaturesSummaryDEPRECATED ? BuildPointer<Cereal.OrbFeaturesSummary.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.DriverStateDEPRECATED.WRITER DriverStateDEPRECATED
            {
                get => which == WHICH.DriverStateDEPRECATED ? BuildPointer<Cereal.DriverStateDEPRECATED.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.Boot.WRITER Boot
            {
                get => which == WHICH.Boot ? BuildPointer<Cereal.Boot.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.LiveParametersData.WRITER LiveParameters
            {
                get => which == WHICH.LiveParameters ? BuildPointer<Cereal.LiveParametersData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.LiveMapDataDEPRECATED.WRITER LiveMapDataDEPRECATED
            {
                get => which == WHICH.LiveMapDataDEPRECATED ? BuildPointer<Cereal.LiveMapDataDEPRECATED.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.CameraOdometry.WRITER CameraOdometry
            {
                get => which == WHICH.CameraOdometry ? BuildPointer<Cereal.CameraOdometry.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.LateralPlan.WRITER LateralPlanDEPRECATED
            {
                get => which == WHICH.LateralPlanDEPRECATED ? BuildPointer<Cereal.LateralPlan.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.KalmanOdometry.WRITER KalmanOdometryDEPRECATED
            {
                get => which == WHICH.KalmanOdometryDEPRECATED ? BuildPointer<Cereal.KalmanOdometry.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.Thumbnail.WRITER Thumbnail
            {
                get => which == WHICH.Thumbnail ? BuildPointer<Cereal.Thumbnail.WRITER>(0) : default;
                set => Link(0, value);
            }

            public bool Valid
            {
                get => this.ReadDataBool(80UL, true);
                set => this.WriteData(80UL, value, true);
            }

            public ListOfStructsSerializer<Cereal.CarEvent.WRITER> OnroadEvents
            {
                get => which == WHICH.OnroadEvents ? BuildPointer<ListOfStructsSerializer<Cereal.CarEvent.WRITER>>(0) : default;
                set => Link(0, value);
            }

            public Cereal.CarParams.WRITER CarParams
            {
                get => which == WHICH.CarParams ? BuildPointer<Cereal.CarParams.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.FrameData.WRITER DriverCameraState
            {
                get => which == WHICH.DriverCameraState ? BuildPointer<Cereal.FrameData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.DriverMonitoringState.WRITER DriverMonitoringState
            {
                get => which == WHICH.DriverMonitoringState ? BuildPointer<Cereal.DriverMonitoringState.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.LiveLocationKalman.WRITER LiveLocationKalman
            {
                get => which == WHICH.LiveLocationKalman ? BuildPointer<Cereal.LiveLocationKalman.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.Sentinel.WRITER Sentinel
            {
                get => which == WHICH.Sentinel ? BuildPointer<Cereal.Sentinel.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.FrameData.WRITER WideRoadCameraState
            {
                get => which == WHICH.WideRoadCameraState ? BuildPointer<Cereal.FrameData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.ModelDataV2.WRITER ModelV2
            {
                get => which == WHICH.ModelV2 ? BuildPointer<Cereal.ModelDataV2.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.EncodeIndex.WRITER DriverEncodeIdx
            {
                get => which == WHICH.DriverEncodeIdx ? BuildPointer<Cereal.EncodeIndex.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.EncodeIndex.WRITER WideRoadEncodeIdx
            {
                get => which == WHICH.WideRoadEncodeIdx ? BuildPointer<Cereal.EncodeIndex.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.ManagerState.WRITER ManagerState
            {
                get => which == WHICH.ManagerState ? BuildPointer<Cereal.ManagerState.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.UploaderState.WRITER UploaderState
            {
                get => which == WHICH.UploaderState ? BuildPointer<Cereal.UploaderState.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.PeripheralState.WRITER PeripheralState
            {
                get => which == WHICH.PeripheralState ? BuildPointer<Cereal.PeripheralState.WRITER>(0) : default;
                set => Link(0, value);
            }

            public ListOfStructsSerializer<Cereal.PandaState.WRITER> PandaStates
            {
                get => which == WHICH.PandaStates ? BuildPointer<ListOfStructsSerializer<Cereal.PandaState.WRITER>>(0) : default;
                set => Link(0, value);
            }

            public Cereal.NavInstruction.WRITER NavInstruction
            {
                get => which == WHICH.NavInstruction ? BuildPointer<Cereal.NavInstruction.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.NavRoute.WRITER NavRoute
            {
                get => which == WHICH.NavRoute ? BuildPointer<Cereal.NavRoute.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.Thumbnail.WRITER NavThumbnail
            {
                get => which == WHICH.NavThumbnail ? BuildPointer<Cereal.Thumbnail.WRITER>(0) : default;
                set => Link(0, value);
            }

            public string ErrorLogMessage
            {
                get => which == WHICH.ErrorLogMessage ? this.ReadText(0, null) : default;
                set => this.WriteText(0, value, null);
            }

            public Cereal.EncodeData.WRITER RoadEncodeData
            {
                get => which == WHICH.RoadEncodeData ? BuildPointer<Cereal.EncodeData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.EncodeData.WRITER DriverEncodeData
            {
                get => which == WHICH.DriverEncodeData ? BuildPointer<Cereal.EncodeData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.EncodeData.WRITER WideRoadEncodeData
            {
                get => which == WHICH.WideRoadEncodeData ? BuildPointer<Cereal.EncodeData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.EncodeData.WRITER QRoadEncodeData
            {
                get => which == WHICH.QRoadEncodeData ? BuildPointer<Cereal.EncodeData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.EncodeIndex.WRITER QRoadEncodeIdx
            {
                get => which == WHICH.QRoadEncodeIdx ? BuildPointer<Cereal.EncodeIndex.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.GnssMeasurements.WRITER GnssMeasurements
            {
                get => which == WHICH.GnssMeasurements ? BuildPointer<Cereal.GnssMeasurements.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.DriverStateV2.WRITER DriverStateV2
            {
                get => which == WHICH.DriverStateV2 ? BuildPointer<Cereal.DriverStateV2.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.UserFlag.WRITER UserFlag
            {
                get => which == WHICH.UserFlag ? BuildPointer<Cereal.UserFlag.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.LiveTorqueParametersData.WRITER LiveTorqueParameters
            {
                get => which == WHICH.LiveTorqueParameters ? BuildPointer<Cereal.LiveTorqueParametersData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.SensorEventData.WRITER Magnetometer
            {
                get => which == WHICH.Magnetometer ? BuildPointer<Cereal.SensorEventData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.SensorEventData.WRITER LightSensor
            {
                get => which == WHICH.LightSensor ? BuildPointer<Cereal.SensorEventData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.SensorEventData.WRITER TemperatureSensor
            {
                get => which == WHICH.TemperatureSensor ? BuildPointer<Cereal.SensorEventData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.SensorEventData.WRITER Accelerometer
            {
                get => which == WHICH.Accelerometer ? BuildPointer<Cereal.SensorEventData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.SensorEventData.WRITER Gyroscope
            {
                get => which == WHICH.Gyroscope ? BuildPointer<Cereal.SensorEventData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.SensorEventData.WRITER Gyroscope2
            {
                get => which == WHICH.Gyroscope2 ? BuildPointer<Cereal.SensorEventData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.SensorEventData.WRITER Accelerometer2
            {
                get => which == WHICH.Accelerometer2 ? BuildPointer<Cereal.SensorEventData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.UIDebug.WRITER UiDebug
            {
                get => which == WHICH.UiDebug ? BuildPointer<Cereal.UIDebug.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.Microphone.WRITER Microphone
            {
                get => which == WHICH.Microphone ? BuildPointer<Cereal.Microphone.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.NavModelData.WRITER NavModel
            {
                get => which == WHICH.NavModel ? BuildPointer<Cereal.NavModelData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.MapRenderState.WRITER MapRenderState
            {
                get => which == WHICH.MapRenderState ? BuildPointer<Cereal.MapRenderState.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.UiPlan.WRITER UiPlan
            {
                get => which == WHICH.UiPlan ? BuildPointer<Cereal.UiPlan.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.CustomReserved0.WRITER CustomReserved0
            {
                get => which == WHICH.CustomReserved0 ? BuildPointer<Cereal.CustomReserved0.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.CustomReserved1.WRITER CustomReserved1
            {
                get => which == WHICH.CustomReserved1 ? BuildPointer<Cereal.CustomReserved1.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.CustomReserved2.WRITER CustomReserved2
            {
                get => which == WHICH.CustomReserved2 ? BuildPointer<Cereal.CustomReserved2.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.CustomReserved3.WRITER CustomReserved3
            {
                get => which == WHICH.CustomReserved3 ? BuildPointer<Cereal.CustomReserved3.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.CustomReserved4.WRITER CustomReserved4
            {
                get => which == WHICH.CustomReserved4 ? BuildPointer<Cereal.CustomReserved4.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.CustomReserved5.WRITER CustomReserved5
            {
                get => which == WHICH.CustomReserved5 ? BuildPointer<Cereal.CustomReserved5.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.CustomReserved6.WRITER CustomReserved6
            {
                get => which == WHICH.CustomReserved6 ? BuildPointer<Cereal.CustomReserved6.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.CustomReserved7.WRITER CustomReserved7
            {
                get => which == WHICH.CustomReserved7 ? BuildPointer<Cereal.CustomReserved7.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.CustomReserved8.WRITER CustomReserved8
            {
                get => which == WHICH.CustomReserved8 ? BuildPointer<Cereal.CustomReserved8.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.CustomReserved9.WRITER CustomReserved9
            {
                get => which == WHICH.CustomReserved9 ? BuildPointer<Cereal.CustomReserved9.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.EncodeIndex.WRITER LivestreamRoadEncodeIdx
            {
                get => which == WHICH.LivestreamRoadEncodeIdx ? BuildPointer<Cereal.EncodeIndex.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.EncodeIndex.WRITER LivestreamWideRoadEncodeIdx
            {
                get => which == WHICH.LivestreamWideRoadEncodeIdx ? BuildPointer<Cereal.EncodeIndex.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.EncodeIndex.WRITER LivestreamDriverEncodeIdx
            {
                get => which == WHICH.LivestreamDriverEncodeIdx ? BuildPointer<Cereal.EncodeIndex.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.EncodeData.WRITER LivestreamRoadEncodeData
            {
                get => which == WHICH.LivestreamRoadEncodeData ? BuildPointer<Cereal.EncodeData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.EncodeData.WRITER LivestreamWideRoadEncodeData
            {
                get => which == WHICH.LivestreamWideRoadEncodeData ? BuildPointer<Cereal.EncodeData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.EncodeData.WRITER LivestreamDriverEncodeData
            {
                get => which == WHICH.LivestreamDriverEncodeData ? BuildPointer<Cereal.EncodeData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public Cereal.SensorEventData.WRITER TemperatureSensor2
            {
                get => which == WHICH.TemperatureSensor2 ? BuildPointer<Cereal.SensorEventData.WRITER>(0) : default;
                set => Link(0, value);
            }

            public ListOfPrimitivesSerializer<byte> CustomReservedRawData0
            {
                get => which == WHICH.CustomReservedRawData0 ? BuildPointer<ListOfPrimitivesSerializer<byte>>(0) : default;
                set => Link(0, value);
            }

            public ListOfPrimitivesSerializer<byte> CustomReservedRawData1
            {
                get => which == WHICH.CustomReservedRawData1 ? BuildPointer<ListOfPrimitivesSerializer<byte>>(0) : default;
                set => Link(0, value);
            }

            public ListOfPrimitivesSerializer<byte> CustomReservedRawData2
            {
                get => which == WHICH.CustomReservedRawData2 ? BuildPointer<ListOfPrimitivesSerializer<byte>>(0) : default;
                set => Link(0, value);
            }
        }
    }
}
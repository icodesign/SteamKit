// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: gameevents.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.GC.Deadlock.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgVDebugGameSessionIDEvent : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public int clientid
        {
            get => __pbn__clientid.GetValueOrDefault();
            set => __pbn__clientid = value;
        }
        public bool ShouldSerializeclientid() => __pbn__clientid != null;
        public void Resetclientid() => __pbn__clientid = null;
        private int? __pbn__clientid;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string gamesessionid
        {
            get => __pbn__gamesessionid ?? "";
            set => __pbn__gamesessionid = value;
        }
        public bool ShouldSerializegamesessionid() => __pbn__gamesessionid != null;
        public void Resetgamesessionid() => __pbn__gamesessionid = null;
        private string __pbn__gamesessionid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgPlaceDecalEvent : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public CMsgVector position { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public CMsgVector normal { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public CMsgVector saxis { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public uint decalmaterialindex
        {
            get => __pbn__decalmaterialindex.GetValueOrDefault();
            set => __pbn__decalmaterialindex = value;
        }
        public bool ShouldSerializedecalmaterialindex() => __pbn__decalmaterialindex != null;
        public void Resetdecalmaterialindex() => __pbn__decalmaterialindex = null;
        private uint? __pbn__decalmaterialindex;

        [global::ProtoBuf.ProtoMember(5)]
        public uint flags
        {
            get => __pbn__flags.GetValueOrDefault();
            set => __pbn__flags = value;
        }
        public bool ShouldSerializeflags() => __pbn__flags != null;
        public void Resetflags() => __pbn__flags = null;
        private uint? __pbn__flags;

        [global::ProtoBuf.ProtoMember(6, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public uint color
        {
            get => __pbn__color.GetValueOrDefault();
            set => __pbn__color = value;
        }
        public bool ShouldSerializecolor() => __pbn__color != null;
        public void Resetcolor() => __pbn__color = null;
        private uint? __pbn__color;

        [global::ProtoBuf.ProtoMember(7)]
        public float width
        {
            get => __pbn__width.GetValueOrDefault();
            set => __pbn__width = value;
        }
        public bool ShouldSerializewidth() => __pbn__width != null;
        public void Resetwidth() => __pbn__width = null;
        private float? __pbn__width;

        [global::ProtoBuf.ProtoMember(8)]
        public float height
        {
            get => __pbn__height.GetValueOrDefault();
            set => __pbn__height = value;
        }
        public bool ShouldSerializeheight() => __pbn__height != null;
        public void Resetheight() => __pbn__height = null;
        private float? __pbn__height;

        [global::ProtoBuf.ProtoMember(9)]
        public float depth
        {
            get => __pbn__depth.GetValueOrDefault();
            set => __pbn__depth = value;
        }
        public bool ShouldSerializedepth() => __pbn__depth != null;
        public void Resetdepth() => __pbn__depth = null;
        private float? __pbn__depth;

        [global::ProtoBuf.ProtoMember(10)]
        public uint entityhandleindex
        {
            get => __pbn__entityhandleindex.GetValueOrDefault();
            set => __pbn__entityhandleindex = value;
        }
        public bool ShouldSerializeentityhandleindex() => __pbn__entityhandleindex != null;
        public void Resetentityhandleindex() => __pbn__entityhandleindex = null;
        private uint? __pbn__entityhandleindex;

        [global::ProtoBuf.ProtoMember(11, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public uint skeletoninstancehash
        {
            get => __pbn__skeletoninstancehash.GetValueOrDefault();
            set => __pbn__skeletoninstancehash = value;
        }
        public bool ShouldSerializeskeletoninstancehash() => __pbn__skeletoninstancehash != null;
        public void Resetskeletoninstancehash() => __pbn__skeletoninstancehash = null;
        private uint? __pbn__skeletoninstancehash;

        [global::ProtoBuf.ProtoMember(12)]
        public int boneindex
        {
            get => __pbn__boneindex.GetValueOrDefault();
            set => __pbn__boneindex = value;
        }
        public bool ShouldSerializeboneindex() => __pbn__boneindex != null;
        public void Resetboneindex() => __pbn__boneindex = null;
        private int? __pbn__boneindex;

        [global::ProtoBuf.ProtoMember(13)]
        public bool translucenthit
        {
            get => __pbn__translucenthit.GetValueOrDefault();
            set => __pbn__translucenthit = value;
        }
        public bool ShouldSerializetranslucenthit() => __pbn__translucenthit != null;
        public void Resettranslucenthit() => __pbn__translucenthit = null;
        private bool? __pbn__translucenthit;

        [global::ProtoBuf.ProtoMember(14)]
        public bool is_adjacent
        {
            get => __pbn__is_adjacent.GetValueOrDefault();
            set => __pbn__is_adjacent = value;
        }
        public bool ShouldSerializeis_adjacent() => __pbn__is_adjacent != null;
        public void Resetis_adjacent() => __pbn__is_adjacent = null;
        private bool? __pbn__is_adjacent;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgClearWorldDecalsEvent : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint flagstoclear
        {
            get => __pbn__flagstoclear.GetValueOrDefault();
            set => __pbn__flagstoclear = value;
        }
        public bool ShouldSerializeflagstoclear() => __pbn__flagstoclear != null;
        public void Resetflagstoclear() => __pbn__flagstoclear = null;
        private uint? __pbn__flagstoclear;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgClearEntityDecalsEvent : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint flagstoclear
        {
            get => __pbn__flagstoclear.GetValueOrDefault();
            set => __pbn__flagstoclear = value;
        }
        public bool ShouldSerializeflagstoclear() => __pbn__flagstoclear != null;
        public void Resetflagstoclear() => __pbn__flagstoclear = null;
        private uint? __pbn__flagstoclear;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgClearDecalsForSkeletonInstanceEvent : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint flagstoclear
        {
            get => __pbn__flagstoclear.GetValueOrDefault();
            set => __pbn__flagstoclear = value;
        }
        public bool ShouldSerializeflagstoclear() => __pbn__flagstoclear != null;
        public void Resetflagstoclear() => __pbn__flagstoclear = null;
        private uint? __pbn__flagstoclear;

        [global::ProtoBuf.ProtoMember(2)]
        public uint entityhandleindex
        {
            get => __pbn__entityhandleindex.GetValueOrDefault();
            set => __pbn__entityhandleindex = value;
        }
        public bool ShouldSerializeentityhandleindex() => __pbn__entityhandleindex != null;
        public void Resetentityhandleindex() => __pbn__entityhandleindex = null;
        private uint? __pbn__entityhandleindex;

        [global::ProtoBuf.ProtoMember(3)]
        public uint skeletoninstancehash
        {
            get => __pbn__skeletoninstancehash.GetValueOrDefault();
            set => __pbn__skeletoninstancehash = value;
        }
        public bool ShouldSerializeskeletoninstancehash() => __pbn__skeletoninstancehash != null;
        public void Resetskeletoninstancehash() => __pbn__skeletoninstancehash = null;
        private uint? __pbn__skeletoninstancehash;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgSource1LegacyGameEventList : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<descriptor_t> descriptors { get; } = new global::System.Collections.Generic.List<descriptor_t>();

        [global::ProtoBuf.ProtoContract()]
        public partial class key_t : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            public int type
            {
                get => __pbn__type.GetValueOrDefault();
                set => __pbn__type = value;
            }
            public bool ShouldSerializetype() => __pbn__type != null;
            public void Resettype() => __pbn__type = null;
            private int? __pbn__type;

            [global::ProtoBuf.ProtoMember(2)]
            [global::System.ComponentModel.DefaultValue("")]
            public string name
            {
                get => __pbn__name ?? "";
                set => __pbn__name = value;
            }
            public bool ShouldSerializename() => __pbn__name != null;
            public void Resetname() => __pbn__name = null;
            private string __pbn__name;

        }

        [global::ProtoBuf.ProtoContract()]
        public partial class descriptor_t : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            public int eventid
            {
                get => __pbn__eventid.GetValueOrDefault();
                set => __pbn__eventid = value;
            }
            public bool ShouldSerializeeventid() => __pbn__eventid != null;
            public void Reseteventid() => __pbn__eventid = null;
            private int? __pbn__eventid;

            [global::ProtoBuf.ProtoMember(2)]
            [global::System.ComponentModel.DefaultValue("")]
            public string name
            {
                get => __pbn__name ?? "";
                set => __pbn__name = value;
            }
            public bool ShouldSerializename() => __pbn__name != null;
            public void Resetname() => __pbn__name = null;
            private string __pbn__name;

            [global::ProtoBuf.ProtoMember(3)]
            public global::System.Collections.Generic.List<CMsgSource1LegacyGameEventList.key_t> keys { get; } = new global::System.Collections.Generic.List<CMsgSource1LegacyGameEventList.key_t>();

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgSource1LegacyListenEvents : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public int playerslot
        {
            get => __pbn__playerslot.GetValueOrDefault();
            set => __pbn__playerslot = value;
        }
        public bool ShouldSerializeplayerslot() => __pbn__playerslot != null;
        public void Resetplayerslot() => __pbn__playerslot = null;
        private int? __pbn__playerslot;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<uint> eventarraybits { get; } = new global::System.Collections.Generic.List<uint>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgSource1LegacyGameEvent : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string event_name
        {
            get => __pbn__event_name ?? "";
            set => __pbn__event_name = value;
        }
        public bool ShouldSerializeevent_name() => __pbn__event_name != null;
        public void Resetevent_name() => __pbn__event_name = null;
        private string __pbn__event_name;

        [global::ProtoBuf.ProtoMember(2)]
        public int eventid
        {
            get => __pbn__eventid.GetValueOrDefault();
            set => __pbn__eventid = value;
        }
        public bool ShouldSerializeeventid() => __pbn__eventid != null;
        public void Reseteventid() => __pbn__eventid = null;
        private int? __pbn__eventid;

        [global::ProtoBuf.ProtoMember(3)]
        public global::System.Collections.Generic.List<key_t> keys { get; } = new global::System.Collections.Generic.List<key_t>();

        [global::ProtoBuf.ProtoMember(4)]
        public int server_tick
        {
            get => __pbn__server_tick.GetValueOrDefault();
            set => __pbn__server_tick = value;
        }
        public bool ShouldSerializeserver_tick() => __pbn__server_tick != null;
        public void Resetserver_tick() => __pbn__server_tick = null;
        private int? __pbn__server_tick;

        [global::ProtoBuf.ProtoMember(5)]
        public int passthrough
        {
            get => __pbn__passthrough.GetValueOrDefault();
            set => __pbn__passthrough = value;
        }
        public bool ShouldSerializepassthrough() => __pbn__passthrough != null;
        public void Resetpassthrough() => __pbn__passthrough = null;
        private int? __pbn__passthrough;

        [global::ProtoBuf.ProtoContract()]
        public partial class key_t : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            public int type
            {
                get => __pbn__type.GetValueOrDefault();
                set => __pbn__type = value;
            }
            public bool ShouldSerializetype() => __pbn__type != null;
            public void Resettype() => __pbn__type = null;
            private int? __pbn__type;

            [global::ProtoBuf.ProtoMember(2)]
            [global::System.ComponentModel.DefaultValue("")]
            public string val_string
            {
                get => __pbn__val_string ?? "";
                set => __pbn__val_string = value;
            }
            public bool ShouldSerializeval_string() => __pbn__val_string != null;
            public void Resetval_string() => __pbn__val_string = null;
            private string __pbn__val_string;

            [global::ProtoBuf.ProtoMember(3)]
            public float val_float
            {
                get => __pbn__val_float.GetValueOrDefault();
                set => __pbn__val_float = value;
            }
            public bool ShouldSerializeval_float() => __pbn__val_float != null;
            public void Resetval_float() => __pbn__val_float = null;
            private float? __pbn__val_float;

            [global::ProtoBuf.ProtoMember(4)]
            public int val_long
            {
                get => __pbn__val_long.GetValueOrDefault();
                set => __pbn__val_long = value;
            }
            public bool ShouldSerializeval_long() => __pbn__val_long != null;
            public void Resetval_long() => __pbn__val_long = null;
            private int? __pbn__val_long;

            [global::ProtoBuf.ProtoMember(5)]
            public int val_short
            {
                get => __pbn__val_short.GetValueOrDefault();
                set => __pbn__val_short = value;
            }
            public bool ShouldSerializeval_short() => __pbn__val_short != null;
            public void Resetval_short() => __pbn__val_short = null;
            private int? __pbn__val_short;

            [global::ProtoBuf.ProtoMember(6)]
            public int val_byte
            {
                get => __pbn__val_byte.GetValueOrDefault();
                set => __pbn__val_byte = value;
            }
            public bool ShouldSerializeval_byte() => __pbn__val_byte != null;
            public void Resetval_byte() => __pbn__val_byte = null;
            private int? __pbn__val_byte;

            [global::ProtoBuf.ProtoMember(7)]
            public bool val_bool
            {
                get => __pbn__val_bool.GetValueOrDefault();
                set => __pbn__val_bool = value;
            }
            public bool ShouldSerializeval_bool() => __pbn__val_bool != null;
            public void Resetval_bool() => __pbn__val_bool = null;
            private bool? __pbn__val_bool;

            [global::ProtoBuf.ProtoMember(8)]
            public ulong val_uint64
            {
                get => __pbn__val_uint64.GetValueOrDefault();
                set => __pbn__val_uint64 = value;
            }
            public bool ShouldSerializeval_uint64() => __pbn__val_uint64 != null;
            public void Resetval_uint64() => __pbn__val_uint64 = null;
            private ulong? __pbn__val_uint64;

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgSosStartSoundEvent : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public int soundevent_guid
        {
            get => __pbn__soundevent_guid.GetValueOrDefault();
            set => __pbn__soundevent_guid = value;
        }
        public bool ShouldSerializesoundevent_guid() => __pbn__soundevent_guid != null;
        public void Resetsoundevent_guid() => __pbn__soundevent_guid = null;
        private int? __pbn__soundevent_guid;

        [global::ProtoBuf.ProtoMember(2, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public uint soundevent_hash
        {
            get => __pbn__soundevent_hash.GetValueOrDefault();
            set => __pbn__soundevent_hash = value;
        }
        public bool ShouldSerializesoundevent_hash() => __pbn__soundevent_hash != null;
        public void Resetsoundevent_hash() => __pbn__soundevent_hash = null;
        private uint? __pbn__soundevent_hash;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(-1)]
        public int source_entity_index
        {
            get => __pbn__source_entity_index ?? -1;
            set => __pbn__source_entity_index = value;
        }
        public bool ShouldSerializesource_entity_index() => __pbn__source_entity_index != null;
        public void Resetsource_entity_index() => __pbn__source_entity_index = null;
        private int? __pbn__source_entity_index;

        [global::ProtoBuf.ProtoMember(4)]
        public int seed
        {
            get => __pbn__seed.GetValueOrDefault();
            set => __pbn__seed = value;
        }
        public bool ShouldSerializeseed() => __pbn__seed != null;
        public void Resetseed() => __pbn__seed = null;
        private int? __pbn__seed;

        [global::ProtoBuf.ProtoMember(5)]
        public byte[] packed_params
        {
            get => __pbn__packed_params;
            set => __pbn__packed_params = value;
        }
        public bool ShouldSerializepacked_params() => __pbn__packed_params != null;
        public void Resetpacked_params() => __pbn__packed_params = null;
        private byte[] __pbn__packed_params;

        [global::ProtoBuf.ProtoMember(6)]
        public float start_time
        {
            get => __pbn__start_time.GetValueOrDefault();
            set => __pbn__start_time = value;
        }
        public bool ShouldSerializestart_time() => __pbn__start_time != null;
        public void Resetstart_time() => __pbn__start_time = null;
        private float? __pbn__start_time;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgSosStopSoundEvent : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public int soundevent_guid
        {
            get => __pbn__soundevent_guid.GetValueOrDefault();
            set => __pbn__soundevent_guid = value;
        }
        public bool ShouldSerializesoundevent_guid() => __pbn__soundevent_guid != null;
        public void Resetsoundevent_guid() => __pbn__soundevent_guid = null;
        private int? __pbn__soundevent_guid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgSosStopSoundEventHash : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public uint soundevent_hash
        {
            get => __pbn__soundevent_hash.GetValueOrDefault();
            set => __pbn__soundevent_hash = value;
        }
        public bool ShouldSerializesoundevent_hash() => __pbn__soundevent_hash != null;
        public void Resetsoundevent_hash() => __pbn__soundevent_hash = null;
        private uint? __pbn__soundevent_hash;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(-1)]
        public int source_entity_index
        {
            get => __pbn__source_entity_index ?? -1;
            set => __pbn__source_entity_index = value;
        }
        public bool ShouldSerializesource_entity_index() => __pbn__source_entity_index != null;
        public void Resetsource_entity_index() => __pbn__source_entity_index = null;
        private int? __pbn__source_entity_index;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgSosSetSoundEventParams : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public int soundevent_guid
        {
            get => __pbn__soundevent_guid.GetValueOrDefault();
            set => __pbn__soundevent_guid = value;
        }
        public bool ShouldSerializesoundevent_guid() => __pbn__soundevent_guid != null;
        public void Resetsoundevent_guid() => __pbn__soundevent_guid = null;
        private int? __pbn__soundevent_guid;

        [global::ProtoBuf.ProtoMember(5)]
        public byte[] packed_params
        {
            get => __pbn__packed_params;
            set => __pbn__packed_params = value;
        }
        public bool ShouldSerializepacked_params() => __pbn__packed_params != null;
        public void Resetpacked_params() => __pbn__packed_params = null;
        private byte[] __pbn__packed_params;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgSosSetLibraryStackFields : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public uint stack_hash
        {
            get => __pbn__stack_hash.GetValueOrDefault();
            set => __pbn__stack_hash = value;
        }
        public bool ShouldSerializestack_hash() => __pbn__stack_hash != null;
        public void Resetstack_hash() => __pbn__stack_hash = null;
        private uint? __pbn__stack_hash;

        [global::ProtoBuf.ProtoMember(5)]
        public byte[] packed_fields
        {
            get => __pbn__packed_fields;
            set => __pbn__packed_fields = value;
        }
        public bool ShouldSerializepacked_fields() => __pbn__packed_fields != null;
        public void Resetpacked_fields() => __pbn__packed_fields = null;
        private byte[] __pbn__packed_fields;

    }

    [global::ProtoBuf.ProtoContract()]
    public enum EBaseGameEvents
    {
        GE_VDebugGameSessionIDEvent = 200,
        GE_PlaceDecalEvent = 201,
        GE_ClearWorldDecalsEvent = 202,
        GE_ClearEntityDecalsEvent = 203,
        GE_ClearDecalsForSkeletonInstanceEvent = 204,
        GE_Source1LegacyGameEventList = 205,
        GE_Source1LegacyListenEvents = 206,
        GE_Source1LegacyGameEvent = 207,
        GE_SosStartSoundEvent = 208,
        GE_SosStopSoundEvent = 209,
        GE_SosSetSoundEventParams = 210,
        GE_SosSetLibraryStackFields = 211,
        GE_SosStopSoundEventHash = 212,
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion

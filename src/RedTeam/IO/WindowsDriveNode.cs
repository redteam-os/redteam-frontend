﻿using System;
using System.Collections.Generic;
using System.IO;

namespace RedTeam.IO
{
    public class WindowsDriveNode : Node
    {
        private WindowsPseudoNode _node;
        private DriveInfo _drive;

        public WindowsDriveNode(WindowsPseudoNode node, DriveInfo drive)
        {
            _node = node;
            _drive = drive;
        }

        public override bool CanRead => false;
        public override bool CanWrite => false;
        public override bool CanExecute => false;
        public override bool CanList => true;
        public override bool CanCreate => true;
        public override Node Parent => _node;

        public override IEnumerable<Node> Children
        {
            get
            {
                var root = _drive.RootDirectory.FullName;
                foreach (var dir in Directory.GetDirectories(root, "*", new EnumerationOptions()))
                {
                    yield return new HostDirectoryNode(this, dir);
                }

                foreach (var file in Directory.GetFiles(root))
                {
                    yield return new HostFileNode(this, file);
                }
            }
        }
        public override string Name => _drive.Name.ToLower().Replace(":\\", "");
    }
}